<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransactionMonitor
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim btnBack As System.Windows.Forms.Button
        Dim btnExit As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransactionMonitor))
        Me.Title1 = New System.Windows.Forms.Label()
        Me.Title2 = New System.Windows.Forms.Label()
        Me.pnlBG = New System.Windows.Forms.Panel()
        Me.pbr1 = New MetroFramework.Controls.MetroProgressBar()
        Me.txtBCinput = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.Timer(Me.components)
        Me.countDown = New System.Windows.Forms.Timer(Me.components)
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.pnlIssue = New System.Windows.Forms.Panel()
        Me.pbxBC = New System.Windows.Forms.PictureBox()
        Me.lblIssue = New System.Windows.Forms.Label()
        Me.pbxIssued = New System.Windows.Forms.PictureBox()
        Me.pnlStud = New System.Windows.Forms.Panel()
        Me.lblMem = New System.Windows.Forms.Label()
        Me.pbxStud = New System.Windows.Forms.PictureBox()
        Me.pnlBook = New System.Windows.Forms.Panel()
        Me.lblBook = New System.Windows.Forms.Label()
        Me.pbxBook = New System.Windows.Forms.PictureBox()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        btnBack = New System.Windows.Forms.Button()
        btnExit = New System.Windows.Forms.Button()
        Me.pnlBG.SuspendLayout()
        Me.pnlContainer.SuspendLayout()
        Me.pnlIssue.SuspendLayout()
        CType(Me.pbxBC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxIssued, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStud.SuspendLayout()
        CType(Me.pbxStud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBook.SuspendLayout()
        CType(Me.pbxBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title1
        '
        Me.Title1.AutoSize = True
        Me.Title1.BackColor = System.Drawing.Color.Transparent
        Me.Title1.Font = New System.Drawing.Font("Trajan Pro", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title1.ForeColor = System.Drawing.Color.White
        Me.Title1.Location = New System.Drawing.Point(116, 16)
        Me.Title1.Name = "Title1"
        Me.Title1.Size = New System.Drawing.Size(797, 61)
        Me.Title1.TabIndex = 61
        Me.Title1.Text = "Library Management System"
        '
        'Title2
        '
        Me.Title2.AutoSize = True
        Me.Title2.BackColor = System.Drawing.Color.Transparent
        Me.Title2.Font = New System.Drawing.Font("Trajan Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title2.ForeColor = System.Drawing.Color.White
        Me.Title2.Location = New System.Drawing.Point(122, 74)
        Me.Title2.Name = "Title2"
        Me.Title2.Size = New System.Drawing.Size(734, 27)
        Me.Title2.TabIndex = 60
        Me.Title2.Text = "Sri Lanka Institute Of Advanced Technological Education"
        '
        'pnlBG
        '
        Me.pnlBG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBG.BackColor = System.Drawing.Color.DarkGreen
        Me.pnlBG.Controls.Add(Me.pbr1)
        Me.pnlBG.Controls.Add(Me.txtBCinput)
        Me.pnlBG.Controls.Add(Me.pnlContainer)
        Me.pnlBG.Controls.Add(Me.lblTime)
        Me.pnlBG.Controls.Add(btnBack)
        Me.pnlBG.Controls.Add(btnExit)
        Me.pnlBG.Controls.Add(Me.pbxLogo)
        Me.pnlBG.Controls.Add(Me.Title2)
        Me.pnlBG.Controls.Add(Me.Title1)
        Me.pnlBG.Location = New System.Drawing.Point(-17, -14)
        Me.pnlBG.Name = "pnlBG"
        Me.pnlBG.Size = New System.Drawing.Size(1092, 724)
        Me.pnlBG.TabIndex = 0
        '
        'pbr1
        '
        Me.pbr1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbr1.Location = New System.Drawing.Point(41, 697)
        Me.pbr1.Name = "pbr1"
        Me.pbr1.Size = New System.Drawing.Size(1020, 10)
        Me.pbr1.Step = 1
        Me.pbr1.Style = MetroFramework.MetroColorStyle.Green
        Me.pbr1.TabIndex = 3
        Me.pbr1.Value = 100
        '
        'txtBCinput
        '
        Me.txtBCinput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBCinput.BackColor = System.Drawing.Color.DarkGreen
        Me.txtBCinput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBCinput.ForeColor = System.Drawing.Color.Lime
        Me.txtBCinput.Location = New System.Drawing.Point(991, 59)
        Me.txtBCinput.Name = "txtBCinput"
        Me.txtBCinput.Size = New System.Drawing.Size(91, 13)
        Me.txtBCinput.TabIndex = 0
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblTime.Location = New System.Drawing.Point(900, 67)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(161, 34)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "23:59:59"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'time
        '
        Me.time.Interval = 1000
        '
        'countDown
        '
        Me.countDown.Interval = 250
        '
        'pnlContainer
        '
        Me.pnlContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContainer.BackColor = System.Drawing.Color.White
        Me.pnlContainer.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.bgg1
        Me.pnlContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlContainer.Controls.Add(Me.pnlIssue)
        Me.pnlContainer.Controls.Add(Me.pnlStud)
        Me.pnlContainer.Controls.Add(Me.pnlBook)
        Me.pnlContainer.Location = New System.Drawing.Point(40, 108)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(1021, 583)
        Me.pnlContainer.TabIndex = 0
        '
        'pnlIssue
        '
        Me.pnlIssue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlIssue.BackColor = System.Drawing.Color.Transparent
        Me.pnlIssue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlIssue.Controls.Add(Me.pbxBC)
        Me.pnlIssue.Controls.Add(Me.lblIssue)
        Me.pnlIssue.Controls.Add(Me.pbxIssued)
        Me.pnlIssue.Location = New System.Drawing.Point(8, 332)
        Me.pnlIssue.Name = "pnlIssue"
        Me.pnlIssue.Size = New System.Drawing.Size(1000, 241)
        Me.pnlIssue.TabIndex = 0
        '
        'pbxBC
        '
        Me.pbxBC.BackColor = System.Drawing.Color.Transparent
        Me.pbxBC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxBC.Image = Global.LibrarySystem.My.Resources.Resources.barcode
        Me.pbxBC.Location = New System.Drawing.Point(0, 0)
        Me.pbxBC.Name = "pbxBC"
        Me.pbxBC.Size = New System.Drawing.Size(996, 237)
        Me.pbxBC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxBC.TabIndex = 1
        Me.pbxBC.TabStop = False
        '
        'lblIssue
        '
        Me.lblIssue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIssue.BackColor = System.Drawing.Color.Transparent
        Me.lblIssue.Font = New System.Drawing.Font("Trajan Pro", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssue.ForeColor = System.Drawing.Color.Black
        Me.lblIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblIssue.Location = New System.Drawing.Point(0, 0)
        Me.lblIssue.Margin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblIssue.Name = "lblIssue"
        Me.lblIssue.Size = New System.Drawing.Size(808, 237)
        Me.lblIssue.TabIndex = 0
        Me.lblIssue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxIssued
        '
        Me.pbxIssued.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxIssued.Image = Global.LibrarySystem.My.Resources.Resources.invalid
        Me.pbxIssued.Location = New System.Drawing.Point(808, 0)
        Me.pbxIssued.Name = "pbxIssued"
        Me.pbxIssued.Size = New System.Drawing.Size(184, 237)
        Me.pbxIssued.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxIssued.TabIndex = 2
        Me.pbxIssued.TabStop = False
        '
        'pnlStud
        '
        Me.pnlStud.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlStud.BackColor = System.Drawing.Color.Transparent
        Me.pnlStud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlStud.Controls.Add(Me.lblMem)
        Me.pnlStud.Controls.Add(Me.pbxStud)
        Me.pnlStud.Location = New System.Drawing.Point(8, 168)
        Me.pnlStud.Name = "pnlStud"
        Me.pnlStud.Size = New System.Drawing.Size(1000, 157)
        Me.pnlStud.TabIndex = 0
        '
        'lblMem
        '
        Me.lblMem.BackColor = System.Drawing.Color.Transparent
        Me.lblMem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMem.Font = New System.Drawing.Font("Trajan Pro", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMem.ForeColor = System.Drawing.Color.Black
        Me.lblMem.Location = New System.Drawing.Point(0, 0)
        Me.lblMem.Name = "lblMem"
        Me.lblMem.Size = New System.Drawing.Size(996, 153)
        Me.lblMem.TabIndex = 0
        Me.lblMem.Text = "Verify Your " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Membership ID"
        Me.lblMem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxStud
        '
        Me.pbxStud.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxStud.Location = New System.Drawing.Point(797, 3)
        Me.pbxStud.Name = "pbxStud"
        Me.pbxStud.Size = New System.Drawing.Size(198, 149)
        Me.pbxStud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxStud.TabIndex = 0
        Me.pbxStud.TabStop = False
        '
        'pnlBook
        '
        Me.pnlBook.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBook.BackColor = System.Drawing.Color.Transparent
        Me.pnlBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBook.Controls.Add(Me.lblBook)
        Me.pnlBook.Controls.Add(Me.pbxBook)
        Me.pnlBook.Location = New System.Drawing.Point(8, 6)
        Me.pnlBook.Name = "pnlBook"
        Me.pnlBook.Size = New System.Drawing.Size(1000, 157)
        Me.pnlBook.TabIndex = 0
        '
        'lblBook
        '
        Me.lblBook.BackColor = System.Drawing.Color.Transparent
        Me.lblBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBook.Font = New System.Drawing.Font("Trajan Pro", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBook.ForeColor = System.Drawing.Color.Black
        Me.lblBook.Location = New System.Drawing.Point(0, 0)
        Me.lblBook.Name = "lblBook"
        Me.lblBook.Size = New System.Drawing.Size(996, 153)
        Me.lblBook.TabIndex = 0
        Me.lblBook.Text = "Verify Your " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Book ID"
        Me.lblBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxBook
        '
        Me.pbxBook.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxBook.Location = New System.Drawing.Point(797, 3)
        Me.pbxBook.Name = "pbxBook"
        Me.pbxBook.Size = New System.Drawing.Size(198, 149)
        Me.pbxBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxBook.TabIndex = 0
        Me.pbxBook.TabStop = False
        '
        'btnBack
        '
        btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnBack.BackColor = System.Drawing.Color.Transparent
        btnBack.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.BackButton
        btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnBack.Location = New System.Drawing.Point(1000, 16)
        btnBack.Name = "btnBack"
        btnBack.Size = New System.Drawing.Size(38, 37)
        btnBack.TabIndex = 62
        btnBack.UseVisualStyleBackColor = False
        AddHandler btnBack.Click, AddressOf Me.btnBack_Click
        '
        'btnExit
        '
        btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnExit.BackColor = System.Drawing.Color.Transparent
        btnExit.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.close
        btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnExit.Location = New System.Drawing.Point(1044, 16)
        btnExit.Name = "btnExit"
        btnExit.Size = New System.Drawing.Size(38, 37)
        btnExit.TabIndex = 63
        btnExit.UseVisualStyleBackColor = False
        AddHandler btnExit.Click, AddressOf Me.btnExit_Click
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.Image = Global.LibrarySystem.My.Resources.Resources.SliateLogo
        Me.pbxLogo.Location = New System.Drawing.Point(17, 16)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(93, 86)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 59
        Me.pbxLogo.TabStop = False
        '
        'frmTransactionMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlBG)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTransactionMonitor"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlBG.ResumeLayout(False)
        Me.pnlBG.PerformLayout()
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlIssue.ResumeLayout(False)
        CType(Me.pbxBC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxIssued, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStud.ResumeLayout(False)
        CType(Me.pbxStud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBook.ResumeLayout(False)
        CType(Me.pbxBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Title1 As System.Windows.Forms.Label
    Friend WithEvents Title2 As System.Windows.Forms.Label
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents pnlBG As System.Windows.Forms.Panel
    Friend WithEvents pnlContainer As System.Windows.Forms.Panel
    Friend WithEvents time As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents pnlIssue As System.Windows.Forms.Panel
    Friend WithEvents pnlStud As System.Windows.Forms.Panel
    Friend WithEvents pnlBook As System.Windows.Forms.Panel
    Friend WithEvents lblMem As System.Windows.Forms.Label
    Friend WithEvents pbxStud As System.Windows.Forms.PictureBox
    Friend WithEvents lblBook As System.Windows.Forms.Label
    Friend WithEvents pbxBook As System.Windows.Forms.PictureBox
    Friend WithEvents txtBCinput As System.Windows.Forms.TextBox
    Friend WithEvents lblIssue As System.Windows.Forms.Label
    Friend WithEvents pbxBC As System.Windows.Forms.PictureBox
    Friend WithEvents pbxIssued As System.Windows.Forms.PictureBox
    Friend WithEvents countDown As System.Windows.Forms.Timer
    Friend WithEvents pbr1 As MetroFramework.Controls.MetroProgressBar
End Class
