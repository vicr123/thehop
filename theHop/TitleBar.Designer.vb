<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TitleBar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CloseButton = New theHop.ContemporaryButton()
        Me.WindowText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CloseButton.ButtonType = theHop.ContemporaryButton.BtnType.Flat
        Me.CloseButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.Image = Global.theHop.My.Resources.Resources.window_close
        Me.CloseButton.Location = New System.Drawing.Point(343, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(32, 32)
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'WindowText
        '
        Me.WindowText.AutoSize = True
        Me.WindowText.Font = New System.Drawing.Font("Contemporary", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowText.Location = New System.Drawing.Point(20, 7)
        Me.WindowText.Name = "WindowText"
        Me.WindowText.Size = New System.Drawing.Size(90, 17)
        Me.WindowText.TabIndex = 1
        Me.WindowText.Text = "Window Text"
        '
        'TitleBar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.WindowText)
        Me.Controls.Add(Me.CloseButton)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "TitleBar"
        Me.Size = New System.Drawing.Size(375, 32)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseButton As ContemporaryButton
    Friend WithEvents WindowText As Label
End Class
