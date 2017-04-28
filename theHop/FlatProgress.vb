Imports System.Windows.Forms
Imports System.Drawing

Public Class FlatProgress
    Private ValueVal As Decimal = 1
    Public Property Value() As Decimal
        Get
            Return ValueVal
        End Get
        Set(ByVal value As Decimal)
            ValueVal = value
        End Set
    End Property

    Private MaxVal As Decimal = 100
    Public Property Maximum() As Decimal
        Get
            Return MaxVal
        End Get
        Set(ByVal value As Decimal)
            MaxVal = value
        End Set
    End Property

    Private BorderEnabled As Boolean
    Public Property Border() As Boolean
        Get
            Return BorderEnabled
        End Get
        Set(ByVal value As Boolean)
            BorderEnabled = value
        End Set
    End Property

    Private IsIndeterminate As Boolean = False
    Public Property Indeterminate() As Boolean
        Get
            Return IsIndeterminate
        End Get
        Set(ByVal value As Boolean)
            IsIndeterminate = value
            Panel1.Visible = value
            Panel1.Left = 0
            Panel1.Width = 0
            Panel1.BackColor = ForeColor

            Panel2.Visible = value
            Panel2.Left = 0
            Panel2.Width = 0

        End Set
    End Property

    Private Sub FlatProgress_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim Percentage As Single = (ValueVal / MaxVal)
        e.Graphics.FillRectangle(New SolidBrush(Me.ForeColor), 0, 0, Percentage * Me.Width, Me.Height)
        If Border Then e.Graphics.DrawRectangle(Pens.Gray, Me.ClientRectangle)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Invalidate()
    End Sub

    Private Sub FlatProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Dim IndeterminateStage As Integer = 1

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Static stage As Integer = 0
        Static pos As Boolean = False
        Dim half As Integer = Me.Width / 2
        'Panel1.Visible = True
        'Panel2.Visible = True

        'Select Case stage
        '    Case 0
        '        If Panel1.Width > half - 40 Then
        '            Panel1.Width += 1
        '            Panel2.Width -= 10
        '            Panel2.Left += 10
        '            If Panel1.Width >= half Then stage = 1 : Panel2.Width = 0 : Panel2.Left = half
        '        ElseIf Panel1.Width > (half / 2 / 2) + half Then
        '            Panel1.Width += 5
        '            Panel2.Width -= 5
        '            Panel2.Left += 5
        '        Else
        '            Panel1.Width += 10
        '            Panel2.Width -= 1
        '            Panel2.Left += 1
        '        End If
        '    Case 1
        '        Panel2.Left = half
        '        If Panel1.Width > half - 10 Then
        '            Panel1.Width -= 10
        '            Panel1.Left += 10
        '            Panel2.Width += 1
        '        ElseIf Panel1.Width > (half / 2 / 2) + half Then
        '            Panel1.Width -= 5
        '            Panel1.Left += 5
        '            Panel2.Width += 5
        '        Else
        '            Panel1.Width -= 10
        '            Panel1.Left += 10
        '            Panel2.Width += 10
        '            If Panel1.Width <= 0 Then
        '                stage = 0
        '                'pos = Not pos
        '                'If pos Then Panel1.Left = 0
        '                Panel1.Left = 0
        '            End If
        '        End If
        'End Select
        If Indeterminate Then
            Dim factor As Integer = Me.Width / 100

            If IndeterminateStage = 1 Then
                If Panel1.Left > Me.Width / 50 Then
                    factor *= 2
                End If

                Panel1.Left += factor
                Panel1.Width += factor

                If Panel1.Left >= Me.Width Then
                    Panel1.Width = 0
                    Panel1.Left = 0
                    IndeterminateStage = 2
                End If
            ElseIf IndeterminateStage = 2 Then
                Panel1.Width += factor * 2
                If Panel1.Width >= Me.Width Then
                    'Me.BackColor = Me.ForeColor
                    'Panel1.Width = 0
                    'Panel1.Left = 0
                    Panel2.Left = 0
                    Panel2.Width = 0
                    IndeterminateStage = 3
                End If
            ElseIf IndeterminateStage = 3
                If Panel2.Left > Me.Width / 50 Then
                    factor *= 2
                End If

                Panel2.Left += factor
                Panel2.Width += factor

                If Panel2.Left >= Me.Width Then
                    Panel2.Width = 0
                    Panel2.Left = 0
                    IndeterminateStage = 4
                End If
            ElseIf IndeterminateStage = 4 Then
                Panel2.Width += factor * 2
                If Panel2.Width >= Me.Width Then
                    'Me.BackColor = Color.White
                    Panel2.Width = 0
                    Panel2.Left = 0
                    Panel1.Left = 0
                    Panel1.Width = 0
                    IndeterminateStage = 1
                End If
            End If
        End If
    End Sub

    Private Sub FlatProgress_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Panel1.Left = 0
        Panel1.Width = 0
    End Sub
End Class
