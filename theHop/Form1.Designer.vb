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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TitleBar1 = New theHop.TitleBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContemporaryButton1 = New theHop.ContemporaryButton()
        Me.TransferAway = New theHop.ContemporaryButton()
        Me.TransferTo = New theHop.ContemporaryButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleBar1
        '
        Me.TitleBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TitleBar1.CanClose = True
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
        Me.Label2.Size = New System.Drawing.Size(504, 104)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = resources.GetString("Label2.Text")
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
        'TransferAway
        '
        Me.TransferAway.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TransferAway.ButtonType = theHop.ContemporaryButton.BtnType.Flat
        Me.TransferAway.FlatAppearance.BorderSize = 0
        Me.TransferAway.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.TransferAway.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TransferAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TransferAway.ForeColor = System.Drawing.Color.White
        Me.TransferAway.Image = Global.theHop.My.Resources.Resources.go_next_64
        Me.TransferAway.Location = New System.Drawing.Point(270, 185)
        Me.TransferAway.Name = "TransferAway"
        Me.TransferAway.Size = New System.Drawing.Size(250, 95)
        Me.TransferAway.TabIndex = 8
        Me.TransferAway.Text = "Transfer from this device"
        Me.TransferAway.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TransferAway.UseVisualStyleBackColor = False
        '
        'TransferTo
        '
        Me.TransferTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TransferTo.ButtonType = theHop.ContemporaryButton.BtnType.Flat
        Me.TransferTo.FlatAppearance.BorderSize = 0
        Me.TransferTo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.TransferTo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TransferTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TransferTo.ForeColor = System.Drawing.Color.White
        Me.TransferTo.Image = Global.theHop.My.Resources.Resources.go_previous_64
        Me.TransferTo.Location = New System.Drawing.Point(19, 185)
        Me.TransferTo.Name = "TransferTo"
        Me.TransferTo.Size = New System.Drawing.Size(250, 95)
        Me.TransferTo.TabIndex = 9
        Me.TransferTo.Text = "Transfer to this device"
        Me.TransferTo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TransferTo.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(532, 334)
        Me.Controls.Add(Me.TransferTo)
        Me.Controls.Add(Me.TransferAway)
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
    Friend WithEvents TransferAway As ContemporaryButton
    Friend WithEvents TransferTo As ContemporaryButton
End Class
