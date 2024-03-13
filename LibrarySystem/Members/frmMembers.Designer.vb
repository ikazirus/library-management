<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembers
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
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim NICLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim YearLabel As System.Windows.Forms.Label
        Dim Full_TimeLabel As System.Windows.Forms.Label
        Dim AdmissionNoLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim ActiveLabel As System.Windows.Forms.Label
        Dim btnBack As System.Windows.Forms.Button
        Dim btnExit As System.Windows.Forms.Button
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMembers))
        Me.txtMemSearch = New System.Windows.Forms.TextBox()
        Me.btnNewBatch = New System.Windows.Forms.Button()
        Me.Title1 = New System.Windows.Forms.Label()
        Me.Title2 = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.txtStudID = New System.Windows.Forms.TextBox()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDB = New LibrarySystem.LibraryDB()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtNIC = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtAdmission = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.btnUpdateMem = New System.Windows.Forms.Button()
        Me.pnlDetails = New MetroFramework.Controls.MetroPanel()
        Me.pbxActive = New System.Windows.Forms.PictureBox()
        Me.pnlDetails2 = New System.Windows.Forms.Panel()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.cmbDep = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtFine = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.cmbDataField = New System.Windows.Forms.ComboBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.gridMembership = New MetroFramework.Controls.MetroGrid()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NICDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdmissionNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridIssuedBooks = New MetroFramework.Controls.MetroGrid()
        Me.IssueIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IssuebookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DepartmentTableAdapter = New LibrarySystem.LibraryDBTableAdapters.departmentTableAdapter()
        Me.StudentTableAdapter = New LibrarySystem.LibraryDBTableAdapters.studentTableAdapter()
        Me.Issue_bookTableAdapter = New LibrarySystem.LibraryDBTableAdapters.issue_bookTableAdapter()
        StudentIDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        NICLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        YearLabel = New System.Windows.Forms.Label()
        Full_TimeLabel = New System.Windows.Forms.Label()
        AdmissionNoLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        ActiveLabel = New System.Windows.Forms.Label()
        btnBack = New System.Windows.Forms.Button()
        btnExit = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDetails.SuspendLayout()
        CType(Me.pbxActive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDetails2.SuspendLayout()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridMembership, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridIssuedBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssuebookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.BackColor = System.Drawing.Color.Transparent
        StudentIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StudentIDLabel.Location = New System.Drawing.Point(3, 11)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(91, 18)
        StudentIDLabel.TabIndex = 21
        StudentIDLabel.Text = "Student ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.BackColor = System.Drawing.Color.Transparent
        First_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(3, 39)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(96, 18)
        First_NameLabel.TabIndex = 23
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.BackColor = System.Drawing.Color.Transparent
        Last_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(3, 67)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(94, 18)
        Last_NameLabel.TabIndex = 25
        Last_NameLabel.Text = "Last Name:"
        '
        'NICLabel
        '
        NICLabel.AutoSize = True
        NICLabel.BackColor = System.Drawing.Color.Transparent
        NICLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NICLabel.Location = New System.Drawing.Point(3, 179)
        NICLabel.Name = "NICLabel"
        NICLabel.Size = New System.Drawing.Size(41, 18)
        NICLabel.TabIndex = 27
        NICLabel.Text = "NIC:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.Transparent
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(3, 207)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(74, 18)
        AddressLabel.TabIndex = 29
        AddressLabel.Text = "Address:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.BackColor = System.Drawing.Color.Transparent
        DepartmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartmentLabel.Location = New System.Drawing.Point(3, 235)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(100, 18)
        DepartmentLabel.TabIndex = 31
        DepartmentLabel.Text = "Department:"
        '
        'YearLabel
        '
        YearLabel.AutoSize = True
        YearLabel.BackColor = System.Drawing.Color.Transparent
        YearLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        YearLabel.Location = New System.Drawing.Point(3, 95)
        YearLabel.Name = "YearLabel"
        YearLabel.Size = New System.Drawing.Size(47, 18)
        YearLabel.TabIndex = 33
        YearLabel.Text = "Year:"
        '
        'Full_TimeLabel
        '
        Full_TimeLabel.AutoSize = True
        Full_TimeLabel.BackColor = System.Drawing.Color.Transparent
        Full_TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Full_TimeLabel.Location = New System.Drawing.Point(3, 122)
        Full_TimeLabel.Name = "Full_TimeLabel"
        Full_TimeLabel.Size = New System.Drawing.Size(109, 18)
        Full_TimeLabel.TabIndex = 35
        Full_TimeLabel.Text = "Course Type:"
        '
        'AdmissionNoLabel
        '
        AdmissionNoLabel.AutoSize = True
        AdmissionNoLabel.BackColor = System.Drawing.Color.Transparent
        AdmissionNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AdmissionNoLabel.Location = New System.Drawing.Point(3, 151)
        AdmissionNoLabel.Name = "AdmissionNoLabel"
        AdmissionNoLabel.Size = New System.Drawing.Size(118, 18)
        AdmissionNoLabel.TabIndex = 37
        AdmissionNoLabel.Text = "Admission No:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = System.Drawing.Color.Transparent
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(3, 265)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(68, 18)
        GenderLabel.TabIndex = 39
        GenderLabel.Text = "Gender:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.BackColor = System.Drawing.Color.Transparent
        TelephoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelephoneLabel.Location = New System.Drawing.Point(3, 293)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(91, 18)
        TelephoneLabel.TabIndex = 41
        TelephoneLabel.Text = "Telephone:"
        '
        'ActiveLabel
        '
        ActiveLabel.AutoSize = True
        ActiveLabel.BackColor = System.Drawing.Color.Transparent
        ActiveLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ActiveLabel.Location = New System.Drawing.Point(3, 320)
        ActiveLabel.Name = "ActiveLabel"
        ActiveLabel.Size = New System.Drawing.Size(58, 18)
        ActiveLabel.TabIndex = 43
        ActiveLabel.Text = "Active:"
        '
        'btnBack
        '
        btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnBack.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.BackButton
        btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnBack.Location = New System.Drawing.Point(963, 8)
        btnBack.Name = "btnBack"
        btnBack.Size = New System.Drawing.Size(38, 37)
        btnBack.TabIndex = 55
        btnBack.UseVisualStyleBackColor = True
        AddHandler btnBack.Click, AddressOf Me.btnBack_Click
        '
        'btnExit
        '
        btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnExit.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.close
        btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnExit.Location = New System.Drawing.Point(1007, 8)
        btnExit.Name = "btnExit"
        btnExit.Size = New System.Drawing.Size(38, 37)
        btnExit.TabIndex = 56
        btnExit.UseVisualStyleBackColor = True
        AddHandler btnExit.Click, AddressOf Me.btnExit_Click
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(3, 351)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(155, 18)
        Label1.TabIndex = 43
        Label1.Text = "Total Fine Amount :"
        '
        'txtMemSearch
        '
        Me.txtMemSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMemSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtMemSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemSearch.Location = New System.Drawing.Point(595, 125)
        Me.txtMemSearch.Name = "txtMemSearch"
        Me.txtMemSearch.Size = New System.Drawing.Size(433, 26)
        Me.txtMemSearch.TabIndex = 3
        Me.txtMemSearch.Text = "Search Here"
        '
        'btnNewBatch
        '
        Me.btnNewBatch.BackColor = System.Drawing.Color.Transparent
        Me.btnNewBatch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewBatch.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNewBatch.FlatAppearance.BorderSize = 0
        Me.btnNewBatch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnNewBatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnNewBatch.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewBatch.ForeColor = System.Drawing.Color.Navy
        Me.btnNewBatch.Location = New System.Drawing.Point(23, 125)
        Me.btnNewBatch.Name = "btnNewBatch"
        Me.btnNewBatch.Size = New System.Drawing.Size(143, 29)
        Me.btnNewBatch.TabIndex = 0
        Me.btnNewBatch.Text = "Add New Batch"
        Me.btnNewBatch.UseVisualStyleBackColor = False
        '
        'Title1
        '
        Me.Title1.AutoSize = True
        Me.Title1.BackColor = System.Drawing.Color.Transparent
        Me.Title1.Font = New System.Drawing.Font("Trajan Pro", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title1.ForeColor = System.Drawing.Color.Navy
        Me.Title1.Location = New System.Drawing.Point(102, 8)
        Me.Title1.Name = "Title1"
        Me.Title1.Size = New System.Drawing.Size(797, 61)
        Me.Title1.TabIndex = 19
        Me.Title1.Text = "Library Management System"
        '
        'Title2
        '
        Me.Title2.AutoSize = True
        Me.Title2.BackColor = System.Drawing.Color.Transparent
        Me.Title2.Font = New System.Drawing.Font("Trajan Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title2.ForeColor = System.Drawing.Color.Navy
        Me.Title2.Location = New System.Drawing.Point(108, 66)
        Me.Title2.Name = "Title2"
        Me.Title2.Size = New System.Drawing.Size(734, 27)
        Me.Title2.TabIndex = 18
        Me.Title2.Text = "Sri Lanka Institute Of Advanced Technological Education"
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.Image = Global.LibrarySystem.My.Resources.Resources.SliateLogo
        Me.pbxLogo.Location = New System.Drawing.Point(3, 8)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(93, 86)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 17
        Me.pbxLogo.TabStop = False
        '
        'txtStudID
        '
        Me.txtStudID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStudID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "StudentID", True))
        Me.txtStudID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudID.Location = New System.Drawing.Point(3, 5)
        Me.txtStudID.Name = "txtStudID"
        Me.txtStudID.ReadOnly = True
        Me.txtStudID.Size = New System.Drawing.Size(224, 24)
        Me.txtStudID.TabIndex = 0
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "student"
        Me.StudentBindingSource.DataSource = Me.LibraryDB
        '
        'LibraryDB
        '
        Me.LibraryDB.DataSetName = "LibraryDB"
        Me.LibraryDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtFName
        '
        Me.txtFName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "First_Name", True))
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(3, 33)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(224, 24)
        Me.txtFName.TabIndex = 1
        '
        'txtLName
        '
        Me.txtLName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Last_Name", True))
        Me.txtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(3, 61)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(224, 24)
        Me.txtLName.TabIndex = 2
        '
        'txtNIC
        '
        Me.txtNIC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNIC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "NIC", True))
        Me.txtNIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIC.Location = New System.Drawing.Point(3, 173)
        Me.txtNIC.Name = "txtNIC"
        Me.txtNIC.Size = New System.Drawing.Size(224, 24)
        Me.txtNIC.TabIndex = 6
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.AutoCompleteCustomSource.AddRange(New String() {"Kandy", "Matale", "Nuwara Eliya"})
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Address", True))
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(3, 201)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(224, 24)
        Me.txtAddress.TabIndex = 7
        '
        'txtYear
        '
        Me.txtYear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtYear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Year", True))
        Me.txtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(3, 89)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(224, 24)
        Me.txtYear.TabIndex = 3
        '
        'txtAdmission
        '
        Me.txtAdmission.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAdmission.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "AdmissionNo", True))
        Me.txtAdmission.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdmission.Location = New System.Drawing.Point(3, 145)
        Me.txtAdmission.Name = "txtAdmission"
        Me.txtAdmission.Size = New System.Drawing.Size(224, 24)
        Me.txtAdmission.TabIndex = 5
        '
        'txtTelephone
        '
        Me.txtTelephone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelephone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Telephone", True))
        Me.txtTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephone.Location = New System.Drawing.Point(3, 287)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(224, 24)
        Me.txtTelephone.TabIndex = 10
        '
        'chkActive
        '
        Me.chkActive.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkActive.BackColor = System.Drawing.Color.Transparent
        Me.chkActive.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.StudentBindingSource, "Active", True))
        Me.chkActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActive.Location = New System.Drawing.Point(3, 315)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(224, 24)
        Me.chkActive.TabIndex = 11
        Me.chkActive.UseVisualStyleBackColor = False
        '
        'btnUpdateMem
        '
        Me.btnUpdateMem.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateMem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateMem.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUpdateMem.FlatAppearance.BorderSize = 0
        Me.btnUpdateMem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnUpdateMem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnUpdateMem.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateMem.ForeColor = System.Drawing.Color.Navy
        Me.btnUpdateMem.Location = New System.Drawing.Point(181, 125)
        Me.btnUpdateMem.Name = "btnUpdateMem"
        Me.btnUpdateMem.Size = New System.Drawing.Size(143, 29)
        Me.btnUpdateMem.TabIndex = 1
        Me.btnUpdateMem.Text = "Update Details"
        Me.btnUpdateMem.UseVisualStyleBackColor = False
        '
        'pnlDetails
        '
        Me.pnlDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDetails.Controls.Add(Label1)
        Me.pnlDetails.Controls.Add(Me.pbxActive)
        Me.pnlDetails.Controls.Add(Me.pnlDetails2)
        Me.pnlDetails.Controls.Add(StudentIDLabel)
        Me.pnlDetails.Controls.Add(First_NameLabel)
        Me.pnlDetails.Controls.Add(ActiveLabel)
        Me.pnlDetails.Controls.Add(Last_NameLabel)
        Me.pnlDetails.Controls.Add(TelephoneLabel)
        Me.pnlDetails.Controls.Add(NICLabel)
        Me.pnlDetails.Controls.Add(GenderLabel)
        Me.pnlDetails.Controls.Add(AddressLabel)
        Me.pnlDetails.Controls.Add(AdmissionNoLabel)
        Me.pnlDetails.Controls.Add(DepartmentLabel)
        Me.pnlDetails.Controls.Add(Full_TimeLabel)
        Me.pnlDetails.Controls.Add(YearLabel)
        Me.pnlDetails.HorizontalScrollbarBarColor = True
        Me.pnlDetails.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlDetails.HorizontalScrollbarSize = 10
        Me.pnlDetails.Location = New System.Drawing.Point(23, 180)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(364, 450)
        Me.pnlDetails.TabIndex = 5
        Me.pnlDetails.UseCustomBackColor = True
        Me.pnlDetails.VerticalScrollbarBarColor = True
        Me.pnlDetails.VerticalScrollbarHighlightOnWheel = False
        Me.pnlDetails.VerticalScrollbarSize = 10
        '
        'pbxActive
        '
        Me.pbxActive.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxActive.BackColor = System.Drawing.Color.Transparent
        Me.pbxActive.Location = New System.Drawing.Point(6, 385)
        Me.pbxActive.Name = "pbxActive"
        Me.pbxActive.Size = New System.Drawing.Size(348, 60)
        Me.pbxActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxActive.TabIndex = 45
        Me.pbxActive.TabStop = False
        '
        'pnlDetails2
        '
        Me.pnlDetails2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDetails2.Controls.Add(Me.txtStudID)
        Me.pnlDetails2.Controls.Add(Me.txtYear)
        Me.pnlDetails2.Controls.Add(Me.cmbType)
        Me.pnlDetails2.Controls.Add(Me.cmbDep)
        Me.pnlDetails2.Controls.Add(Me.txtAddress)
        Me.pnlDetails2.Controls.Add(Me.txtAdmission)
        Me.pnlDetails2.Controls.Add(Me.txtFName)
        Me.pnlDetails2.Controls.Add(Me.txtFine)
        Me.pnlDetails2.Controls.Add(Me.txtNIC)
        Me.pnlDetails2.Controls.Add(Me.txtLName)
        Me.pnlDetails2.Controls.Add(Me.txtGender)
        Me.pnlDetails2.Controls.Add(Me.txtTelephone)
        Me.pnlDetails2.Controls.Add(Me.chkActive)
        Me.pnlDetails2.Enabled = False
        Me.pnlDetails2.Location = New System.Drawing.Point(127, 3)
        Me.pnlDetails2.Name = "pnlDetails2"
        Me.pnlDetails2.Size = New System.Drawing.Size(230, 376)
        Me.pnlDetails2.TabIndex = 45
        '
        'cmbType
        '
        Me.cmbType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbType.BackColor = System.Drawing.Color.White
        Me.cmbType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Course_Type", True))
        Me.cmbType.DisplayMember = "DepID"
        Me.cmbType.DropDownWidth = 200
        Me.cmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.IntegralHeight = False
        Me.cmbType.Items.AddRange(New Object() {"Full Time", "Part Time"})
        Me.cmbType.Location = New System.Drawing.Point(3, 116)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(224, 26)
        Me.cmbType.TabIndex = 44
        Me.cmbType.ValueMember = "DepID"
        '
        'cmbDep
        '
        Me.cmbDep.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbDep.BackColor = System.Drawing.Color.White
        Me.cmbDep.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Department", True))
        Me.cmbDep.DataSource = Me.DepartmentBindingSource
        Me.cmbDep.DisplayMember = "DepID"
        Me.cmbDep.DropDownWidth = 200
        Me.cmbDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmbDep.FormattingEnabled = True
        Me.cmbDep.IntegralHeight = False
        Me.cmbDep.Location = New System.Drawing.Point(3, 229)
        Me.cmbDep.Name = "cmbDep"
        Me.cmbDep.Size = New System.Drawing.Size(224, 26)
        Me.cmbDep.TabIndex = 44
        Me.cmbDep.ValueMember = "DepID"
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "department"
        Me.DepartmentBindingSource.DataSource = Me.LibraryDB
        '
        'txtFine
        '
        Me.txtFine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFine.BackColor = System.Drawing.Color.White
        Me.txtFine.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFine.Location = New System.Drawing.Point(30, 345)
        Me.txtFine.Name = "txtFine"
        Me.txtFine.ReadOnly = True
        Me.txtFine.Size = New System.Drawing.Size(197, 24)
        Me.txtFine.TabIndex = 6
        '
        'txtGender
        '
        Me.txtGender.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGender.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female"})
        Me.txtGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Gender", True))
        Me.txtGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(3, 259)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(224, 24)
        Me.txtGender.TabIndex = 9
        '
        'cmbDataField
        '
        Me.cmbDataField.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmbDataField.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbDataField.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbDataField.ForeColor = System.Drawing.SystemColors.InfoText
        Me.cmbDataField.FormattingEnabled = True
        Me.cmbDataField.Items.AddRange(New Object() {"Admission No", "First Name", "Last Name", "NIC", "Student ID", "Telephone"})
        Me.cmbDataField.Location = New System.Drawing.Point(442, 125)
        Me.cmbDataField.Name = "cmbDataField"
        Me.cmbDataField.Size = New System.Drawing.Size(147, 28)
        Me.cmbDataField.Sorted = True
        Me.cmbDataField.TabIndex = 2
        Me.cmbDataField.Text = "First Name"
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox.Image = Global.LibrarySystem.My.Resources.Resources.Search
        Me.PictureBox.Location = New System.Drawing.Point(381, 116)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(55, 49)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox.TabIndex = 54
        Me.PictureBox.TabStop = False
        '
        'gridMembership
        '
        Me.gridMembership.AllowUserToResizeRows = False
        Me.gridMembership.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridMembership.AutoGenerateColumns = False
        Me.gridMembership.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridMembership.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridMembership.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gridMembership.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridMembership.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridMembership.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridMembership.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.ActiveDataGridViewCheckBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.NICDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.CourseTypeDataGridViewTextBoxColumn, Me.AdmissionNoDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.TelephoneDataGridViewTextBoxColumn})
        Me.gridMembership.DataSource = Me.StudentBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridMembership.DefaultCellStyle = DataGridViewCellStyle2
        Me.gridMembership.EnableHeadersVisualStyles = False
        Me.gridMembership.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.gridMembership.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridMembership.Location = New System.Drawing.Point(393, 180)
        Me.gridMembership.MultiSelect = False
        Me.gridMembership.Name = "gridMembership"
        Me.gridMembership.ReadOnly = True
        Me.gridMembership.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridMembership.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gridMembership.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gridMembership.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridMembership.Size = New System.Drawing.Size(635, 254)
        Me.gridMembership.Style = MetroFramework.MetroColorStyle.Green
        Me.gridMembership.TabIndex = 57
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActiveDataGridViewCheckBoxColumn
        '
        Me.ActiveDataGridViewCheckBoxColumn.DataPropertyName = "Active"
        Me.ActiveDataGridViewCheckBoxColumn.HeaderText = "Active"
        Me.ActiveDataGridViewCheckBoxColumn.Name = "ActiveDataGridViewCheckBoxColumn"
        Me.ActiveDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NICDataGridViewTextBoxColumn
        '
        Me.NICDataGridViewTextBoxColumn.DataPropertyName = "NIC"
        Me.NICDataGridViewTextBoxColumn.HeaderText = "NIC"
        Me.NICDataGridViewTextBoxColumn.Name = "NICDataGridViewTextBoxColumn"
        Me.NICDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        Me.YearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseTypeDataGridViewTextBoxColumn
        '
        Me.CourseTypeDataGridViewTextBoxColumn.DataPropertyName = "Course_Type"
        Me.CourseTypeDataGridViewTextBoxColumn.HeaderText = "Course_Type"
        Me.CourseTypeDataGridViewTextBoxColumn.Name = "CourseTypeDataGridViewTextBoxColumn"
        Me.CourseTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdmissionNoDataGridViewTextBoxColumn
        '
        Me.AdmissionNoDataGridViewTextBoxColumn.DataPropertyName = "AdmissionNo"
        Me.AdmissionNoDataGridViewTextBoxColumn.HeaderText = "AdmissionNo"
        Me.AdmissionNoDataGridViewTextBoxColumn.Name = "AdmissionNoDataGridViewTextBoxColumn"
        Me.AdmissionNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelephoneDataGridViewTextBoxColumn
        '
        Me.TelephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.HeaderText = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.Name = "TelephoneDataGridViewTextBoxColumn"
        Me.TelephoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'gridIssuedBooks
        '
        Me.gridIssuedBooks.AllowUserToResizeRows = False
        Me.gridIssuedBooks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridIssuedBooks.AutoGenerateColumns = False
        Me.gridIssuedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridIssuedBooks.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridIssuedBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gridIssuedBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridIssuedBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.gridIssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridIssuedBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IssueIDDataGridViewTextBoxColumn, Me.AccessionIDDataGridViewTextBoxColumn, Me.BorrowedDateDataGridViewTextBoxColumn, Me.DueDateDataGridViewTextBoxColumn, Me.ReturnedDateDataGridViewTextBoxColumn, Me.ReturnedDataGridViewCheckBoxColumn})
        Me.gridIssuedBooks.DataSource = Me.IssuebookBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridIssuedBooks.DefaultCellStyle = DataGridViewCellStyle5
        Me.gridIssuedBooks.EnableHeadersVisualStyles = False
        Me.gridIssuedBooks.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.gridIssuedBooks.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridIssuedBooks.Location = New System.Drawing.Point(393, 467)
        Me.gridIssuedBooks.Name = "gridIssuedBooks"
        Me.gridIssuedBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridIssuedBooks.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.gridIssuedBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gridIssuedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridIssuedBooks.Size = New System.Drawing.Size(635, 163)
        Me.gridIssuedBooks.Style = MetroFramework.MetroColorStyle.Teal
        Me.gridIssuedBooks.TabIndex = 58
        '
        'IssueIDDataGridViewTextBoxColumn
        '
        Me.IssueIDDataGridViewTextBoxColumn.DataPropertyName = "Issue_ID"
        Me.IssueIDDataGridViewTextBoxColumn.HeaderText = "Issue_ID"
        Me.IssueIDDataGridViewTextBoxColumn.Name = "IssueIDDataGridViewTextBoxColumn"
        '
        'AccessionIDDataGridViewTextBoxColumn
        '
        Me.AccessionIDDataGridViewTextBoxColumn.DataPropertyName = "Accession_ID"
        Me.AccessionIDDataGridViewTextBoxColumn.HeaderText = "Accession_ID"
        Me.AccessionIDDataGridViewTextBoxColumn.Name = "AccessionIDDataGridViewTextBoxColumn"
        '
        'BorrowedDateDataGridViewTextBoxColumn
        '
        Me.BorrowedDateDataGridViewTextBoxColumn.DataPropertyName = "Borrowed_Date"
        Me.BorrowedDateDataGridViewTextBoxColumn.HeaderText = "Borrowed_Date"
        Me.BorrowedDateDataGridViewTextBoxColumn.Name = "BorrowedDateDataGridViewTextBoxColumn"
        '
        'DueDateDataGridViewTextBoxColumn
        '
        Me.DueDateDataGridViewTextBoxColumn.DataPropertyName = "Due_Date"
        Me.DueDateDataGridViewTextBoxColumn.HeaderText = "Due_Date"
        Me.DueDateDataGridViewTextBoxColumn.Name = "DueDateDataGridViewTextBoxColumn"
        '
        'ReturnedDateDataGridViewTextBoxColumn
        '
        Me.ReturnedDateDataGridViewTextBoxColumn.DataPropertyName = "Returned_Date"
        Me.ReturnedDateDataGridViewTextBoxColumn.HeaderText = "Returned_Date"
        Me.ReturnedDateDataGridViewTextBoxColumn.Name = "ReturnedDateDataGridViewTextBoxColumn"
        '
        'ReturnedDataGridViewCheckBoxColumn
        '
        Me.ReturnedDataGridViewCheckBoxColumn.DataPropertyName = "Returned"
        Me.ReturnedDataGridViewCheckBoxColumn.HeaderText = "Returned"
        Me.ReturnedDataGridViewCheckBoxColumn.Name = "ReturnedDataGridViewCheckBoxColumn"
        '
        'IssuebookBindingSource
        '
        Me.IssuebookBindingSource.DataMember = "issue_book"
        Me.IssuebookBindingSource.DataSource = Me.LibraryDB
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(393, 446)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 18)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "History of Issued Books"
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'Issue_bookTableAdapter
        '
        Me.Issue_bookTableAdapter.ClearBeforeFill = True
        '
        'frmMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 653)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gridIssuedBooks)
        Me.Controls.Add(Me.gridMembership)
        Me.Controls.Add(btnExit)
        Me.Controls.Add(btnBack)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.cmbDataField)
        Me.Controls.Add(Me.Title1)
        Me.Controls.Add(Me.Title2)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.txtMemSearch)
        Me.Controls.Add(Me.btnUpdateMem)
        Me.Controls.Add(Me.btnNewBatch)
        Me.Controls.Add(Me.pnlDetails)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMembers"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.TransparencyKey = System.Drawing.Color.Empty
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        CType(Me.pbxActive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDetails2.ResumeLayout(False)
        Me.pnlDetails2.PerformLayout()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridMembership, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridIssuedBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssuebookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMemSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnNewBatch As System.Windows.Forms.Button
    Friend WithEvents Title1 As System.Windows.Forms.Label
    Friend WithEvents Title2 As System.Windows.Forms.Label
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents txtStudID As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtNIC As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents txtAdmission As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents btnUpdateMem As System.Windows.Forms.Button
    Friend WithEvents pnlDetails As MetroFramework.Controls.MetroPanel
    Friend WithEvents cmbDataField As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents cmbDep As System.Windows.Forms.ComboBox
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents pnlDetails2 As System.Windows.Forms.Panel
    Friend WithEvents pbxActive As System.Windows.Forms.PictureBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents gridMembership As MetroFramework.Controls.MetroGrid
    Friend WithEvents LibraryDB As LibrarySystem.LibraryDB
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As LibrarySystem.LibraryDBTableAdapters.departmentTableAdapter
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As LibrarySystem.LibraryDBTableAdapters.studentTableAdapter
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActiveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NICDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdmissionNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelephoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtFine As System.Windows.Forms.TextBox
    Friend WithEvents gridIssuedBooks As MetroFramework.Controls.MetroGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IssuebookBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Issue_bookTableAdapter As LibrarySystem.LibraryDBTableAdapters.issue_bookTableAdapter
    Friend WithEvents IssueIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessionIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BorrowedDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DueDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturnedDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturnedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn


  
End Class
