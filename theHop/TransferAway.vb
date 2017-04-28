Imports System.IO
Imports System.Net.Security
Imports System.Net.Sockets
Imports System.Security.Cryptography
Imports System.Text

Public Class TransferAway
    Dim Tcp As TcpClient
    Dim dataSocket As NetworkStream
    Dim encryptionKey() As Byte

    Enum PaneTypes
        TransferType = 0
        DiskSelect
        NetworkSetup
    End Enum

    Dim currentPane As PaneTypes
    Sub SwitchPane(pane As PaneTypes)
        paneTransferType.Visible = False
        paneNetwork.Visible = False

        Select Case pane
            Case PaneTypes.TransferType
                paneTransferType.Visible = True
                NextButton.Visible = False
                BackButton.Visible = False
            Case PaneTypes.NetworkSetup
                paneNetwork.Visible = True
                BackButton.Visible = True
                NextButton.Visible = False
        End Select
        TitleBar1.SendToBack()
    End Sub

    Private Sub UseNetwork_Click(sender As Object, e As EventArgs) Handles UseNetwork.Click
        SwitchPane(PaneTypes.NetworkSetup)
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Select Case currentPane
            Case PaneTypes.NetworkSetup, PaneTypes.DiskSelect
                SwitchPane(PaneTypes.TransferType)
            Case Else
                SwitchPane(currentPane - 1)
        End Select
    End Sub

    Private Sub NumberCode_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles NumberCode.MaskInputRejected

    End Sub

    Private Sub NumberCode_TextChanged(sender As Object, e As EventArgs) Handles NumberCode.TextChanged
        If NumberCode.Text.Length = 17 Then
            'Connect to other PC
            Dim addr As Long = NumberCode.Text.Remove(5, 1).Remove(11, 5)
            Dim bytes() As Byte = BitConverter.GetBytes(addr)

            If BitConverter.IsLittleEndian Then
                bytes = bytes.Reverse.ToArray
            End If
            Dim bytesList As List(Of Byte) = bytes.ToList
            bytesList.RemoveRange(0, 4)
            bytes = bytesList.ToArray

            Dim key As String = NumberCode.Text.Remove(0, 12)
            encryptionKey = SHA256Managed.Create.ComputeHash(System.Text.Encoding.Unicode.GetBytes(key))

            Dim ip As New Net.IPAddress(bytes)
            Tcp = New TcpClient()
            Tcp.Connect(ip, 26160)
            dataSocket = Tcp.GetStream()
            WriteText("HELLO")

            Me.Enabled = True

            'connection.BeginConnect(ip, 26160,
            '    Sub()
            '        Dim Crypto As New AesManaged

            '        Dim iv As Byte() = {&H1, &H2, &H3, &H4, &H1, &H2, &H3, &H4, &H1, &H2, &H3, &H4, &H1, &H2, &H3, &H4}
            '        dataWriteSocket = New CryptoStream(connection.GetStream, Crypto.CreateEncryptor(encryptionKey, iv), CryptoStreamMode.Write)
            '        dataReadSocket = New CryptoStream(connection.GetStream, Crypto.CreateEncryptor(encryptionKey, iv), CryptoStreamMode.Read)

            '        dataWriter = New StreamWriter(connection.GetStream)
            '        dataWriter.WriteLine("HELLO")
            '        dataWriter.Flush()

            '        Me.Invoke(Sub()
            '                      Me.Enabled = True
            '                  End Sub)
            '    End Sub, Nothing)
            'Me.Enabled = False
        End If
    End Sub

    Sub WriteText(text As String)
        Dim bytes As Byte() = EncryptBytes(Encoding.Unicode.GetBytes(text + vbCr))
        dataSocket.Write(bytes, 0, bytes.Length)
        dataSocket.Write(Encoding.Unicode.GetBytes(vbCr), 0, 1)
        dataSocket.Flush()
    End Sub

    Function EncryptBytes(bytes As Byte()) As Byte()
        Dim encrypted() As Byte

        Using aesAlg = Aes.Create()
            aesAlg.Key = encryptionKey
            aesAlg.IV = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16}
            Dim encryptor As ICryptoTransform = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)
            Using msEncrypt As New MemoryStream()
                Using csEncrypt As New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)
                    csEncrypt.Write(bytes, 0, bytes.Length)
                    csEncrypt.FlushFinalBlock()
                    encrypted = msEncrypt.ToArray()
                End Using
            End Using
        End Using

        Return encrypted
    End Function
End Class