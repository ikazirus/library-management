<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits MetroFramework.Forms.MetroForm
    ' Inherits System.Windows.Forms.Form

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
        Dim btnExit As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlMenu = New MetroFramework.Controls.MetroPanel()
        Me.lblPatronName = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Title1 = New System.Windows.Forms.Label()
        Me.Title2 = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.lblMenuTitle = New System.Windows.Forms.Label()
        Me.pnlMenuSub = New System.Windows.Forms.Panel()
        Me.lblBooks = New System.Windows.Forms.Label()
        Me.lblPrint = New System.Windows.Forms.Label()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.lblReports = New System.Windows.Forms.Label()
        Me.lblMembers = New System.Windows.Forms.Label()
        Me.lblIssue = New System.Windows.Forms.Label()
        Me.btnIssue = New System.Windows.Forms.Button()
        Me.btnMembers = New System.Windows.Forms.Button()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        btnExit = New System.Windows.Forms.Button()
        Me.pnlMenu.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenuSub.SuspendLayout()
        Me.SuspendLayout()
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
        btnExit.Location = New System.Drawing.Point(1062, 11)
        btnExit.Name = "btnExit"
        btnExit.Size = New System.Drawing.Size(38, 37)
        btnExit.TabIndex = 3
        btnExit.UseVisualStyleBackColor = False
        AddHandler btnExit.Click, AddressOf Me.btnExit_Click
        '
        'pnlMenu
        '
        Me.pnlMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlMenu.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.bg
        Me.pnlMenu.Controls.Add(Me.lblPatronName)
        Me.pnlMenu.Controls.Add(Me.lblStatus)
        Me.pnlMenu.Controls.Add(btnExit)
        Me.pnlMenu.Controls.Add(Me.Title1)
        Me.pnlMenu.Controls.Add(Me.Title2)
        Me.pnlMenu.Controls.Add(Me.pbxLogo)
        Me.pnlMenu.Controls.Add(Me.lblMenuTitle)
        Me.pnlMenu.Controls.Add(Me.pnlMenuSub)
        Me.pnlMenu.Controls.Add(Me.btnAbout)
        Me.pnlMenu.Controls.Add(Me.btnLogout)
        Me.pnlMenu.ForeColor = System.Drawing.Color.White
        Me.pnlMenu.HorizontalScrollbarBarColor = True
        Me.pnlMenu.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlMenu.HorizontalScrollbarSize = 10
        Me.pnlMenu.Location = New System.Drawing.Point(-4, -4)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(1110, 709)
        Me.pnlMenu.TabIndex = 0
        Me.pnlMenu.UseCustomBackColor = True
        Me.pnlMenu.VerticalScrollbarBarColor = True
        Me.pnlMenu.VerticalScrollbarHighlightOnWheel = False
        Me.pnlMenu.VerticalScrollbarSize = 10
        '
        'lblPatronName
        '
        Me.lblPatronName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPatronName.BackColor = System.Drawing.Color.Black
        Me.lblPatronName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPatronName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPatronName.Font = New System.Drawing.Font("Trajan Pro", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatronName.ForeColor = System.Drawing.Color.Lime
        Me.lblPatronName.Location = New System.Drawing.Point(801, 111)
        Me.lblPatronName.Name = "lblPatronName"
        Me.lblPatronName.Size = New System.Drawing.Size(299, 43)
        Me.lblPatronName.TabIndex = 0
        Me.lblPatronName.Text = "User Name :"
        Me.lblPatronName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblStatus.Location = New System.Drawing.Point(3, 678)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(1066, 22)
        Me.lblStatus.TabIndex = 8
        '
        'Title1
        '
        Me.Title1.AutoSize = True
        Me.Title1.BackColor = System.Drawing.Color.Transparent
        Me.Title1.Font = New System.Drawing.Font("Trajan Pro", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title1.ForeColor = System.Drawing.Color.Yellow
        Me.Title1.Location = New System.Drawing.Point(103, 8)
        Me.Title1.Name = "Title1"
        Me.Title1.Size = New System.Drawing.Size(797, 61)
        Me.Title1.TabIndex = 6
        Me.Title1.Text = "Library Management System"
        '
        'Title2
        '
        Me.Title2.AutoSize = True
        Me.Title2.BackColor = System.Drawing.Color.Transparent
        Me.Title2.Font = New System.Drawing.Font("Trajan Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title2.ForeColor = System.Drawing.Color.Yellow
        Me.Title2.Location = New System.Drawing.Point(109, 66)
        Me.Title2.Name = "Title2"
        Me.Title2.Size = New System.Drawing.Size(734, 27)
        Me.Title2.TabIndex = 5
        Me.Title2.Text = "Sri Lanka Institute Of Advanced Technological Education"
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.Image = Global.LibrarySystem.My.Resources.Resources.SliateLogo
        Me.pbxLogo.Location = New System.Drawing.Point(4, 8)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(93, 86)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 4
        Me.pbxLogo.TabStop = False
        '
        'lblMenuTitle
        '
        Me.lblMenuTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMenuTitle.BackColor = System.Drawing.Color.Black
        Me.lblMenuTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMenuTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblMenuTitle.Font = New System.Drawing.Font("Trajan Pro", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMenuTitle.Location = New System.Drawing.Point(-8, 106)
        Me.lblMenuTitle.Name = "lblMenuTitle"
        Me.lblMenuTitle.Size = New System.Drawing.Size(1118, 54)
        Me.lblMenuTitle.TabIndex = 5
        Me.lblMenuTitle.Text = "MAIN MENU"
        Me.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMenuSub
        '
        Me.pnlMenuSub.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMenuSub.BackColor = System.Drawing.Color.Transparent
        Me.pnlMenuSub.Controls.Add(Me.lblBooks)
        Me.pnlMenuSub.Controls.Add(Me.lblPrint)
        Me.pnlMenuSub.Controls.Add(Me.lblSettings)
        Me.pnlMenuSub.Controls.Add(Me.lblReports)
        Me.pnlMenuSub.Controls.Add(Me.lblMembers)
        Me.pnlMenuSub.Controls.Add(Me.lblIssue)
        Me.pnlMenuSub.Controls.Add(Me.btnIssue)
        Me.pnlMenuSub.Controls.Add(Me.btnMembers)
        Me.pnlMenuSub.Controls.Add(Me.btnBooks)
        Me.pnlMenuSub.Controls.Add(Me.btnReports)
        Me.pnlMenuSub.Controls.Add(Me.btnPrint)
        Me.pnlMenuSub.Controls.Add(Me.btnSettings)
        Me.pnlMenuSub.Location = New System.Drawing.Point(20, 183)
        Me.pnlMenuSub.MaximumSize = New System.Drawing.Size(1097, 600)
        Me.pnlMenuSub.MinimumSize = New System.Drawing.Size(1054, 485)
        Me.pnlMenuSub.Name = "pnlMenuSub"
        Me.pnlMenuSub.Size = New System.Drawing.Size(1064, 501)
        Me.pnlMenuSub.TabIndex = 0
        '
        'lblBooks
        '
        Me.lblBooks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBooks.Font = New System.Drawing.Font("Trajan Pro", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBooks.ForeColor = System.Drawing.Color.Aqua
        Me.lblBooks.Location = New System.Drawing.Point(695, 198)
        Me.lblBooks.Name = "lblBooks"
        Me.lblBooks.Size = New System.Drawing.Size(366, 49)
        Me.lblBooks.TabIndex = 6
        Me.lblBooks.Text = "Book Inventory"
        Me.lblBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBooks.Visible = False
        '
        'lblPrint
        '
        Me.lblPrint.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPrint.Font = New System.Drawing.Font("Trajan Pro", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPrint.Location = New System.Drawing.Point(324, 454)
        Me.lblPrint.Name = "lblPrint"
        Me.lblPrint.Size = New System.Drawing.Size(385, 49)
        Me.lblPrint.TabIndex = 6
        Me.lblPrint.Text = "Print Lables"
        Me.lblPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPrint.Visible = False
        '
        'lblSettings
        '
        Me.lblSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSettings.Font = New System.Drawing.Font("Trajan Pro", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.ForeColor = System.Drawing.Color.Silver
        Me.lblSettings.Location = New System.Drawing.Point(727, 454)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(309, 49)
        Me.lblSettings.TabIndex = 6
        Me.lblSettings.Text = "Settings"
        Me.lblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSettings.Visible = False
        '
        'lblReports
        '
        Me.lblReports.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblReports.Font = New System.Drawing.Font("Trajan Pro", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblReports.Location = New System.Drawing.Point(21, 454)
        Me.lblReports.Name = "lblReports"
        Me.lblReports.Size = New System.Drawing.Size(306, 49)
        Me.lblReports.TabIndex = 6
        Me.lblReports.Text = "Reports"
        Me.lblReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblReports.Visible = False
        '
        'lblMembers
        '
        Me.lblMembers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMembers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMembers.Font = New System.Drawing.Font("Trajan Pro", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembers.ForeColor = System.Drawing.Color.SpringGreen
        Me.lblMembers.Location = New System.Drawing.Point(370, 198)
        Me.lblMembers.Name = "lblMembers"
        Me.lblMembers.Size = New System.Drawing.Size(306, 49)
        Me.lblMembers.TabIndex = 6
        Me.lblMembers.Text = "Memberships"
        Me.lblMembers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMembers.Visible = False
        '
        'lblIssue
        '
        Me.lblIssue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIssue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIssue.Font = New System.Drawing.Font("Trajan Pro", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssue.ForeColor = System.Drawing.Color.Yellow
        Me.lblIssue.Location = New System.Drawing.Point(13, 198)
        Me.lblIssue.Name = "lblIssue"
        Me.lblIssue.Size = New System.Drawing.Size(306, 49)
        Me.lblIssue.TabIndex = 6
        Me.lblIssue.Text = "Issue Books"
        Me.lblIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblIssue.Visible = False
        '
        'btnIssue
        '
        Me.btnIssue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIssue.BackColor = System.Drawing.Color.Transparent
        Me.btnIssue.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.issue
        Me.btnIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnIssue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIssue.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnIssue.FlatAppearance.BorderSize = 0
        Me.btnIssue.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnIssue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssue.Font = New System.Drawing.Font("Baskerville Old Face", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssue.ForeColor = System.Drawing.Color.Chartreuse
        Me.btnIssue.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnIssue.Location = New System.Drawing.Point(13, 16)
        Me.btnIssue.MaximumSize = New System.Drawing.Size(360, 300)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Padding = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.btnIssue.Size = New System.Drawing.Size(306, 188)
        Me.btnIssue.TabIndex = 0
        Me.btnIssue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnIssue.UseVisualStyleBackColor = False
        '
        'btnMembers
        '
        Me.btnMembers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMembers.AutoEllipsis = True
        Me.btnMembers.BackColor = System.Drawing.Color.Transparent
        Me.btnMembers.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.members
        Me.btnMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMembers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMembers.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnMembers.FlatAppearance.BorderSize = 0
        Me.btnMembers.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnMembers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnMembers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMembers.Font = New System.Drawing.Font("Baskerville Old Face", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMembers.ForeColor = System.Drawing.Color.Chartreuse
        Me.btnMembers.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMembers.Location = New System.Drawing.Point(370, 16)
        Me.btnMembers.MaximumSize = New System.Drawing.Size(360, 300)
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Padding = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.btnMembers.Size = New System.Drawing.Size(306, 188)
        Me.btnMembers.TabIndex = 1
        Me.btnMembers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMembers.UseVisualStyleBackColor = False
        '
        'btnBooks
        '
        Me.btnBooks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBooks.AutoEllipsis = True
        Me.btnBooks.BackColor = System.Drawing.Color.Transparent
        Me.btnBooks.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.Books
        Me.btnBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBooks.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBooks.FlatAppearance.BorderSize = 0
        Me.btnBooks.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooks.Font = New System.Drawing.Font("Baskerville Old Face", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooks.ForeColor = System.Drawing.Color.Chartreuse
        Me.btnBooks.Location = New System.Drawing.Point(727, 16)
        Me.btnBooks.MaximumSize = New System.Drawing.Size(360, 300)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Padding = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.btnBooks.Size = New System.Drawing.Size(306, 188)
        Me.btnBooks.TabIndex = 2
        Me.btnBooks.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBooks.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReports.AutoEllipsis = True
        Me.btnReports.BackColor = System.Drawing.Color.Transparent
        Me.btnReports.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.reportmenu
        Me.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Baskerville Old Face", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.Chartreuse
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReports.Location = New System.Drawing.Point(21, 279)
        Me.btnReports.MaximumSize = New System.Drawing.Size(360, 300)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Padding = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.btnReports.Size = New System.Drawing.Size(306, 188)
        Me.btnReports.TabIndex = 3
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.AutoEllipsis = True
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.Printer
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Baskerville Old Face", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Chartreuse
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(370, 279)
        Me.btnPrint.MaximumSize = New System.Drawing.Size(360, 300)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Padding = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.btnPrint.Size = New System.Drawing.Size(306, 188)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.AutoEllipsis = True
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.Gear_icon
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Baskerville Old Face", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.Chartreuse
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSettings.Location = New System.Drawing.Point(727, 279)
        Me.btnSettings.MaximumSize = New System.Drawing.Size(360, 300)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Padding = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.btnSettings.Size = New System.Drawing.Size(306, 188)
        Me.btnSettings.TabIndex = 5
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.AutoEllipsis = True
        Me.btnAbout.BackColor = System.Drawing.Color.Transparent
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.Blue
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAbout.Location = New System.Drawing.Point(1017, 0)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAbout.MaximumSize = New System.Drawing.Size(360, 300)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(57, 52)
        Me.btnAbout.TabIndex = 2
        Me.btnAbout.Text = "?"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.login_button_icon_png_15
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.Location = New System.Drawing.Point(986, 69)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(114, 33)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlMenu)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1100, 700)
        Me.Name = "frmMain"
        Me.Text = "LMS"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenuSub.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Title2 As System.Windows.Forms.Label
    Friend WithEvents Title1 As System.Windows.Forms.Label
    Friend WithEvents pnlMenu As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnIssue As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnBooks As System.Windows.Forms.Button
    Friend WithEvents btnMembers As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents lblMenuTitle As System.Windows.Forms.Label
    Friend WithEvents pnlMenuSub As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents lblPatronName As System.Windows.Forms.Label
    Friend WithEvents lblBooks As System.Windows.Forms.Label
    Friend WithEvents lblSettings As System.Windows.Forms.Label
    Friend WithEvents lblReports As System.Windows.Forms.Label
    Friend WithEvents lblMembers As System.Windows.Forms.Label
    Friend WithEvents lblIssue As System.Windows.Forms.Label
    Friend WithEvents lblPrint As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
