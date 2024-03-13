<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Dim Lending_IDLabel As System.Windows.Forms.Label
        Dim Accession_IDLabel As System.Windows.Forms.Label
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim PatronLabel As System.Windows.Forms.Label
        Dim Borrowed_DateLabel As System.Windows.Forms.Label
        Dim Due_DateLabel As System.Windows.Forms.Label
        Dim Returned_DateLabel As System.Windows.Forms.Label
        Dim ReturnedLabel As System.Windows.Forms.Label
        Dim FineLabel As System.Windows.Forms.Label
        Dim btnBack As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Title1 = New System.Windows.Forms.Label()
        Me.Title2 = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.tabControl = New MetroFramework.Controls.MetroTabControl()
        Me.t3 = New MetroFramework.Controls.MetroTabPage()
        Me.gridReports = New MetroFramework.Controls.MetroGrid()
        Me.IssueIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatronDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssuebookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibrarydbDataSet = New LibrarySystem.LibraryDB()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblReturnedBooks = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOverDues = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dateByDate = New System.Windows.Forms.DateTimePicker()
        Me.rbtnDate = New System.Windows.Forms.RadioButton()
        Me.rbtnAllOverdues = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.btnView = New System.Windows.Forms.Button()
        Me.txtIssueID = New System.Windows.Forms.TextBox()
        Me.Accession_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.StudentIDComboBox = New System.Windows.Forms.ComboBox()
        Me.PatronComboBox = New System.Windows.Forms.ComboBox()
        Me.Borrowed_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Due_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Returned_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ReturnedCheckBox = New System.Windows.Forms.CheckBox()
        Me.FineTextBox = New System.Windows.Forms.TextBox()
        Me.t2 = New MetroFramework.Controls.MetroTabPage()
        Me.chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStats = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Issue_bookTableAdapter = New LibrarySystem.LibraryDBTableAdapters.issue_bookTableAdapter()
        Lending_IDLabel = New System.Windows.Forms.Label()
        Accession_IDLabel = New System.Windows.Forms.Label()
        StudentIDLabel = New System.Windows.Forms.Label()
        PatronLabel = New System.Windows.Forms.Label()
        Borrowed_DateLabel = New System.Windows.Forms.Label()
        Due_DateLabel = New System.Windows.Forms.Label()
        Returned_DateLabel = New System.Windows.Forms.Label()
        ReturnedLabel = New System.Windows.Forms.Label()
        FineLabel = New System.Windows.Forms.Label()
        btnBack = New System.Windows.Forms.Button()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.tabControl.SuspendLayout()
        Me.t3.SuspendLayout()
        CType(Me.gridReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssuebookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrarydbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.t2.SuspendLayout()
        CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lending_IDLabel
        '
        Lending_IDLabel.AutoSize = True
        Lending_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Lending_IDLabel.Location = New System.Drawing.Point(3, 29)
        Lending_IDLabel.Name = "Lending_IDLabel"
        Lending_IDLabel.Size = New System.Drawing.Size(76, 20)
        Lending_IDLabel.TabIndex = 0
        Lending_IDLabel.Text = "Issue No:"
        '
        'Accession_IDLabel
        '
        Accession_IDLabel.AutoSize = True
        Accession_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Accession_IDLabel.Location = New System.Drawing.Point(3, 60)
        Accession_IDLabel.Name = "Accession_IDLabel"
        Accession_IDLabel.Size = New System.Drawing.Size(107, 20)
        Accession_IDLabel.TabIndex = 2
        Accession_IDLabel.Text = "Accession ID:"
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StudentIDLabel.Location = New System.Drawing.Point(3, 93)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(91, 20)
        StudentIDLabel.TabIndex = 4
        StudentIDLabel.Text = "Student ID:"
        '
        'PatronLabel
        '
        PatronLabel.AutoSize = True
        PatronLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PatronLabel.Location = New System.Drawing.Point(3, 126)
        PatronLabel.Name = "PatronLabel"
        PatronLabel.Size = New System.Drawing.Size(60, 20)
        PatronLabel.TabIndex = 6
        PatronLabel.Text = "Patron:"
        '
        'Borrowed_DateLabel
        '
        Borrowed_DateLabel.AutoSize = True
        Borrowed_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Borrowed_DateLabel.Location = New System.Drawing.Point(383, 29)
        Borrowed_DateLabel.Name = "Borrowed_DateLabel"
        Borrowed_DateLabel.Size = New System.Drawing.Size(120, 20)
        Borrowed_DateLabel.TabIndex = 8
        Borrowed_DateLabel.Text = "Borrowed Date:"
        '
        'Due_DateLabel
        '
        Due_DateLabel.AutoSize = True
        Due_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Due_DateLabel.Location = New System.Drawing.Point(383, 60)
        Due_DateLabel.Name = "Due_DateLabel"
        Due_DateLabel.Size = New System.Drawing.Size(82, 20)
        Due_DateLabel.TabIndex = 10
        Due_DateLabel.Text = "Due Date:"
        '
        'Returned_DateLabel
        '
        Returned_DateLabel.AutoSize = True
        Returned_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Returned_DateLabel.Location = New System.Drawing.Point(383, 91)
        Returned_DateLabel.Name = "Returned_DateLabel"
        Returned_DateLabel.Size = New System.Drawing.Size(119, 20)
        Returned_DateLabel.TabIndex = 12
        Returned_DateLabel.Text = "Returned Date:"
        '
        'ReturnedLabel
        '
        ReturnedLabel.AutoSize = True
        ReturnedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReturnedLabel.Location = New System.Drawing.Point(3, 164)
        ReturnedLabel.Name = "ReturnedLabel"
        ReturnedLabel.Size = New System.Drawing.Size(80, 20)
        ReturnedLabel.TabIndex = 14
        ReturnedLabel.Text = "Returned:"
        '
        'FineLabel
        '
        FineLabel.AutoSize = True
        FineLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FineLabel.Location = New System.Drawing.Point(386, 126)
        FineLabel.Name = "FineLabel"
        FineLabel.Size = New System.Drawing.Size(44, 20)
        FineLabel.TabIndex = 16
        FineLabel.Text = "Fine:"
        '
        'btnBack
        '
        btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnBack.Location = New System.Drawing.Point(1122, 3)
        btnBack.Name = "btnBack"
        btnBack.Size = New System.Drawing.Size(38, 37)
        btnBack.TabIndex = 57
        btnBack.UseVisualStyleBackColor = True
        AddHandler btnBack.Click, AddressOf Me.btnBack_Click
        '
        'Title1
        '
        Me.Title1.AutoSize = True
        Me.Title1.BackColor = System.Drawing.Color.Transparent
        Me.Title1.Font = New System.Drawing.Font("Trajan Pro", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title1.ForeColor = System.Drawing.Color.Navy
        Me.Title1.Location = New System.Drawing.Point(101, 7)
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
        Me.Title2.ForeColor = System.Drawing.Color.Navy
        Me.Title2.Location = New System.Drawing.Point(107, 65)
        Me.Title2.Name = "Title2"
        Me.Title2.Size = New System.Drawing.Size(734, 27)
        Me.Title2.TabIndex = 8
        Me.Title2.Text = "Sri Lanka Institute Of Advanced Technological Education"
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.Image = CType(resources.GetObject("pbxLogo.Image"), System.Drawing.Image)
        Me.pbxLogo.Location = New System.Drawing.Point(2, 7)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(93, 86)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 7
        Me.pbxLogo.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.tabControl)
        Me.Panel7.Controls.Add(btnBack)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(20, 60)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1160, 520)
        Me.Panel7.TabIndex = 23
        '
        'tabControl
        '
        Me.tabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControl.Controls.Add(Me.t2)
        Me.tabControl.Controls.Add(Me.t3)
        Me.tabControl.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.tabControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular
        Me.tabControl.HotTrack = True
        Me.tabControl.Location = New System.Drawing.Point(3, 39)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(1154, 478)
        Me.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tabControl.TabIndex = 30
        Me.tabControl.UseSelectable = True
        '
        't3
        '
        Me.t3.Controls.Add(Me.gridReports)
        Me.t3.Controls.Add(Me.Panel1)
        Me.t3.Controls.Add(Me.Panel)
        Me.t3.HorizontalScrollbarBarColor = True
        Me.t3.HorizontalScrollbarHighlightOnWheel = False
        Me.t3.HorizontalScrollbarSize = 10
        Me.t3.Location = New System.Drawing.Point(4, 44)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(1146, 430)
        Me.t3.TabIndex = 0
        Me.t3.Text = "All Transactions"
        Me.t3.VerticalScrollbarBarColor = True
        Me.t3.VerticalScrollbarHighlightOnWheel = False
        Me.t3.VerticalScrollbarSize = 10
        '
        'gridReports
        '
        Me.gridReports.AllowUserToResizeRows = False
        Me.gridReports.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridReports.AutoGenerateColumns = False
        Me.gridReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridReports.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridReports.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridReports.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gridReports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridReports.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridReports.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IssueIDDataGridViewTextBoxColumn, Me.AccessionIDDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn, Me.PatronDataGridViewTextBoxColumn, Me.BorrowedDateDataGridViewTextBoxColumn, Me.DueDateDataGridViewTextBoxColumn, Me.ReturnedDateDataGridViewTextBoxColumn, Me.ReturnedDataGridViewCheckBoxColumn, Me.FineDataGridViewTextBoxColumn})
        Me.gridReports.DataSource = Me.IssuebookBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridReports.DefaultCellStyle = DataGridViewCellStyle2
        Me.gridReports.EnableHeadersVisualStyles = False
        Me.gridReports.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.gridReports.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridReports.Location = New System.Drawing.Point(3, 238)
        Me.gridReports.MultiSelect = False
        Me.gridReports.Name = "gridReports"
        Me.gridReports.ReadOnly = True
        Me.gridReports.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridReports.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gridReports.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gridReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridReports.Size = New System.Drawing.Size(1140, 189)
        Me.gridReports.Style = MetroFramework.MetroColorStyle.Teal
        Me.gridReports.TabIndex = 29
        '
        'IssueIDDataGridViewTextBoxColumn
        '
        Me.IssueIDDataGridViewTextBoxColumn.DataPropertyName = "Issue_ID"
        Me.IssueIDDataGridViewTextBoxColumn.HeaderText = "Issue_ID"
        Me.IssueIDDataGridViewTextBoxColumn.Name = "IssueIDDataGridViewTextBoxColumn"
        Me.IssueIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessionIDDataGridViewTextBoxColumn
        '
        Me.AccessionIDDataGridViewTextBoxColumn.DataPropertyName = "Accession_ID"
        Me.AccessionIDDataGridViewTextBoxColumn.HeaderText = "Accession_ID"
        Me.AccessionIDDataGridViewTextBoxColumn.Name = "AccessionIDDataGridViewTextBoxColumn"
        Me.AccessionIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PatronDataGridViewTextBoxColumn
        '
        Me.PatronDataGridViewTextBoxColumn.DataPropertyName = "Patron"
        Me.PatronDataGridViewTextBoxColumn.HeaderText = "Patron"
        Me.PatronDataGridViewTextBoxColumn.Name = "PatronDataGridViewTextBoxColumn"
        Me.PatronDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorrowedDateDataGridViewTextBoxColumn
        '
        Me.BorrowedDateDataGridViewTextBoxColumn.DataPropertyName = "Borrowed_Date"
        Me.BorrowedDateDataGridViewTextBoxColumn.HeaderText = "Borrowed_Date"
        Me.BorrowedDateDataGridViewTextBoxColumn.Name = "BorrowedDateDataGridViewTextBoxColumn"
        Me.BorrowedDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DueDateDataGridViewTextBoxColumn
        '
        Me.DueDateDataGridViewTextBoxColumn.DataPropertyName = "Due_Date"
        Me.DueDateDataGridViewTextBoxColumn.HeaderText = "Due_Date"
        Me.DueDateDataGridViewTextBoxColumn.Name = "DueDateDataGridViewTextBoxColumn"
        Me.DueDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReturnedDateDataGridViewTextBoxColumn
        '
        Me.ReturnedDateDataGridViewTextBoxColumn.DataPropertyName = "Returned_Date"
        Me.ReturnedDateDataGridViewTextBoxColumn.HeaderText = "Returned_Date"
        Me.ReturnedDateDataGridViewTextBoxColumn.Name = "ReturnedDateDataGridViewTextBoxColumn"
        Me.ReturnedDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReturnedDataGridViewCheckBoxColumn
        '
        Me.ReturnedDataGridViewCheckBoxColumn.DataPropertyName = "Returned"
        Me.ReturnedDataGridViewCheckBoxColumn.HeaderText = "Returned"
        Me.ReturnedDataGridViewCheckBoxColumn.Name = "ReturnedDataGridViewCheckBoxColumn"
        Me.ReturnedDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'FineDataGridViewTextBoxColumn
        '
        Me.FineDataGridViewTextBoxColumn.DataPropertyName = "Fine"
        Me.FineDataGridViewTextBoxColumn.HeaderText = "Fine"
        Me.FineDataGridViewTextBoxColumn.Name = "FineDataGridViewTextBoxColumn"
        Me.FineDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IssuebookBindingSource
        '
        Me.IssuebookBindingSource.DataMember = "issue_book"
        Me.IssuebookBindingSource.DataSource = Me.LibrarydbDataSet
        '
        'LibrarydbDataSet
        '
        Me.LibrarydbDataSet.DataSetName = "librarydbDataSet"
        Me.LibrarydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 218)
        Me.Panel1.TabIndex = 27
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblReturnedBooks)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblOverDues)
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(10, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(410, 103)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Summary"
        '
        'lblReturnedBooks
        '
        Me.lblReturnedBooks.AutoSize = True
        Me.lblReturnedBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnedBooks.ForeColor = System.Drawing.Color.Blue
        Me.lblReturnedBooks.Location = New System.Drawing.Point(229, 22)
        Me.lblReturnedBooks.Name = "lblReturnedBooks"
        Me.lblReturnedBooks.Size = New System.Drawing.Size(43, 24)
        Me.lblReturnedBooks.TabIndex = 12
        Me.lblReturnedBooks.Text = "###"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Books Returned :"
        '
        'lblOverDues
        '
        Me.lblOverDues.AutoSize = True
        Me.lblOverDues.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverDues.ForeColor = System.Drawing.Color.Red
        Me.lblOverDues.Location = New System.Drawing.Point(229, 48)
        Me.lblOverDues.Name = "lblOverDues"
        Me.lblOverDues.Size = New System.Drawing.Size(43, 24)
        Me.lblOverDues.TabIndex = 12
        Me.lblOverDues.Text = "###"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Magenta
        Me.lblTotal.Location = New System.Drawing.Point(229, 74)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(43, 24)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "###"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Not returned Books:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total Transactions :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dateByDate)
        Me.GroupBox1.Controls.Add(Me.rbtnDate)
        Me.GroupBox1.Controls.Add(Me.rbtnAllOverdues)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 92)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View Report"
        '
        'dateByDate
        '
        Me.dateByDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dateByDate.CustomFormat = "MMMM yyyy"
        Me.dateByDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateByDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateByDate.Location = New System.Drawing.Point(42, 52)
        Me.dateByDate.Margin = New System.Windows.Forms.Padding(0)
        Me.dateByDate.Name = "dateByDate"
        Me.dateByDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dateByDate.Size = New System.Drawing.Size(163, 26)
        Me.dateByDate.TabIndex = 8
        Me.dateByDate.Value = New Date(2017, 7, 27, 0, 0, 0, 0)
        Me.dateByDate.Visible = False
        '
        'rbtnDate
        '
        Me.rbtnDate.AutoSize = True
        Me.rbtnDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnDate.Location = New System.Drawing.Point(26, 53)
        Me.rbtnDate.Name = "rbtnDate"
        Me.rbtnDate.Size = New System.Drawing.Size(138, 22)
        Me.rbtnDate.TabIndex = 9
        Me.rbtnDate.Text = "Report By month"
        Me.rbtnDate.UseVisualStyleBackColor = True
        '
        'rbtnAllOverdues
        '
        Me.rbtnAllOverdues.AutoSize = True
        Me.rbtnAllOverdues.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnAllOverdues.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAllOverdues.Location = New System.Drawing.Point(241, 27)
        Me.rbtnAllOverdues.Name = "rbtnAllOverdues"
        Me.rbtnAllOverdues.Size = New System.Drawing.Size(151, 22)
        Me.rbtnAllOverdues.TabIndex = 10
        Me.rbtnAllOverdues.Text = "Show All Overdues"
        Me.rbtnAllOverdues.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(26, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(131, 22)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "All Transactions"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Panel
        '
        Me.Panel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel.Controls.Add(Me.btnView)
        Me.Panel.Controls.Add(Lending_IDLabel)
        Me.Panel.Controls.Add(Me.txtIssueID)
        Me.Panel.Controls.Add(Accession_IDLabel)
        Me.Panel.Controls.Add(Me.Accession_IDComboBox)
        Me.Panel.Controls.Add(StudentIDLabel)
        Me.Panel.Controls.Add(Me.StudentIDComboBox)
        Me.Panel.Controls.Add(PatronLabel)
        Me.Panel.Controls.Add(Me.PatronComboBox)
        Me.Panel.Controls.Add(Borrowed_DateLabel)
        Me.Panel.Controls.Add(Me.Borrowed_DateDateTimePicker)
        Me.Panel.Controls.Add(Due_DateLabel)
        Me.Panel.Controls.Add(Me.Due_DateDateTimePicker)
        Me.Panel.Controls.Add(Returned_DateLabel)
        Me.Panel.Controls.Add(Me.Returned_DateDateTimePicker)
        Me.Panel.Controls.Add(ReturnedLabel)
        Me.Panel.Controls.Add(Me.ReturnedCheckBox)
        Me.Panel.Controls.Add(FineLabel)
        Me.Panel.Controls.Add(Me.FineTextBox)
        Me.Panel.Location = New System.Drawing.Point(440, 3)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(703, 218)
        Me.Panel.TabIndex = 28
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(482, 173)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(169, 31)
        Me.btnView.TabIndex = 0
        Me.btnView.Text = "Show Report Viewer"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'txtIssueID
        '
        Me.txtIssueID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssuebookBindingSource, "Issue_ID", True))
        Me.txtIssueID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIssueID.Location = New System.Drawing.Point(141, 26)
        Me.txtIssueID.Name = "txtIssueID"
        Me.txtIssueID.ReadOnly = True
        Me.txtIssueID.Size = New System.Drawing.Size(207, 26)
        Me.txtIssueID.TabIndex = 1
        '
        'Accession_IDComboBox
        '
        Me.Accession_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssuebookBindingSource, "Accession_ID", True))
        Me.Accession_IDComboBox.Enabled = False
        Me.Accession_IDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Accession_IDComboBox.FormattingEnabled = True
        Me.Accession_IDComboBox.Location = New System.Drawing.Point(141, 57)
        Me.Accession_IDComboBox.Name = "Accession_IDComboBox"
        Me.Accession_IDComboBox.Size = New System.Drawing.Size(207, 28)
        Me.Accession_IDComboBox.TabIndex = 3
        '
        'StudentIDComboBox
        '
        Me.StudentIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssuebookBindingSource, "StudentID", True))
        Me.StudentIDComboBox.Enabled = False
        Me.StudentIDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentIDComboBox.FormattingEnabled = True
        Me.StudentIDComboBox.Location = New System.Drawing.Point(141, 90)
        Me.StudentIDComboBox.Name = "StudentIDComboBox"
        Me.StudentIDComboBox.Size = New System.Drawing.Size(207, 28)
        Me.StudentIDComboBox.TabIndex = 5
        '
        'PatronComboBox
        '
        Me.PatronComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssuebookBindingSource, "Patron", True))
        Me.PatronComboBox.Enabled = False
        Me.PatronComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatronComboBox.FormattingEnabled = True
        Me.PatronComboBox.Location = New System.Drawing.Point(141, 123)
        Me.PatronComboBox.Name = "PatronComboBox"
        Me.PatronComboBox.Size = New System.Drawing.Size(207, 28)
        Me.PatronComboBox.TabIndex = 7
        '
        'Borrowed_DateDateTimePicker
        '
        Me.Borrowed_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IssuebookBindingSource, "Borrowed_Date", True))
        Me.Borrowed_DateDateTimePicker.Enabled = False
        Me.Borrowed_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrowed_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Borrowed_DateDateTimePicker.Location = New System.Drawing.Point(521, 24)
        Me.Borrowed_DateDateTimePicker.Name = "Borrowed_DateDateTimePicker"
        Me.Borrowed_DateDateTimePicker.Size = New System.Drawing.Size(130, 26)
        Me.Borrowed_DateDateTimePicker.TabIndex = 9
        '
        'Due_DateDateTimePicker
        '
        Me.Due_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IssuebookBindingSource, "Due_Date", True))
        Me.Due_DateDateTimePicker.Enabled = False
        Me.Due_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Due_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Due_DateDateTimePicker.Location = New System.Drawing.Point(521, 55)
        Me.Due_DateDateTimePicker.Name = "Due_DateDateTimePicker"
        Me.Due_DateDateTimePicker.Size = New System.Drawing.Size(130, 26)
        Me.Due_DateDateTimePicker.TabIndex = 11
        '
        'Returned_DateDateTimePicker
        '
        Me.Returned_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IssuebookBindingSource, "Returned_Date", True))
        Me.Returned_DateDateTimePicker.Enabled = False
        Me.Returned_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Returned_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Returned_DateDateTimePicker.Location = New System.Drawing.Point(521, 86)
        Me.Returned_DateDateTimePicker.Name = "Returned_DateDateTimePicker"
        Me.Returned_DateDateTimePicker.Size = New System.Drawing.Size(130, 26)
        Me.Returned_DateDateTimePicker.TabIndex = 13
        '
        'ReturnedCheckBox
        '
        Me.ReturnedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.IssuebookBindingSource, "Returned", True))
        Me.ReturnedCheckBox.Enabled = False
        Me.ReturnedCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnedCheckBox.Location = New System.Drawing.Point(141, 162)
        Me.ReturnedCheckBox.Name = "ReturnedCheckBox"
        Me.ReturnedCheckBox.Size = New System.Drawing.Size(14, 26)
        Me.ReturnedCheckBox.TabIndex = 15
        Me.ReturnedCheckBox.UseVisualStyleBackColor = True
        '
        'FineTextBox
        '
        Me.FineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IssuebookBindingSource, "Fine", True))
        Me.FineTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FineTextBox.Location = New System.Drawing.Point(521, 123)
        Me.FineTextBox.Name = "FineTextBox"
        Me.FineTextBox.ReadOnly = True
        Me.FineTextBox.Size = New System.Drawing.Size(130, 26)
        Me.FineTextBox.TabIndex = 17
        '
        't2
        '
        Me.t2.Controls.Add(Me.chart)
        Me.t2.Controls.Add(Me.Label2)
        Me.t2.Controls.Add(Me.lblStats)
        Me.t2.Controls.Add(Me.Label5)
        Me.t2.HorizontalScrollbarBarColor = True
        Me.t2.HorizontalScrollbarHighlightOnWheel = False
        Me.t2.HorizontalScrollbarSize = 10
        Me.t2.Location = New System.Drawing.Point(4, 44)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(1146, 430)
        Me.t2.TabIndex = 1
        Me.t2.Text = "Weekly Transactions"
        Me.t2.VerticalScrollbarBarColor = True
        Me.t2.VerticalScrollbarHighlightOnWheel = False
        Me.t2.VerticalScrollbarSize = 10
        '
        'chart
        '
        Me.chart.BackColor = System.Drawing.Color.Transparent
        Me.chart.BackImageTransparentColor = System.Drawing.Color.Transparent
        Me.chart.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.chart.BorderlineColor = System.Drawing.Color.Transparent
        Me.chart.BorderlineWidth = 0
        ChartArea1.Name = "ChartArea1"
        Me.chart.ChartAreas.Add(ChartArea1)
        Me.chart.Cursor = System.Windows.Forms.Cursors.Hand
        Legend1.Name = "Legend1"
        Me.chart.Legends.Add(Legend1)
        Me.chart.Location = New System.Drawing.Point(446, 40)
        Me.chart.Name = "chart"
        Me.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.Lime
        Series1.Label = "Issued"
        Series1.Legend = "Legend1"
        Series1.Name = "Issued"
        Series2.ChartArea = "ChartArea1"
        Series2.Color = System.Drawing.Color.Red
        Series2.Label = "Returned"
        Series2.Legend = "Legend1"
        Series2.Name = "Returned"
        Me.chart.Series.Add(Series1)
        Me.chart.Series.Add(Series2)
        Me.chart.Size = New System.Drawing.Size(686, 374)
        Me.chart.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(442, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(447, 24)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Graphical Representation of this week's transactions."
        '
        'lblStats
        '
        Me.lblStats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStats.AutoSize = True
        Me.lblStats.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStats.ForeColor = System.Drawing.Color.Navy
        Me.lblStats.Location = New System.Drawing.Point(3, 17)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(108, 20)
        Me.lblStats.TabIndex = 20
        Me.lblStats.Text = "LOADING....."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(493, 414)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(233, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Click on the Chart to view in full screen."
        '
        'Issue_bookTableAdapter
        '
        Me.Issue_bookTableAdapter.ClearBeforeFill = True
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.Title1)
        Me.Controls.Add(Me.Title2)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.Panel7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "frmReports"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.tabControl.ResumeLayout(False)
        Me.t3.ResumeLayout(False)
        CType(Me.gridReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssuebookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrarydbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.t2.ResumeLayout(False)
        Me.t2.PerformLayout()
        CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title1 As System.Windows.Forms.Label
    Friend WithEvents Title2 As System.Windows.Forms.Label
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
   
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dateByDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents txtIssueID As System.Windows.Forms.TextBox
    Friend WithEvents Accession_IDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StudentIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PatronComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Borrowed_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Due_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Returned_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReturnedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FineTextBox As System.Windows.Forms.TextBox
    Friend WithEvents gridReports As MetroFramework.Controls.MetroGrid
    Friend WithEvents rbtnDate As System.Windows.Forms.RadioButton
 
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblReturnedBooks As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblOverDues As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnAllOverdues As System.Windows.Forms.RadioButton
    Friend WithEvents IssuebookBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Issue_bookTableAdapter As LibrarySystem.LibraryDBTableAdapters.issue_bookTableAdapter
    Friend WithEvents IssueIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessionIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatronDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BorrowedDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DueDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturnedDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturnedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibrarydbDataSet As LibrarySystem.LibraryDB
    Friend WithEvents tabControl As MetroFramework.Controls.MetroTabControl
    Friend WithEvents t2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents t3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents chart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblStats As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
