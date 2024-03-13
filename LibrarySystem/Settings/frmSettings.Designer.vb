<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.Title1 = New System.Windows.Forms.Label()
        Me.Title2 = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.printBCMEM1 = New LibrarySystem.printBCMEM()
        Me.BookascnBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDB = New LibrarySystem.LibraryDB()
        Me.BookascnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblPWerror = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPPass2 = New System.Windows.Forms.TextBox()
        Me.txtPPass = New System.Windows.Forms.TextBox()
        Me.txtPName = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRemovePatron = New System.Windows.Forms.Button()
        Me.btnAddPatron = New System.Windows.Forms.Button()
        Me.cmbPatronList = New System.Windows.Forms.ComboBox()
        Me.PatronBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New LibrarySystem.LibraryDBTableAdapters.studentTableAdapter()
        Me.Book_ascnTableAdapter = New LibrarySystem.LibraryDBTableAdapters.book_ascnTableAdapter()
        Me.PatronTableAdapter = New LibrarySystem.LibraryDBTableAdapters.patronTableAdapter()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        btnExit = New System.Windows.Forms.Button()
        btnBack = New System.Windows.Forms.Button()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookascnBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookascnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatronBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnExit.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.close
        btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnExit.Location = New System.Drawing.Point(965, 8)
        btnExit.Name = "btnExit"
        btnExit.Size = New System.Drawing.Size(38, 37)
        btnExit.TabIndex = 60
        btnExit.UseVisualStyleBackColor = True
        AddHandler btnExit.Click, AddressOf Me.btnExit_Click
        '
        'btnBack
        '
        btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnBack.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.BackButton
        btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnBack.Location = New System.Drawing.Point(921, 8)
        btnBack.Name = "btnBack"
        btnBack.Size = New System.Drawing.Size(38, 37)
        btnBack.TabIndex = 59
        btnBack.UseVisualStyleBackColor = True
        AddHandler btnBack.Click, AddressOf Me.btnBack_Click
        '
        'Title1
        '
        Me.Title1.AutoSize = True
        Me.Title1.BackColor = System.Drawing.Color.Transparent
        Me.Title1.Font = New System.Drawing.Font("Trajan Pro", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title1.ForeColor = System.Drawing.Color.Black
        Me.Title1.Location = New System.Drawing.Point(100, 8)
        Me.Title1.Name = "Title1"
        Me.Title1.Size = New System.Drawing.Size(797, 61)
        Me.Title1.TabIndex = 9
        Me.Title1.Text = "Library Management System"
        '
        'Title2
        '
        Me.Title2.AutoSize = True
        Me.Title2.BackColor = System.Drawing.Color.Transparent
        Me.Title2.Font = New System.Drawing.Font("Trajan Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title2.ForeColor = System.Drawing.Color.Black
        Me.Title2.Location = New System.Drawing.Point(106, 66)
        Me.Title2.Name = "Title2"
        Me.Title2.Size = New System.Drawing.Size(734, 27)
        Me.Title2.TabIndex = 8
        Me.Title2.Text = "Sri Lanka Institute Of Advanced Technological Education"
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.Image = Global.LibrarySystem.My.Resources.Resources.SliateLogo
        Me.pbxLogo.Location = New System.Drawing.Point(1, 8)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(93, 86)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 7
        Me.pbxLogo.TabStop = False
        '
        'BookascnBindingSource1
        '
        Me.BookascnBindingSource1.DataMember = "book_ascn"
        Me.BookascnBindingSource1.DataSource = Me.LibraryDB
        '
        'LibraryDB
        '
        Me.LibraryDB.DataSetName = "LibraryDB"
        Me.LibraryDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookascnBindingSource
        '
        Me.BookascnBindingSource.DataMember = "book_ascn"
        Me.BookascnBindingSource.DataSource = Me.LibraryDB
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 286)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(198, 24)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Delete a Patron/Admin"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(33, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 20)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Name :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(33, 164)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 20)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Retype Password :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(20, 319)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(184, 20)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Select name to remove  :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(33, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 20)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Patron Type :"
        '
        'lblPWerror
        '
        Me.lblPWerror.AutoSize = True
        Me.lblPWerror.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPWerror.ForeColor = System.Drawing.Color.Red
        Me.lblPWerror.Location = New System.Drawing.Point(201, 191)
        Me.lblPWerror.Name = "lblPWerror"
        Me.lblPWerror.Size = New System.Drawing.Size(284, 20)
        Me.lblPWerror.TabIndex = 8
        Me.lblPWerror.Text = "Passwords Don't match. Please retype."
        Me.lblPWerror.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Password :"
        '
        'txtPPass2
        '
        Me.txtPPass2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPPass2.Location = New System.Drawing.Point(205, 162)
        Me.txtPPass2.Name = "txtPPass2"
        Me.txtPPass2.Size = New System.Drawing.Size(186, 26)
        Me.txtPPass2.TabIndex = 6
        Me.txtPPass2.UseSystemPasswordChar = True
        '
        'txtPPass
        '
        Me.txtPPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPPass.Location = New System.Drawing.Point(205, 130)
        Me.txtPPass.Name = "txtPPass"
        Me.txtPPass.Size = New System.Drawing.Size(186, 26)
        Me.txtPPass.TabIndex = 5
        Me.txtPPass.UseSystemPasswordChar = True
        '
        'txtPName
        '
        Me.txtPName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPName.Location = New System.Drawing.Point(205, 64)
        Me.txtPName.Name = "txtPName"
        Me.txtPName.Size = New System.Drawing.Size(186, 26)
        Me.txtPName.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(409, 223)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 29)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnRemovePatron
        '
        Me.btnRemovePatron.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemovePatron.Location = New System.Drawing.Point(409, 315)
        Me.btnRemovePatron.Name = "btnRemovePatron"
        Me.btnRemovePatron.Size = New System.Drawing.Size(75, 29)
        Me.btnRemovePatron.TabIndex = 3
        Me.btnRemovePatron.Text = "Confirm"
        Me.btnRemovePatron.UseVisualStyleBackColor = True
        '
        'btnAddPatron
        '
        Me.btnAddPatron.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPatron.Location = New System.Drawing.Point(328, 223)
        Me.btnAddPatron.Name = "btnAddPatron"
        Me.btnAddPatron.Size = New System.Drawing.Size(75, 29)
        Me.btnAddPatron.TabIndex = 3
        Me.btnAddPatron.Text = "Confirm"
        Me.btnAddPatron.UseVisualStyleBackColor = True
        '
        'cmbPatronList
        '
        Me.cmbPatronList.DataSource = Me.PatronBindingSource
        Me.cmbPatronList.DisplayMember = "User_Name"
        Me.cmbPatronList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPatronList.FormattingEnabled = True
        Me.cmbPatronList.Location = New System.Drawing.Point(206, 316)
        Me.cmbPatronList.Name = "cmbPatronList"
        Me.cmbPatronList.Size = New System.Drawing.Size(197, 28)
        Me.cmbPatronList.TabIndex = 2
        Me.cmbPatronList.ValueMember = "User_Name"
        '
        'PatronBindingSource
        '
        Me.PatronBindingSource.DataMember = "patron"
        Me.PatronBindingSource.DataSource = Me.LibraryDB
        '
        'cmbType
        '
        Me.cmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"admin", "user"})
        Me.cmbType.Location = New System.Drawing.Point(205, 96)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(87, 28)
        Me.cmbType.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(552, 290)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 184)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Setup Fine Rate"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(233, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(177, 26)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(233, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(177, 26)
        Me.TextBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(58, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Reference Section : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(58, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Lending Section :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(233, 148)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(177, 29)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnBackup)
        Me.GroupBox1.Controls.Add(Me.btnRestore)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(552, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 156)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Backup And Restore"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(58, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Backup the database :"
        '
        'btnBackup
        '
        Me.btnBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.Location = New System.Drawing.Point(233, 52)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(177, 29)
        Me.btnBackup.TabIndex = 2
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnRestore
        '
        Me.btnRestore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.Location = New System.Drawing.Point(233, 99)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(177, 29)
        Me.btnRestore.TabIndex = 6
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(58, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(172, 20)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Restore the database :"
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "student"
        Me.StudentBindingSource.DataSource = Me.LibraryDB
        '
        'StudentBindingSource1
        '
        Me.StudentBindingSource1.DataMember = "student"
        Me.StudentBindingSource1.DataSource = Me.LibraryDB
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'Book_ascnTableAdapter
        '
        Me.Book_ascnTableAdapter.ClearBeforeFill = True
        '
        'PatronTableAdapter
        '
        Me.PatronTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtPName)
        Me.GroupBox3.Controls.Add(Me.txtPPass)
        Me.GroupBox3.Controls.Add(Me.txtPPass2)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.lblPWerror)
        Me.GroupBox3.Controls.Add(Me.cmbType)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.btnCancel)
        Me.GroupBox3.Controls.Add(Me.btnAddPatron)
        Me.GroupBox3.Controls.Add(Me.cmbPatronList)
        Me.GroupBox3.Controls.Add(Me.btnRemovePatron)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(23, 113)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(506, 361)
        Me.GroupBox3.TabIndex = 61
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Manage Patron/Admin Accounts"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Create a Patron/Admin"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 518)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(btnBack)
        Me.Controls.Add(Me.Title1)
        Me.Controls.Add(Me.Title2)
        Me.Controls.Add(Me.pbxLogo)
        Me.Name = "frmSettings"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.TransparencyKey = System.Drawing.Color.DarkViolet
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookascnBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookascnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatronBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title1 As System.Windows.Forms.Label
    Friend WithEvents Title2 As System.Windows.Forms.Label
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents printBCMEM1 As LibrarySystem.printBCMEM
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnAddPatron As System.Windows.Forms.Button
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents LibraryDB As LibrarySystem.LibraryDB
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As LibrarySystem.LibraryDBTableAdapters.studentTableAdapter
    Friend WithEvents StudentBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BookascnBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Book_ascnTableAdapter As LibrarySystem.LibraryDBTableAdapters.book_ascnTableAdapter
    Friend WithEvents BookascnBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblPWerror As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPPass2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPPass As System.Windows.Forms.TextBox
    Friend WithEvents txtPName As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnRemovePatron As System.Windows.Forms.Button
    Friend WithEvents cmbPatronList As System.Windows.Forms.ComboBox
    Friend WithEvents PatronBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PatronTableAdapter As LibrarySystem.LibraryDBTableAdapters.patronTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
