<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIssueBooks
    ' Inherits System.Windows.Forms.Form
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
        Dim btnExit As System.Windows.Forms.Button
        Dim btnBack As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIssueBooks))
        Me.Time = New System.Windows.Forms.Timer(Me.components)
        Me.Title1 = New System.Windows.Forms.Label()
        Me.Title2 = New System.Windows.Forms.Label()
        Me.countdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.pnlMonitor = New System.Windows.Forms.Panel()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.pgrBar = New MetroFramework.Controls.MetroProgressBar()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lblb4 = New System.Windows.Forms.Label()
        Me.lblb1 = New System.Windows.Forms.Label()
        Me.lblb6 = New System.Windows.Forms.Label()
        Me.lblb2 = New System.Windows.Forms.Label()
        Me.lblb3 = New System.Windows.Forms.Label()
        Me.lblb5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbx = New System.Windows.Forms.PictureBox()
        Me.lblIssueNo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblGainFocus = New System.Windows.Forms.Label()
        Me.txtBarCodeInput = New System.Windows.Forms.TextBox()
        Me.pnlDetails2 = New System.Windows.Forms.Panel()
        Me.lbl00 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.lbl14 = New System.Windows.Forms.Label()
        Me.lbl15 = New System.Windows.Forms.Label()
        Me.lbl01 = New System.Windows.Forms.Label()
        Me.lbl02 = New System.Windows.Forms.Label()
        Me.lbl03 = New System.Windows.Forms.Label()
        Me.lbl04 = New System.Windows.Forms.Label()
        Me.lbl05 = New System.Windows.Forms.Label()
        Me.pgrIssueNotice = New MetroFramework.Controls.MetroProgressBar()
        Me.pbx2 = New System.Windows.Forms.PictureBox()
        Me.pnlIssuedReturned = New System.Windows.Forms.Panel()
        Me.Title10 = New System.Windows.Forms.Label()
        Me.Title20 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.countdownTimer2 = New System.Windows.Forms.Timer(Me.components)
        btnExit = New System.Windows.Forms.Button()
        btnBack = New System.Windows.Forms.Button()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMonitor.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDetails2.SuspendLayout()
        CType(Me.pbx2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlIssuedReturned.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnExit.Location = New System.Drawing.Point(961, 3)
        btnExit.Name = "btnExit"
        btnExit.Size = New System.Drawing.Size(38, 37)
        btnExit.TabIndex = 58
        btnExit.UseVisualStyleBackColor = False
        AddHandler btnExit.Click, AddressOf Me.btnExit_Click
        '
        'btnBack
        '
        btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnBack.BackColor = System.Drawing.Color.Transparent
        btnBack.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.BackButton
        btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnBack.Location = New System.Drawing.Point(918, 3)
        btnBack.Name = "btnBack"
        btnBack.Size = New System.Drawing.Size(37, 37)
        btnBack.TabIndex = 57
        btnBack.UseVisualStyleBackColor = False
        AddHandler btnBack.Click, AddressOf Me.btnBack_Click
        '
        'Time
        '
        Me.Time.Interval = 1000
        '
        'Title1
        '
        Me.Title1.AutoSize = True
        Me.Title1.BackColor = System.Drawing.Color.Transparent
        Me.Title1.Font = New System.Drawing.Font("Trajan Pro", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title1.ForeColor = System.Drawing.Color.Black
        Me.Title1.Location = New System.Drawing.Point(99, 0)
        Me.Title1.Name = "Title1"
        Me.Title1.Size = New System.Drawing.Size(797, 61)
        Me.Title1.TabIndex = 25
        Me.Title1.Text = "Library Management System"
        '
        'Title2
        '
        Me.Title2.AutoSize = True
        Me.Title2.BackColor = System.Drawing.Color.Transparent
        Me.Title2.Font = New System.Drawing.Font("Trajan Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title2.ForeColor = System.Drawing.Color.Black
        Me.Title2.Location = New System.Drawing.Point(105, 58)
        Me.Title2.Name = "Title2"
        Me.Title2.Size = New System.Drawing.Size(734, 27)
        Me.Title2.TabIndex = 24
        Me.Title2.Text = "Sri Lanka Institute Of Advanced Technological Education"
        '
        'countdownTimer
        '
        Me.countdownTimer.Interval = 20
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.Image = Global.LibrarySystem.My.Resources.Resources.SliateLogo
        Me.pbxLogo.Location = New System.Drawing.Point(0, 0)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(93, 86)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 23
        Me.pbxLogo.TabStop = False
        '
        'pnlMonitor
        '
        Me.pnlMonitor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMonitor.BackColor = System.Drawing.Color.White
        Me.pnlMonitor.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.bg98
        Me.pnlMonitor.Controls.Add(btnExit)
        Me.pnlMonitor.Controls.Add(btnBack)
        Me.pnlMonitor.Controls.Add(Me.pnlDetails)
        Me.pnlMonitor.Controls.Add(Me.Title1)
        Me.pnlMonitor.Controls.Add(Me.Title2)
        Me.pnlMonitor.Controls.Add(Me.pbx)
        Me.pnlMonitor.Controls.Add(Me.pbxLogo)
        Me.pnlMonitor.Controls.Add(Me.lblIssueNo)
        Me.pnlMonitor.Controls.Add(Me.Label2)
        Me.pnlMonitor.Controls.Add(Me.Label1)
        Me.pnlMonitor.Controls.Add(Me.lblDateTime)
        Me.pnlMonitor.ForeColor = System.Drawing.Color.White
        Me.pnlMonitor.Location = New System.Drawing.Point(0, 0)
        Me.pnlMonitor.Name = "pnlMonitor"
        Me.pnlMonitor.Size = New System.Drawing.Size(1005, 763)
        Me.pnlMonitor.TabIndex = 15
        '
        'pnlDetails
        '
        Me.pnlDetails.BackColor = System.Drawing.Color.Transparent
        Me.pnlDetails.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.frame
        Me.pnlDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlDetails.Controls.Add(Me.lbl4)
        Me.pnlDetails.Controls.Add(Me.pgrBar)
        Me.pnlDetails.Controls.Add(Me.lbl1)
        Me.pnlDetails.Controls.Add(Me.lbl6)
        Me.pnlDetails.Controls.Add(Me.lbl2)
        Me.pnlDetails.Controls.Add(Me.lbl3)
        Me.pnlDetails.Controls.Add(Me.lbl5)
        Me.pnlDetails.Controls.Add(Me.lblb4)
        Me.pnlDetails.Controls.Add(Me.lblb1)
        Me.pnlDetails.Controls.Add(Me.lblb6)
        Me.pnlDetails.Controls.Add(Me.lblb2)
        Me.pnlDetails.Controls.Add(Me.lblb3)
        Me.pnlDetails.Controls.Add(Me.lblb5)
        Me.pnlDetails.Controls.Add(Me.Label3)
        Me.pnlDetails.Location = New System.Drawing.Point(9, 262)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(807, 423)
        Me.pnlDetails.TabIndex = 33
        '
        'lbl4
        '
        Me.lbl4.BackColor = System.Drawing.Color.Black
        Me.lbl4.Font = New System.Drawing.Font("Trajan Pro", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl4.Location = New System.Drawing.Point(286, 207)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(440, 43)
        Me.lbl4.TabIndex = 27
        Me.lbl4.Text = " "
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pgrBar
        '
        Me.pgrBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgrBar.Location = New System.Drawing.Point(72, 363)
        Me.pgrBar.Name = "pgrBar"
        Me.pgrBar.Size = New System.Drawing.Size(662, 19)
        Me.pgrBar.Step = 20
        Me.pgrBar.Style = MetroFramework.MetroColorStyle.Orange
        Me.pgrBar.TabIndex = 9
        Me.pgrBar.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Black
        Me.lbl1.Font = New System.Drawing.Font("Trajan Pro", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl1.Location = New System.Drawing.Point(286, 51)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(440, 43)
        Me.lbl1.TabIndex = 29
        Me.lbl1.Text = " "
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl6
        '
        Me.lbl6.BackColor = System.Drawing.Color.Black
        Me.lbl6.Font = New System.Drawing.Font("Trajan Pro", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl6.Location = New System.Drawing.Point(286, 311)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(440, 43)
        Me.lbl6.TabIndex = 28
        Me.lbl6.Text = " "
        Me.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.Color.Black
        Me.lbl2.Font = New System.Drawing.Font("Trajan Pro", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl2.Location = New System.Drawing.Point(286, 103)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(440, 43)
        Me.lbl2.TabIndex = 32
        Me.lbl2.Text = " "
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.Color.Black
        Me.lbl3.Font = New System.Drawing.Font("Trajan Pro", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl3.Location = New System.Drawing.Point(286, 155)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(440, 43)
        Me.lbl3.TabIndex = 31
        Me.lbl3.Text = " "
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl5
        '
        Me.lbl5.BackColor = System.Drawing.Color.Black
        Me.lbl5.Font = New System.Drawing.Font("Trajan Pro", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl5.Location = New System.Drawing.Point(286, 259)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(440, 43)
        Me.lbl5.TabIndex = 30
        Me.lbl5.Text = " "
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblb4
        '
        Me.lblb4.BackColor = System.Drawing.Color.Black
        Me.lblb4.Font = New System.Drawing.Font("Trajan Pro", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblb4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblb4.Location = New System.Drawing.Point(73, 207)
        Me.lblb4.Name = "lblb4"
        Me.lblb4.Size = New System.Drawing.Size(207, 43)
        Me.lblb4.TabIndex = 27
        Me.lblb4.Text = " "
        Me.lblb4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblb1
        '
        Me.lblb1.BackColor = System.Drawing.Color.Black
        Me.lblb1.Font = New System.Drawing.Font("Trajan Pro", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblb1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblb1.Location = New System.Drawing.Point(73, 51)
        Me.lblb1.Name = "lblb1"
        Me.lblb1.Size = New System.Drawing.Size(207, 43)
        Me.lblb1.TabIndex = 29
        Me.lblb1.Text = " "
        Me.lblb1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblb6
        '
        Me.lblb6.BackColor = System.Drawing.Color.Black
        Me.lblb6.Font = New System.Drawing.Font("Trajan Pro", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblb6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblb6.Location = New System.Drawing.Point(73, 311)
        Me.lblb6.Name = "lblb6"
        Me.lblb6.Size = New System.Drawing.Size(207, 43)
        Me.lblb6.TabIndex = 28
        Me.lblb6.Text = " "
        Me.lblb6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblb2
        '
        Me.lblb2.BackColor = System.Drawing.Color.Black
        Me.lblb2.Font = New System.Drawing.Font("Trajan Pro", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblb2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblb2.Location = New System.Drawing.Point(73, 103)
        Me.lblb2.Name = "lblb2"
        Me.lblb2.Size = New System.Drawing.Size(207, 43)
        Me.lblb2.TabIndex = 32
        Me.lblb2.Text = " "
        Me.lblb2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblb3
        '
        Me.lblb3.BackColor = System.Drawing.Color.Black
        Me.lblb3.Font = New System.Drawing.Font("Trajan Pro", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblb3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblb3.Location = New System.Drawing.Point(73, 155)
        Me.lblb3.Name = "lblb3"
        Me.lblb3.Size = New System.Drawing.Size(207, 43)
        Me.lblb3.TabIndex = 31
        Me.lblb3.Text = " "
        Me.lblb3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblb5
        '
        Me.lblb5.BackColor = System.Drawing.Color.Black
        Me.lblb5.Font = New System.Drawing.Font("Trajan Pro", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblb5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblb5.Location = New System.Drawing.Point(73, 259)
        Me.lblb5.Name = "lblb5"
        Me.lblb5.Size = New System.Drawing.Size(207, 43)
        Me.lblb5.TabIndex = 30
        Me.lblb5.Text = " "
        Me.lblb5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Trajan Pro", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(70, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(665, 345)
        Me.Label3.TabIndex = 33
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbx
        '
        Me.pbx.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbx.BackColor = System.Drawing.Color.Transparent
        Me.pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbx.Location = New System.Drawing.Point(822, 262)
        Me.pbx.MaximumSize = New System.Drawing.Size(500, 500)
        Me.pbx.Name = "pbx"
        Me.pbx.Size = New System.Drawing.Size(174, 423)
        Me.pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx.TabIndex = 8
        Me.pbx.TabStop = False
        '
        'lblIssueNo
        '
        Me.lblIssueNo.BackColor = System.Drawing.Color.Transparent
        Me.lblIssueNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIssueNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblIssueNo.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssueNo.ForeColor = System.Drawing.Color.Red
        Me.lblIssueNo.Location = New System.Drawing.Point(438, 176)
        Me.lblIssueNo.Name = "lblIssueNo"
        Me.lblIssueNo.Size = New System.Drawing.Size(480, 43)
        Me.lblIssueNo.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(162, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 42)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Time                :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(162, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 42)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Issue Number :"
        '
        'lblDateTime
        '
        Me.lblDateTime.BackColor = System.Drawing.Color.Transparent
        Me.lblDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblDateTime.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.Navy
        Me.lblDateTime.Location = New System.Drawing.Point(438, 122)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(480, 43)
        Me.lblDateTime.TabIndex = 26
        '
        'lblGainFocus
        '
        Me.lblGainFocus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGainFocus.BackColor = System.Drawing.Color.Black
        Me.lblGainFocus.Font = New System.Drawing.Font("Trajan Pro", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGainFocus.ForeColor = System.Drawing.Color.Red
        Me.lblGainFocus.Location = New System.Drawing.Point(212, 241)
        Me.lblGainFocus.Name = "lblGainFocus"
        Me.lblGainFocus.Size = New System.Drawing.Size(665, 345)
        Me.lblGainFocus.TabIndex = 32
        Me.lblGainFocus.Text = "Punch your library card to borrow a book."
        Me.lblGainFocus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBarCodeInput
        '
        Me.txtBarCodeInput.BackColor = System.Drawing.Color.White
        Me.txtBarCodeInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBarCodeInput.Font = New System.Drawing.Font("Adobe Caslon Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarCodeInput.ForeColor = System.Drawing.Color.White
        Me.txtBarCodeInput.Location = New System.Drawing.Point(3, 749)
        Me.txtBarCodeInput.Name = "txtBarCodeInput"
        Me.txtBarCodeInput.Size = New System.Drawing.Size(10, 26)
        Me.txtBarCodeInput.TabIndex = 0
        '
        'pnlDetails2
        '
        Me.pnlDetails2.BackColor = System.Drawing.Color.Transparent
        Me.pnlDetails2.Controls.Add(Me.lbl00)
        Me.pnlDetails2.Controls.Add(Me.lbl11)
        Me.pnlDetails2.Controls.Add(Me.lbl12)
        Me.pnlDetails2.Controls.Add(Me.lbl13)
        Me.pnlDetails2.Controls.Add(Me.lbl14)
        Me.pnlDetails2.Controls.Add(Me.lbl15)
        Me.pnlDetails2.Controls.Add(Me.lbl01)
        Me.pnlDetails2.Controls.Add(Me.lbl02)
        Me.pnlDetails2.Controls.Add(Me.lbl03)
        Me.pnlDetails2.Controls.Add(Me.lbl04)
        Me.pnlDetails2.Controls.Add(Me.lbl05)
        Me.pnlDetails2.Controls.Add(Me.pgrIssueNotice)
        Me.pnlDetails2.Controls.Add(Me.pbx2)
        Me.pnlDetails2.Location = New System.Drawing.Point(33, 177)
        Me.pnlDetails2.Name = "pnlDetails2"
        Me.pnlDetails2.Size = New System.Drawing.Size(899, 455)
        Me.pnlDetails2.TabIndex = 59
        '
        'lbl00
        '
        Me.lbl00.BackColor = System.Drawing.Color.Transparent
        Me.lbl00.Font = New System.Drawing.Font("Trajan Pro", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl00.ForeColor = System.Drawing.Color.Red
        Me.lbl00.Location = New System.Drawing.Point(77, 42)
        Me.lbl00.Name = "lbl00"
        Me.lbl00.Size = New System.Drawing.Size(743, 61)
        Me.lbl00.TabIndex = 1
        Me.lbl00.Text = "Book Issued"
        Me.lbl00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.BackColor = System.Drawing.Color.Transparent
        Me.lbl11.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl11.ForeColor = System.Drawing.Color.Navy
        Me.lbl11.Location = New System.Drawing.Point(374, 112)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(396, 41)
        Me.lbl11.TabIndex = 1
        Me.lbl11.Text = "---------------------------"
        '
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.BackColor = System.Drawing.Color.Transparent
        Me.lbl12.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12.ForeColor = System.Drawing.Color.Navy
        Me.lbl12.Location = New System.Drawing.Point(374, 167)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(396, 41)
        Me.lbl12.TabIndex = 1
        Me.lbl12.Text = "---------------------------"
        '
        'lbl13
        '
        Me.lbl13.AutoSize = True
        Me.lbl13.BackColor = System.Drawing.Color.Transparent
        Me.lbl13.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl13.ForeColor = System.Drawing.Color.Navy
        Me.lbl13.Location = New System.Drawing.Point(374, 222)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(396, 41)
        Me.lbl13.TabIndex = 1
        Me.lbl13.Text = "---------------------------"
        '
        'lbl14
        '
        Me.lbl14.AutoSize = True
        Me.lbl14.BackColor = System.Drawing.Color.Transparent
        Me.lbl14.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl14.ForeColor = System.Drawing.Color.Navy
        Me.lbl14.Location = New System.Drawing.Point(374, 277)
        Me.lbl14.Name = "lbl14"
        Me.lbl14.Size = New System.Drawing.Size(396, 41)
        Me.lbl14.TabIndex = 1
        Me.lbl14.Text = "---------------------------"
        '
        'lbl15
        '
        Me.lbl15.AutoSize = True
        Me.lbl15.BackColor = System.Drawing.Color.Transparent
        Me.lbl15.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl15.ForeColor = System.Drawing.Color.Navy
        Me.lbl15.Location = New System.Drawing.Point(374, 332)
        Me.lbl15.Name = "lbl15"
        Me.lbl15.Size = New System.Drawing.Size(396, 41)
        Me.lbl15.TabIndex = 1
        Me.lbl15.Text = "---------------------------"
        '
        'lbl01
        '
        Me.lbl01.BackColor = System.Drawing.Color.Transparent
        Me.lbl01.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl01.ForeColor = System.Drawing.Color.Navy
        Me.lbl01.Location = New System.Drawing.Point(91, 112)
        Me.lbl01.Name = "lbl01"
        Me.lbl01.Size = New System.Drawing.Size(277, 41)
        Me.lbl01.TabIndex = 1
        Me.lbl01.Text = "Issue Number :"
        Me.lbl01.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl02
        '
        Me.lbl02.BackColor = System.Drawing.Color.Transparent
        Me.lbl02.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl02.ForeColor = System.Drawing.Color.Navy
        Me.lbl02.Location = New System.Drawing.Point(91, 167)
        Me.lbl02.Name = "lbl02"
        Me.lbl02.Size = New System.Drawing.Size(277, 41)
        Me.lbl02.TabIndex = 1
        Me.lbl02.Text = "Student Name :"
        Me.lbl02.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl03
        '
        Me.lbl03.BackColor = System.Drawing.Color.Transparent
        Me.lbl03.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl03.ForeColor = System.Drawing.Color.Navy
        Me.lbl03.Location = New System.Drawing.Point(91, 222)
        Me.lbl03.Name = "lbl03"
        Me.lbl03.Size = New System.Drawing.Size(277, 41)
        Me.lbl03.TabIndex = 1
        Me.lbl03.Text = "Book Title :"
        Me.lbl03.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl04
        '
        Me.lbl04.BackColor = System.Drawing.Color.Transparent
        Me.lbl04.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl04.ForeColor = System.Drawing.Color.Navy
        Me.lbl04.Location = New System.Drawing.Point(91, 277)
        Me.lbl04.Name = "lbl04"
        Me.lbl04.Size = New System.Drawing.Size(277, 41)
        Me.lbl04.TabIndex = 1
        Me.lbl04.Text = "Due Date :"
        Me.lbl04.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl05
        '
        Me.lbl05.BackColor = System.Drawing.Color.Transparent
        Me.lbl05.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl05.ForeColor = System.Drawing.Color.Navy
        Me.lbl05.Location = New System.Drawing.Point(91, 332)
        Me.lbl05.Name = "lbl05"
        Me.lbl05.Size = New System.Drawing.Size(277, 41)
        Me.lbl05.TabIndex = 1
        Me.lbl05.Text = "Patron :"
        Me.lbl05.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pgrIssueNotice
        '
        Me.pgrIssueNotice.Location = New System.Drawing.Point(78, 394)
        Me.pgrIssueNotice.Name = "pgrIssueNotice"
        Me.pgrIssueNotice.Size = New System.Drawing.Size(742, 21)
        Me.pgrIssueNotice.Step = 1
        Me.pgrIssueNotice.Style = MetroFramework.MetroColorStyle.Orange
        Me.pgrIssueNotice.TabIndex = 1
        Me.pgrIssueNotice.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'pbx2
        '
        Me.pbx2.BackColor = System.Drawing.Color.Transparent
        Me.pbx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx2.Image = Global.LibrarySystem.My.Resources.Resources.frame
        Me.pbx2.Location = New System.Drawing.Point(0, 0)
        Me.pbx2.Name = "pbx2"
        Me.pbx2.Size = New System.Drawing.Size(899, 455)
        Me.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx2.TabIndex = 2
        Me.pbx2.TabStop = False
        '
        'pnlIssuedReturned
        '
        Me.pnlIssuedReturned.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlIssuedReturned.BackColor = System.Drawing.Color.White
        Me.pnlIssuedReturned.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.bg99
        Me.pnlIssuedReturned.Controls.Add(Me.Title10)
        Me.pnlIssuedReturned.Controls.Add(Me.Title20)
        Me.pnlIssuedReturned.Controls.Add(Me.PictureBox2)
        Me.pnlIssuedReturned.Controls.Add(Me.txtBarCodeInput)
        Me.pnlIssuedReturned.Controls.Add(Me.pnlDetails2)
        Me.pnlIssuedReturned.Location = New System.Drawing.Point(0, 0)
        Me.pnlIssuedReturned.Name = "pnlIssuedReturned"
        Me.pnlIssuedReturned.Size = New System.Drawing.Size(999, 775)
        Me.pnlIssuedReturned.TabIndex = 59
        '
        'Title10
        '
        Me.Title10.AutoSize = True
        Me.Title10.BackColor = System.Drawing.Color.Transparent
        Me.Title10.Font = New System.Drawing.Font("Trajan Pro", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title10.ForeColor = System.Drawing.Color.Black
        Me.Title10.Location = New System.Drawing.Point(99, 0)
        Me.Title10.Name = "Title10"
        Me.Title10.Size = New System.Drawing.Size(797, 61)
        Me.Title10.TabIndex = 64
        Me.Title10.Text = "Library Management System"
        '
        'Title20
        '
        Me.Title20.AutoSize = True
        Me.Title20.BackColor = System.Drawing.Color.Transparent
        Me.Title20.Font = New System.Drawing.Font("Trajan Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title20.ForeColor = System.Drawing.Color.Black
        Me.Title20.Location = New System.Drawing.Point(105, 58)
        Me.Title20.Name = "Title20"
        Me.Title20.Size = New System.Drawing.Size(734, 27)
        Me.Title20.TabIndex = 62
        Me.Title20.Text = "Sri Lanka Institute Of Advanced Technological Education"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.LibrarySystem.My.Resources.Resources.SliateLogo
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 86)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 60
        Me.PictureBox2.TabStop = False
        '
        'countdownTimer2
        '
        Me.countdownTimer2.Interval = 80
        '
        'frmIssueBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlMonitor)
        Me.Controls.Add(Me.pnlIssuedReturned)
        Me.Controls.Add(Me.lblGainFocus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "frmIssueBooks"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMonitor.ResumeLayout(False)
        Me.pnlMonitor.PerformLayout()
        Me.pnlDetails.ResumeLayout(False)
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDetails2.ResumeLayout(False)
        Me.pnlDetails2.PerformLayout()
        CType(Me.pbx2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlIssuedReturned.ResumeLayout(False)
        Me.pnlIssuedReturned.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMonitor As System.Windows.Forms.Panel
    Friend WithEvents pbx As System.Windows.Forms.PictureBox
    Friend WithEvents txtBarCodeInput As System.Windows.Forms.TextBox
    Friend WithEvents Time As System.Windows.Forms.Timer
    Friend WithEvents Title1 As System.Windows.Forms.Label
    Friend WithEvents Title2 As System.Windows.Forms.Label
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents countdownTimer As System.Windows.Forms.Timer
    Friend WithEvents pgrBar As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents lblIssueNo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents pnlDetails As System.Windows.Forms.Panel
    Friend WithEvents lblb4 As System.Windows.Forms.Label
    Friend WithEvents lblb1 As System.Windows.Forms.Label
    Friend WithEvents lblb6 As System.Windows.Forms.Label
    Friend WithEvents lblb2 As System.Windows.Forms.Label
    Friend WithEvents lblb3 As System.Windows.Forms.Label
    Friend WithEvents lblb5 As System.Windows.Forms.Label
    Friend WithEvents lblGainFocus As System.Windows.Forms.Label
    Friend WithEvents pnlDetails2 As System.Windows.Forms.Panel
    Friend WithEvents pgrIssueNotice As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents lbl01 As System.Windows.Forms.Label
    Friend WithEvents lbl04 As System.Windows.Forms.Label
    Friend WithEvents lbl00 As System.Windows.Forms.Label
    Friend WithEvents lbl02 As System.Windows.Forms.Label
    Friend WithEvents lbl03 As System.Windows.Forms.Label
    Friend WithEvents pbx2 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlIssuedReturned As System.Windows.Forms.Panel
    Friend WithEvents Title10 As System.Windows.Forms.Label
    Friend WithEvents Title20 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents countdownTimer2 As System.Windows.Forms.Timer
    Friend WithEvents lbl11 As System.Windows.Forms.Label
    Friend WithEvents lbl12 As System.Windows.Forms.Label
    Friend WithEvents lbl13 As System.Windows.Forms.Label
    Friend WithEvents lbl14 As System.Windows.Forms.Label
    Friend WithEvents lbl15 As System.Windows.Forms.Label
    Friend WithEvents lbl05 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
