Imports System.Drawing.Text
Imports System.Runtime.InteropServices

Public Class Form1
    Dim ContemporaryFont As New PrivateFontCollection
    Dim ContemporaryBuffer As IntPtr

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim font As Byte() = My.Resources.Contemporary_Regular
        ContemporaryBuffer = Marshal.AllocCoTaskMem(font.Length)
        Marshal.Copy(font, 0, ContemporaryBuffer, font.Length)
        ContemporaryFont.AddMemoryFont(ContemporaryBuffer, font.Length)
        Me.Font = New Font(ContemporaryFont.Families(0), 10, FontStyle.Regular)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "theHop"
    End Sub
End Class
