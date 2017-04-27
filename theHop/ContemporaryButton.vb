Public Class ContemporaryButton
    Inherits Button

    Enum BtnType
        Colour
        Flat
    End Enum

    Private currentType As BtnType = BtnType.Colour
    Public Property ButtonType() As BtnType
        Get
            Return currentType
        End Get
        Set(ByVal value As BtnType)
            currentType = value

            If value = BtnType.Colour Then
                Me.BackColor = Color.FromArgb(0, 50, 150)
                Me.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 75, 225)
                Me.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 25, 75)
                Me.FlatAppearance.BorderSize = 0
                Me.ForeColor = Color.White
            Else
                Me.BackColor = Color.FromArgb(40, 40, 40)
                Me.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60)
                Me.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20)
                Me.FlatAppearance.BorderSize = 0
                Me.ForeColor = Color.White
            End If
        End Set
    End Property

    Public Sub New()
        Me.FlatStyle = FlatStyle.Flat
        ButtonType = BtnType.Colour
        Me.Height = 36
    End Sub
End Class
