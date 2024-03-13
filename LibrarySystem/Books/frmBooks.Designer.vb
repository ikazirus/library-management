<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooks
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
        Dim Accession_IDLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim SectionLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim EditionLabel As System.Windows.Forms.Label
        Dim Shelf_IDLabel As System.Windows.Forms.Label
        Dim AvailableLabel As System.Windows.Forms.Label
        Dim btnExit As System.Windows.Forms.Button
        Dim btnBack As System.Windows.Forms.Button
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBooks))
        Me.Title1 = New System.Windows.Forms.Label()
        Me.Title2 = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.pnlDetails = New MetroFramework.Controls.MetroPanel()
        Me.gridAscnID = New MetroFramework.Controls.MetroGrid()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookascnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDB1 = New LibrarySystem.LibraryDB()
        Me.pbxAvailable = New System.Windows.Forms.PictureBox()
        Me.pnlDetails2 = New System.Windows.Forms.Panel()
        Me.txtCopies = New System.Windows.Forms.TextBox()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtEdition = New System.Windows.Forms.TextBox()
        Me.cmbSection = New System.Windows.Forms.ComboBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.cmbShelf = New System.Windows.Forms.ComboBox()
        Me.ShelfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.chkAvailable = New System.Windows.Forms.CheckBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtBookSearch = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNewBook = New System.Windows.Forms.Button()
        Me.cmbDataField = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gridBooks = New MetroFramework.Controls.MetroGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookTableAdapter1 = New LibrarySystem.LibraryDBTableAdapters.bookTableAdapter()
        Me.Book_ascnTableAdapter1 = New LibrarySystem.LibraryDBTableAdapters.book_ascnTableAdapter()
        Me.ShelfTableAdapter = New LibrarySystem.LibraryDBTableAdapters.shelfTableAdapter()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnAddNote = New System.Windows.Forms.Button()
        Accession_IDLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        ISBNLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        SectionLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        EditionLabel = New System.Windows.Forms.Label()
        Shelf_IDLabel = New System.Windows.Forms.Label()
        AvailableLabel = New System.Windows.Forms.Label()
        btnExit = New System.Windows.Forms.Button()
        btnBack = New System.Windows.Forms.Button()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDetails.SuspendLayout()
        CType(Me.gridAscnID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookascnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDetails2.SuspendLayout()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShelfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Accession_IDLabel
        '
        Accession_IDLabel.AutoSize = True
        Accession_IDLabel.BackColor = System.Drawing.Color.Transparent
        Accession_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Accession_IDLabel.Location = New System.Drawing.Point(12, 226)
        Accession_IDLabel.Name = "Accession_IDLabel"
        Accession_IDLabel.Size = New System.Drawing.Size(118, 18)
        Accession_IDLabel.TabIndex = 2
        Accession_IDLabel.Text = "No. of Copies:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.BackColor = System.Drawing.Color.Transparent
        TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleLabel.Location = New System.Drawing.Point(12, 9)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(45, 18)
        TitleLabel.TabIndex = 4
        TitleLabel.Text = "Title:"
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.BackColor = System.Drawing.Color.Transparent
        ISBNLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ISBNLabel.Location = New System.Drawing.Point(12, 36)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(51, 18)
        ISBNLabel.TabIndex = 6
        ISBNLabel.Text = "ISBN:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.BackColor = System.Drawing.Color.Transparent
        PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PriceLabel.Location = New System.Drawing.Point(12, 63)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(52, 18)
        PriceLabel.TabIndex = 8
        PriceLabel.Text = "Price:"
        '
        'SectionLabel
        '
        SectionLabel.AutoSize = True
        SectionLabel.BackColor = System.Drawing.Color.Transparent
        SectionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SectionLabel.Location = New System.Drawing.Point(12, 90)
        SectionLabel.Name = "SectionLabel"
        SectionLabel.Size = New System.Drawing.Size(70, 18)
        SectionLabel.TabIndex = 10
        SectionLabel.Text = "Section:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.BackColor = System.Drawing.Color.Transparent
        AuthorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AuthorLabel.Location = New System.Drawing.Point(12, 144)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(62, 18)
        AuthorLabel.TabIndex = 12
        AuthorLabel.Text = "Author:"
        '
        'EditionLabel
        '
        EditionLabel.AutoSize = True
        EditionLabel.BackColor = System.Drawing.Color.Transparent
        EditionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EditionLabel.Location = New System.Drawing.Point(12, 171)
        EditionLabel.Name = "EditionLabel"
        EditionLabel.Size = New System.Drawing.Size(65, 18)
        EditionLabel.TabIndex = 14
        EditionLabel.Text = "Edition:"
        '
        'Shelf_IDLabel
        '
        Shelf_IDLabel.AutoSize = True
        Shelf_IDLabel.BackColor = System.Drawing.Color.Transparent
        Shelf_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Shelf_IDLabel.Location = New System.Drawing.Point(12, 117)
        Shelf_IDLabel.Name = "Shelf_IDLabel"
        Shelf_IDLabel.Size = New System.Drawing.Size(72, 18)
        Shelf_IDLabel.TabIndex = 16
        Shelf_IDLabel.Text = "Shelf ID:"
        '
        'AvailableLabel
        '
        AvailableLabel.AutoSize = True
        AvailableLabel.BackColor = System.Drawing.Color.Transparent
        AvailableLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AvailableLabel.Location = New System.Drawing.Point(12, 198)
        AvailableLabel.Name = "AvailableLabel"
        AvailableLabel.Size = New System.Drawing.Size(79, 18)
        AvailableLabel.TabIndex = 18
        AvailableLabel.Text = "Available:"
        '
        'btnExit
        '
        btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnExit.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.close
        btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnExit.Location = New System.Drawing.Point(1011, 7)
        btnExit.Name = "btnExit"
        btnExit.Size = New System.Drawing.Size(38, 37)
        btnExit.TabIndex = 58
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
        btnBack.Location = New System.Drawing.Point(967, 7)
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
        Me.Title1.Location = New System.Drawing.Point(105, 7)
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
        Me.Title2.Location = New System.Drawing.Point(111, 65)
        Me.Title2.Name = "Title2"
        Me.Title2.Size = New System.Drawing.Size(734, 27)
        Me.Title2.TabIndex = 8
        Me.Title2.Text = "Sri Lanka Institute Of Advanced Technological Education"
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.Image = Global.LibrarySystem.My.Resources.Resources.SliateLogo
        Me.pbxLogo.Location = New System.Drawing.Point(6, 7)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(93, 86)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 7
        Me.pbxLogo.TabStop = False
        '
        'pnlDetails
        '
        Me.pnlDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDetails.Controls.Add(Me.gridAscnID)
        Me.pnlDetails.Controls.Add(Me.pbxAvailable)
        Me.pnlDetails.Controls.Add(AvailableLabel)
        Me.pnlDetails.Controls.Add(TitleLabel)
        Me.pnlDetails.Controls.Add(ISBNLabel)
        Me.pnlDetails.Controls.Add(Accession_IDLabel)
        Me.pnlDetails.Controls.Add(PriceLabel)
        Me.pnlDetails.Controls.Add(SectionLabel)
        Me.pnlDetails.Controls.Add(AuthorLabel)
        Me.pnlDetails.Controls.Add(EditionLabel)
        Me.pnlDetails.Controls.Add(Shelf_IDLabel)
        Me.pnlDetails.Controls.Add(Me.pnlDetails2)
        Me.pnlDetails.HorizontalScrollbarBarColor = True
        Me.pnlDetails.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlDetails.HorizontalScrollbarSize = 10
        Me.pnlDetails.Location = New System.Drawing.Point(23, 180)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(338, 462)
        Me.pnlDetails.Style = MetroFramework.MetroColorStyle.Teal
        Me.pnlDetails.TabIndex = 4
        Me.pnlDetails.UseCustomBackColor = True
        Me.pnlDetails.VerticalScrollbarBarColor = True
        Me.pnlDetails.VerticalScrollbarHighlightOnWheel = False
        Me.pnlDetails.VerticalScrollbarSize = 10
        '
        'gridAscnID
        '
        Me.gridAscnID.AllowUserToResizeRows = False
        Me.gridAscnID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridAscnID.AutoGenerateColumns = False
        Me.gridAscnID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridAscnID.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridAscnID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridAscnID.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gridAscnID.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(157, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridAscnID.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridAscnID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAscnID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn9})
        Me.gridAscnID.DataSource = Me.BookascnBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(157, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridAscnID.DefaultCellStyle = DataGridViewCellStyle2
        Me.gridAscnID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.gridAscnID.EnableHeadersVisualStyles = False
        Me.gridAscnID.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.gridAscnID.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridAscnID.Location = New System.Drawing.Point(15, 253)
        Me.gridAscnID.MultiSelect = False
        Me.gridAscnID.Name = "gridAscnID"
        Me.gridAscnID.ReadOnly = True
        Me.gridAscnID.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(157, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridAscnID.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gridAscnID.RowHeadersVisible = False
        Me.gridAscnID.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gridAscnID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridAscnID.Size = New System.Drawing.Size(315, 134)
        Me.gridAscnID.Style = MetroFramework.MetroColorStyle.Magenta
        Me.gridAscnID.TabIndex = 20
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Issued"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Issued"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Asseccion_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Asseccion_ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'BookascnBindingSource
        '
        Me.BookascnBindingSource.DataMember = "book_ascn"
        Me.BookascnBindingSource.DataSource = Me.LibraryDB1
        '
        'LibraryDB1
        '
        Me.LibraryDB1.DataSetName = "LibraryDB"
        Me.LibraryDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pbxAvailable
        '
        Me.pbxAvailable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxAvailable.Location = New System.Drawing.Point(15, 393)
        Me.pbxAvailable.Name = "pbxAvailable"
        Me.pbxAvailable.Size = New System.Drawing.Size(315, 61)
        Me.pbxAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxAvailable.TabIndex = 9
        Me.pbxAvailable.TabStop = False
        '
        'pnlDetails2
        '
        Me.pnlDetails2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDetails2.Controls.Add(Me.txtCopies)
        Me.pnlDetails2.Controls.Add(Me.txtEdition)
        Me.pnlDetails2.Controls.Add(Me.cmbSection)
        Me.pnlDetails2.Controls.Add(Me.txtAuthor)
        Me.pnlDetails2.Controls.Add(Me.cmbShelf)
        Me.pnlDetails2.Controls.Add(Me.txtPrice)
        Me.pnlDetails2.Controls.Add(Me.txtISBN)
        Me.pnlDetails2.Controls.Add(Me.chkAvailable)
        Me.pnlDetails2.Controls.Add(Me.txtTitle)
        Me.pnlDetails2.Enabled = False
        Me.pnlDetails2.Location = New System.Drawing.Point(130, 3)
        Me.pnlDetails2.Name = "pnlDetails2"
        Me.pnlDetails2.Size = New System.Drawing.Size(203, 454)
        Me.pnlDetails2.TabIndex = 19
        '
        'txtCopies
        '
        Me.txtCopies.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCopies.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Copies", True))
        Me.txtCopies.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopies.Location = New System.Drawing.Point(3, 220)
        Me.txtCopies.Name = "txtCopies"
        Me.txtCopies.Size = New System.Drawing.Size(188, 24)
        Me.txtCopies.TabIndex = 0
        '
        'BookBindingSource
        '
        Me.BookBindingSource.DataMember = "book"
        Me.BookBindingSource.DataSource = Me.LibraryDB1
        '
        'txtEdition
        '
        Me.txtEdition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEdition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Edition", True))
        Me.txtEdition.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdition.Location = New System.Drawing.Point(3, 169)
        Me.txtEdition.Name = "txtEdition"
        Me.txtEdition.Size = New System.Drawing.Size(188, 24)
        Me.txtEdition.TabIndex = 7
        '
        'cmbSection
        '
        Me.cmbSection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSection.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Section", True))
        Me.cmbSection.DisplayMember = "Section"
        Me.cmbSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Items.AddRange(New Object() {"Lendings", "Reference"})
        Me.cmbSection.Location = New System.Drawing.Point(3, 84)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(188, 26)
        Me.cmbSection.TabIndex = 4
        Me.cmbSection.Text = "Lendings"
        Me.cmbSection.ValueMember = "Section"
        '
        'txtAuthor
        '
        Me.txtAuthor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAuthor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Author", True))
        Me.txtAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(3, 142)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(188, 24)
        Me.txtAuthor.TabIndex = 6
        '
        'cmbShelf
        '
        Me.cmbShelf.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbShelf.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Shelf_ID", True))
        Me.cmbShelf.DataSource = Me.ShelfBindingSource
        Me.cmbShelf.DisplayMember = "Shelf_ID"
        Me.cmbShelf.DropDownWidth = 400
        Me.cmbShelf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmbShelf.FormattingEnabled = True
        Me.cmbShelf.Location = New System.Drawing.Point(3, 113)
        Me.cmbShelf.Name = "cmbShelf"
        Me.cmbShelf.Size = New System.Drawing.Size(188, 26)
        Me.cmbShelf.TabIndex = 5
        Me.cmbShelf.ValueMember = "Shelf_ID"
        '
        'ShelfBindingSource
        '
        Me.ShelfBindingSource.DataMember = "shelf"
        Me.ShelfBindingSource.DataSource = Me.LibraryDB1
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Price", True))
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(3, 57)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(188, 24)
        Me.txtPrice.TabIndex = 3
        '
        'txtISBN
        '
        Me.txtISBN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtISBN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "ISBN", True))
        Me.txtISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.Location = New System.Drawing.Point(3, 30)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(188, 24)
        Me.txtISBN.TabIndex = 2
        '
        'chkAvailable
        '
        Me.chkAvailable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAvailable.BackColor = System.Drawing.Color.Transparent
        Me.chkAvailable.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BookBindingSource, "Available", True))
        Me.chkAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAvailable.Location = New System.Drawing.Point(3, 193)
        Me.chkAvailable.Name = "chkAvailable"
        Me.chkAvailable.Size = New System.Drawing.Size(188, 24)
        Me.chkAvailable.TabIndex = 8
        Me.chkAvailable.UseVisualStyleBackColor = False
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Title", True))
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(3, 3)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(188, 24)
        Me.txtTitle.TabIndex = 1
        '
        'txtBookSearch
        '
        Me.txtBookSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBookSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBookSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookSearch.Location = New System.Drawing.Point(581, 126)
        Me.txtBookSearch.Name = "txtBookSearch"
        Me.txtBookSearch.Size = New System.Drawing.Size(451, 26)
        Me.txtBookSearch.TabIndex = 3
        Me.txtBookSearch.Text = "Search Here"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnUpdate.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Navy
        Me.btnUpdate.Location = New System.Drawing.Point(182, 126)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(143, 29)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update Details"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnNewBook
        '
        Me.btnNewBook.BackColor = System.Drawing.Color.Transparent
        Me.btnNewBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewBook.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNewBook.FlatAppearance.BorderSize = 0
        Me.btnNewBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnNewBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnNewBook.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewBook.ForeColor = System.Drawing.Color.Navy
        Me.btnNewBook.Location = New System.Drawing.Point(24, 126)
        Me.btnNewBook.Name = "btnNewBook"
        Me.btnNewBook.Size = New System.Drawing.Size(143, 29)
        Me.btnNewBook.TabIndex = 0
        Me.btnNewBook.Text = "Add New Book"
        Me.btnNewBook.UseVisualStyleBackColor = False
        '
        'cmbDataField
        '
        Me.cmbDataField.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDataField.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbDataField.ForeColor = System.Drawing.SystemColors.InfoText
        Me.cmbDataField.FormattingEnabled = True
        Me.cmbDataField.Items.AddRange(New Object() {"Accession ID", "Author", "ISBN", "Title"})
        Me.cmbDataField.Location = New System.Drawing.Point(428, 126)
        Me.cmbDataField.Name = "cmbDataField"
        Me.cmbDataField.Size = New System.Drawing.Size(147, 28)
        Me.cmbDataField.TabIndex = 2
        Me.cmbDataField.Text = "Title"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.Search
        Me.PictureBox1.Location = New System.Drawing.Point(367, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'gridBooks
        '
        Me.gridBooks.AllowUserToResizeRows = False
        Me.gridBooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridBooks.AutoGenerateColumns = False
        Me.gridBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridBooks.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridBooks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gridBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.gridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn8})
        Me.gridBooks.DataSource = Me.BookBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridBooks.DefaultCellStyle = DataGridViewCellStyle5
        Me.gridBooks.EnableHeadersVisualStyles = False
        Me.gridBooks.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.gridBooks.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridBooks.Location = New System.Drawing.Point(367, 180)
        Me.gridBooks.Name = "gridBooks"
        Me.gridBooks.ReadOnly = True
        Me.gridBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridBooks.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.gridBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gridBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridBooks.Size = New System.Drawing.Size(665, 397)
        Me.gridBooks.TabIndex = 59
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ISBN"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ISBN"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Section"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Section"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Author"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Author"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Edition"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Edition"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Shelf_ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Shelf_ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Available"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Available"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Copies"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Copies"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'BookTableAdapter1
        '
        Me.BookTableAdapter1.ClearBeforeFill = True
        '
        'Book_ascnTableAdapter1
        '
        Me.Book_ascnTableAdapter1.ClearBeforeFill = True
        '
        'ShelfTableAdapter
        '
        Me.ShelfTableAdapter.ClearBeforeFill = True
        '
        'txtNotes
        '
        Me.txtNotes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNotes.Location = New System.Drawing.Point(367, 583)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(665, 59)
        Me.txtNotes.TabIndex = 60
        Me.txtNotes.Text = "Add a note......"
        '
        'btnAddNote
        '
        Me.btnAddNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddNote.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNote.Location = New System.Drawing.Point(956, 616)
        Me.btnAddNote.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddNote.Name = "btnAddNote"
        Me.btnAddNote.Size = New System.Drawing.Size(75, 25)
        Me.btnAddNote.TabIndex = 61
        Me.btnAddNote.Text = "Save"
        Me.btnAddNote.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddNote.UseVisualStyleBackColor = False
        '
        'frmBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 665)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAddNote)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.gridBooks)
        Me.Controls.Add(btnExit)
        Me.Controls.Add(btnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmbDataField)
        Me.Controls.Add(Me.pnlDetails)
        Me.Controls.Add(Me.txtBookSearch)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNewBook)
        Me.Controls.Add(Me.Title1)
        Me.Controls.Add(Me.Title2)
        Me.Controls.Add(Me.pbxLogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBooks"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        CType(Me.gridAscnID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookascnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDetails2.ResumeLayout(False)
        Me.pnlDetails2.PerformLayout()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShelfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title1 As System.Windows.Forms.Label
    Friend WithEvents Title2 As System.Windows.Forms.Label
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents pnlDetails As MetroFramework.Controls.MetroPanel
    Friend WithEvents txtBookSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnNewBook As System.Windows.Forms.Button
    Friend WithEvents txtCopies As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtEdition As System.Windows.Forms.TextBox
    Friend WithEvents chkAvailable As System.Windows.Forms.CheckBox
    Friend WithEvents cmbDataField As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbSection As System.Windows.Forms.ComboBox
    Friend WithEvents cmbShelf As System.Windows.Forms.ComboBox
    Friend WithEvents pnlDetails2 As System.Windows.Forms.Panel
    Friend WithEvents pbxAvailable As System.Windows.Forms.PictureBox
    Friend WithEvents gridBooks As MetroFramework.Controls.MetroGrid
    Friend WithEvents LibraryDB As LibrarySystem.LibraryDB
    Friend WithEvents BookTableAdapter As LibrarySystem.LibraryDBTableAdapters.bookTableAdapter
    Friend WithEvents ISBNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SectionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EditionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShelfIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailableDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CopiesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Book_ascnTableAdapter As LibrarySystem.LibraryDBTableAdapters.book_ascnTableAdapter
    Friend WithEvents gridAscnID As MetroFramework.Controls.MetroGrid
    Friend WithEvents IssuedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AsseccionIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibraryDB1 As LibrarySystem.LibraryDB
    Friend WithEvents BookBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookTableAdapter1 As LibrarySystem.LibraryDBTableAdapters.bookTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookascnBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Book_ascnTableAdapter1 As LibrarySystem.LibraryDBTableAdapters.book_ascnTableAdapter
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShelfBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ShelfTableAdapter As LibrarySystem.LibraryDBTableAdapters.shelfTableAdapter
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents btnAddNote As System.Windows.Forms.Button
End Class
