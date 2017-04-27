<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TitleBar1 = New theHop.TitleBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContemporaryButton1 = New theHop.ContemporaryButton()
        Me.ContemporaryButton2 = New theHop.ContemporaryButton()
        Me.ContemporaryButton3 = New theHop.ContemporaryButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleBar1
        '
        Me.TitleBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TitleBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar1.ForeColor = System.Drawing.Color.White
        Me.TitleBar1.Location = New System.Drawing.Point(1, 1)
        Me.TitleBar1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TitleBar1.Name = "TitleBar1"
        Me.TitleBar1.Size = New System.Drawing.Size(530, 32)
        Me.TitleBar1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1, 333)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Location = New System.Drawing.Point(531, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1, 333)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(532, 1)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox4.Location = New System.Drawing.Point(1, 333)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(530, 1)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Contemporary", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "theHop"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(504, 34)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Use theHop to transfer your files from this device to another device, or from ano" &
    "ther device to this device."
        '
        'ContemporaryButton1
        '
        Me.ContemporaryButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ContemporaryButton1.ButtonType = theHop.ContemporaryButton.BtnType.Colour
        Me.ContemporaryButton1.FlatAppearance.BorderSize = 0
        Me.ContemporaryButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ContemporaryButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ContemporaryButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContemporaryButton1.ForeColor = System.Drawing.Color.White
        Me.ContemporaryButton1.Image = Global.theHop.My.Resources.Resources.application_exit
        Me.ContemporaryButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ContemporaryButton1.Location = New System.Drawing.Point(392, 286)
        Me.ContemporaryButton1.Name = "ContemporaryButton1"
        Me.ContemporaryButton1.Size = New System.Drawing.Size(128, 36)
        Me.ContemporaryButton1.TabIndex = 7
        Me.ContemporaryButton1.Text = "Exit theHop"
        Me.ContemporaryButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ContemporaryButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ContemporaryButton1.UseVisualStyleBackColor = False
        '
        'ContemporaryButton2
        '
        Me.ContemporaryButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ContemporaryButton2.ButtonType = theHop.ContemporaryButton.BtnType.Flat
        Me.ContemporaryButton2.FlatAppearance.BorderSize = 0
        Me.ContemporaryButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ContemporaryButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ContemporaryButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContemporaryButton2.ForeColor = System.Drawing.Color.White
        Me.ContemporaryButton2.Image = Global.theHop.My.Resources.Resources.go_next_64
        Me.ContemporaryButton2.Location = New System.Drawing.Point(270, 185)
        Me.ContemporaryButton2.Name = "ContemporaryButton2"
        Me.ContemporaryButton2.Size = New System.Drawing.Size(250, 95)
        Me.ContemporaryButton2.TabIndex = 8
        Me.ContemporaryButton2.Text = "Transfer from this device"
        Me.ContemporaryButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ContemporaryButton2.UseVisualStyleBackColor = False
        '
        'ContemporaryButton3
        '
        Me.ContemporaryButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ContemporaryButton3.ButtonType = theHop.ContemporaryButton.BtnType.Flat
        Me.ContemporaryButton3.FlatAppearance.BorderSize = 0
        Me.ContemporaryButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ContemporaryButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ContemporaryButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContemporaryButton3.ForeColor = System.Drawing.Color.White
        Me.ContemporaryButton3.Image = Global.theHop.My.Resources.Resources.go_previous_64
        Me.ContemporaryButton3.Location = New System.Drawing.Point(19, 185)
        Me.ContemporaryButton3.Name = "ContemporaryButton3"
        Me.ContemporaryButton3.Size = New System.Drawing.Size(250, 95)
        Me.ContemporaryButton3.TabIndex = 9
        Me.ContemporaryButton3.Text = "Transfer to this device"
        Me.ContemporaryButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ContemporaryButton3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(532, 334)
        Me.Controls.Add(Me.ContemporaryButton3)
        Me.Controls.Add(Me.ContemporaryButton2)
        Me.Controls.Add(Me.ContemporaryButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.TitleBar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Font = New System.Drawing.Font("Contemporary", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "theHop"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleBar1 As TitleBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ContemporaryButton1 As ContemporaryButton
    Friend WithEvents ContemporaryButton2 As ContemporaryButton
    Friend WithEvents ContemporaryButton3 As ContemporaryButton
End Class
