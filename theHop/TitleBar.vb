Imports System.Runtime.InteropServices

Public Class TitleBar
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImport("user32.dll")>
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function
    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Public Property CanClose() As Boolean
        Get
            Return CloseButton.Visible
        End Get
        Set(ByVal value As Boolean)
            CloseButton.Visible = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Dock = DockStyle.Top
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        ParentForm.Close()
    End Sub

    Private Sub TitleBar_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler Me.ParentForm.TextChanged, Sub()
                                                  WindowText.Text = Me.ParentForm.Text
                                              End Sub
        WindowText.Text = Me.ParentForm.Text
    End Sub

    Private Sub TitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, WindowText.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.ParentForm.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
End Class
