<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransferAway
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlatProgress1 = New theHop.FlatProgress()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.paneTransferType = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UseNetwork = New theHop.ContemporaryButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UseMedia = New theHop.ContemporaryButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BackButton = New theHop.ContemporaryButton()
        Me.NextButton = New theHop.ContemporaryButton()
        Me.ContemporaryButton1 = New theHop.ContemporaryButton()
        Me.paneNetwork = New System.Windows.Forms.Panel()
        Me.NumberCode = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneTransferType.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.paneNetwork.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleBar1
        '
        Me.TitleBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TitleBar1.CanClose = True
        Me.TitleBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar1.ForeColor = System.Drawing.Color.White
        Me.TitleBar1.Location = New System.Drawing.Point(0, 0)
        Me.TitleBar1.Name = "TitleBar1"
        Me.TitleBar1.Size = New System.Drawing.Size(732, 32)
        Me.TitleBar1.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.FlatProgress1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 496)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(732, 96)
        Me.Panel1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(0, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(732, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Scanning files..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlatProgress1
        '
        Me.FlatProgress1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FlatProgress1.Border = False
        Me.FlatProgress1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.FlatProgress1.Indeterminate = True
        Me.FlatProgress1.Location = New System.Drawing.Point(103, 52)
        Me.FlatProgress1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FlatProgress1.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.FlatProgress1.Name = "FlatProgress1"
        Me.FlatProgress1.Size = New System.Drawing.Size(525, 13)
        Me.FlatProgress1.TabIndex = 1
        Me.FlatProgress1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(732, 1)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Contemporary", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 32)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Transfer Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(349, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "How would you like to transfer data from this device?"
        '
        'paneTransferType
        '
        Me.paneTransferType.Controls.Add(Me.Label5)
        Me.paneTransferType.Controls.Add(Me.UseNetwork)
        Me.paneTransferType.Controls.Add(Me.Label4)
        Me.paneTransferType.Controls.Add(Me.UseMedia)
        Me.paneTransferType.Controls.Add(Me.Label2)
        Me.paneTransferType.Controls.Add(Me.Label3)
        Me.paneTransferType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.paneTransferType.Location = New System.Drawing.Point(0, 0)
        Me.paneTransferType.Name = "paneTransferType"
        Me.paneTransferType.Size = New System.Drawing.Size(732, 592)
        Me.paneTransferType.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(418, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Use the network to transfer data between two running devices"
        '
        'UseNetwork
        '
        Me.UseNetwork.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UseNetwork.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.UseNetwork.ButtonType = theHop.ContemporaryButton.BtnType.Colour
        Me.UseNetwork.FlatAppearance.BorderSize = 0
        Me.UseNetwork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.UseNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.UseNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UseNetwork.ForeColor = System.Drawing.Color.White
        Me.UseNetwork.Location = New System.Drawing.Point(21, 179)
        Me.UseNetwork.Name = "UseNetwork"
        Me.UseNetwork.Size = New System.Drawing.Size(699, 32)
        Me.UseNetwork.TabIndex = 15
        Me.UseNetwork.Text = "Use the network"
        Me.UseNetwork.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(416, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Transfer data from this device onto an external storage device."
        '
        'UseMedia
        '
        Me.UseMedia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UseMedia.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.UseMedia.ButtonType = theHop.ContemporaryButton.BtnType.Colour
        Me.UseMedia.FlatAppearance.BorderSize = 0
        Me.UseMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.UseMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.UseMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UseMedia.ForeColor = System.Drawing.Color.White
        Me.UseMedia.Location = New System.Drawing.Point(21, 86)
        Me.UseMedia.Name = "UseMedia"
        Me.UseMedia.Size = New System.Drawing.Size(699, 32)
        Me.UseMedia.TabIndex = 13
        Me.UseMedia.Text = "Use an external hard disk"
        Me.UseMedia.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BackButton)
        Me.Panel3.Controls.Add(Me.NextButton)
        Me.Panel3.Controls.Add(Me.ContemporaryButton1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 447)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(732, 49)
        Me.Panel3.TabIndex = 14
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BackButton.ButtonType = theHop.ContemporaryButton.BtnType.Colour
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Image = Global.theHop.My.Resources.Resources.go_previous
        Me.BackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BackButton.Location = New System.Drawing.Point(548, 7)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(86, 36)
        Me.BackButton.TabIndex = 2
        Me.BackButton.Text = "Back"
        Me.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'NextButton
        '
        Me.NextButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NextButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.NextButton.ButtonType = theHop.ContemporaryButton.BtnType.Colour
        Me.NextButton.FlatAppearance.BorderSize = 0
        Me.NextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.NextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextButton.ForeColor = System.Drawing.Color.White
        Me.NextButton.Image = Global.theHop.My.Resources.Resources.go_next
        Me.NextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NextButton.Location = New System.Drawing.Point(634, 7)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(86, 36)
        Me.NextButton.TabIndex = 1
        Me.NextButton.Text = "Next"
        Me.NextButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.NextButton.UseVisualStyleBackColor = False
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
        Me.ContemporaryButton1.Location = New System.Drawing.Point(12, 7)
        Me.ContemporaryButton1.Name = "ContemporaryButton1"
        Me.ContemporaryButton1.Size = New System.Drawing.Size(115, 36)
        Me.ContemporaryButton1.TabIndex = 0
        Me.ContemporaryButton1.Text = "Cancel"
        Me.ContemporaryButton1.UseVisualStyleBackColor = False
        '
        'paneNetwork
        '
        Me.paneNetwork.Controls.Add(Me.NumberCode)
        Me.paneNetwork.Controls.Add(Me.Label8)
        Me.paneNetwork.Controls.Add(Me.Label9)
        Me.paneNetwork.Dock = System.Windows.Forms.DockStyle.Fill
        Me.paneNetwork.Location = New System.Drawing.Point(0, 0)
        Me.paneNetwork.Name = "paneNetwork"
        Me.paneNetwork.Size = New System.Drawing.Size(732, 592)
        Me.paneNetwork.TabIndex = 15
        Me.paneNetwork.Visible = False
        '
        'NumberCode
        '
        Me.NumberCode.Font = New System.Drawing.Font("Contemporary", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberCode.Location = New System.Drawing.Point(21, 77)
        Me.NumberCode.Mask = "00000 00000 00000"
        Me.NumberCode.Name = "NumberCode"
        Me.NumberCode.PromptChar = Global.Microsoft.VisualBasic.ChrW(45)
        Me.NumberCode.Size = New System.Drawing.Size(258, 39)
        Me.NumberCode.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Contemporary", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(204, 32)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Network Setup"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(411, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Open theHop on the other device, and enter the number here."
        '
        'TransferAway
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(732, 592)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TitleBar1)
        Me.Controls.Add(Me.paneNetwork)
        Me.Controls.Add(Me.paneTransferType)
        Me.Font = New System.Drawing.Font("Contemporary", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TransferAway"
        Me.Text = "Transfer data from this device"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneTransferType.ResumeLayout(False)
        Me.paneTransferType.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.paneNetwork.ResumeLayout(False)
        Me.paneNetwork.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitleBar1 As TitleBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlatProgress1 As FlatProgress
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents paneTransferType As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents UseNetwork As ContemporaryButton
    Friend WithEvents Label4 As Label
    Friend WithEvents UseMedia As ContemporaryButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BackButton As ContemporaryButton
    Friend WithEvents NextButton As ContemporaryButton
    Friend WithEvents ContemporaryButton1 As ContemporaryButton
    Friend WithEvents paneNetwork As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NumberCode As MaskedTextBox
End Class
