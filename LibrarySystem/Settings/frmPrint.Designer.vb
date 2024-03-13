<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrint
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
        Me.btnPrintBookID = New System.Windows.Forms.Button()
        Me.crv1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.printBCMEM1 = New LibrarySystem.printBCMEM()
        Me.cmbTo = New System.Windows.Forms.ComboBox()
        Me.BookascnBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDB = New LibrarySystem.LibraryDB()
        Me.cmbFrom = New System.Windows.Forms.ComboBox()
        Me.BookascnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtc1 = New MetroFramework.Controls.MetroTabControl()
        Me.tabMemID = New MetroFramework.Controls.MetroTabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbFromM = New System.Windows.Forms.ComboBox()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbToM = New System.Windows.Forms.ComboBox()
        Me.StudentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnPrintMemID = New System.Windows.Forms.Button()
        Me.crv2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.tabBookID = New MetroFramework.Controls.MetroTabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PatronBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New LibrarySystem.LibraryDBTableAdapters.studentTableAdapter()
        Me.Book_ascnTableAdapter = New LibrarySystem.LibraryDBTableAdapters.book_ascnTableAdapter()
        Me.PatronTableAdapter = New LibrarySystem.LibraryDBTableAdapters.patronTableAdapter()
        btnExit = New System.Windows.Forms.Button()
        btnBack = New System.Windows.Forms.Button()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookascnBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookascnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mtc1.SuspendLayout()
        Me.tabMemID.SuspendLayout()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBookID.SuspendLayout()
        CType(Me.PatronBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnPrintBookID
        '
        Me.btnPrintBookID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrintBookID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintBookID.ForeColor = System.Drawing.Color.Black
        Me.btnPrintBookID.Location = New System.Drawing.Point(481, 104)
        Me.btnPrintBookID.Name = "btnPrintBookID"
        Me.btnPrintBookID.Size = New System.Drawing.Size(104, 25)
        Me.btnPrintBookID.TabIndex = 62
        Me.btnPrintBookID.Text = "SHOW"
        Me.btnPrintBookID.UseVisualStyleBackColor = False
        '
        'crv1
        '
        Me.crv1.ActiveViewIndex = -1
        Me.crv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv1.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crv1.Location = New System.Drawing.Point(0, 153)
        Me.crv1.Name = "crv1"
        Me.crv1.ReuseParameterValuesOnRefresh = True
        Me.crv1.ShowCloseButton = False
        Me.crv1.ShowCopyButton = False
        Me.crv1.ShowGroupTreeButton = False
        Me.crv1.ShowLogo = False
        Me.crv1.ShowParameterPanelButton = False
        Me.crv1.Size = New System.Drawing.Size(959, 279)
        Me.crv1.TabIndex = 63
        Me.crv1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'cmbTo
        '
        Me.cmbTo.DataSource = Me.BookascnBindingSource1
        Me.cmbTo.DisplayMember = "Asseccion_ID"
        Me.cmbTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTo.FormattingEnabled = True
        Me.cmbTo.Location = New System.Drawing.Point(295, 104)
        Me.cmbTo.Name = "cmbTo"
        Me.cmbTo.Size = New System.Drawing.Size(163, 24)
        Me.cmbTo.TabIndex = 64
        Me.cmbTo.ValueMember = "Asseccion_ID"
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
        'cmbFrom
        '
        Me.cmbFrom.DataSource = Me.BookascnBindingSource
        Me.cmbFrom.DisplayMember = "Asseccion_ID"
        Me.cmbFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFrom.FormattingEnabled = True
        Me.cmbFrom.Location = New System.Drawing.Point(73, 104)
        Me.cmbFrom.Name = "cmbFrom"
        Me.cmbFrom.Size = New System.Drawing.Size(163, 24)
        Me.cmbFrom.TabIndex = 65
        Me.cmbFrom.ValueMember = "Asseccion_ID"
        '
        'BookascnBindingSource
        '
        Me.BookascnBindingSource.DataMember = "book_ascn"
        Me.BookascnBindingSource.DataSource = Me.LibraryDB
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(16, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "From :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(254, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 16)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "To :"
        '
        'mtc1
        '
        Me.mtc1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtc1.Controls.Add(Me.tabMemID)
        Me.mtc1.Controls.Add(Me.tabBookID)
        Me.mtc1.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.mtc1.FontWeight = MetroFramework.MetroTabControlWeight.Regular
        Me.mtc1.HotTrack = True
        Me.mtc1.Location = New System.Drawing.Point(23, 100)
        Me.mtc1.Name = "mtc1"
        Me.mtc1.SelectedIndex = 0
        Me.mtc1.Size = New System.Drawing.Size(967, 480)
        Me.mtc1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.mtc1.TabIndex = 0
        Me.mtc1.UseSelectable = True
        '
        'tabMemID
        '
        Me.tabMemID.BackColor = System.Drawing.Color.White
        Me.tabMemID.Controls.Add(Me.Label8)
        Me.tabMemID.Controls.Add(Me.Label4)
        Me.tabMemID.Controls.Add(Me.Label5)
        Me.tabMemID.Controls.Add(Me.cmbFromM)
        Me.tabMemID.Controls.Add(Me.cmbToM)
        Me.tabMemID.Controls.Add(Me.Label6)
        Me.tabMemID.Controls.Add(Me.btnPrintMemID)
        Me.tabMemID.Controls.Add(Me.crv2)
        Me.tabMemID.HorizontalScrollbarBarColor = True
        Me.tabMemID.HorizontalScrollbarHighlightOnWheel = False
        Me.tabMemID.HorizontalScrollbarSize = 10
        Me.tabMemID.Location = New System.Drawing.Point(4, 44)
        Me.tabMemID.Name = "tabMemID"
        Me.tabMemID.Size = New System.Drawing.Size(959, 432)
        Me.tabMemID.TabIndex = 1
        Me.tabMemID.Text = "Print Membership IDs"
        Me.tabMemID.VerticalScrollbarBarColor = True
        Me.tabMemID.VerticalScrollbarHighlightOnWheel = False
        Me.tabMemID.VerticalScrollbarSize = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(3, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(299, 29)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "PRINT MEMBERSHIP IDs."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(16, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(754, 16)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "To print IDs / Lables , please select the range (From  and To). You can generate " & _
    "IDs/Lables and print it for the easy recognition."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(254, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 16)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "To :"
        '
        'cmbFromM
        '
        Me.cmbFromM.DataSource = Me.StudentBindingSource
        Me.cmbFromM.DisplayMember = "StudentID"
        Me.cmbFromM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFromM.FormattingEnabled = True
        Me.cmbFromM.Location = New System.Drawing.Point(73, 104)
        Me.cmbFromM.Name = "cmbFromM"
        Me.cmbFromM.Size = New System.Drawing.Size(163, 24)
        Me.cmbFromM.TabIndex = 0
        Me.cmbFromM.ValueMember = "StudentID"
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "student"
        Me.StudentBindingSource.DataSource = Me.LibraryDB
        '
        'cmbToM
        '
        Me.cmbToM.DataSource = Me.StudentBindingSource1
        Me.cmbToM.DisplayMember = "StudentID"
        Me.cmbToM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbToM.FormattingEnabled = True
        Me.cmbToM.Location = New System.Drawing.Point(295, 104)
        Me.cmbToM.Name = "cmbToM"
        Me.cmbToM.Size = New System.Drawing.Size(163, 24)
        Me.cmbToM.TabIndex = 1
        Me.cmbToM.ValueMember = "StudentID"
        '
        'StudentBindingSource1
        '
        Me.StudentBindingSource1.DataMember = "student"
        Me.StudentBindingSource1.DataSource = Me.LibraryDB
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(16, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "From :"
        '
        'btnPrintMemID
        '
        Me.btnPrintMemID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrintMemID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintMemID.ForeColor = System.Drawing.Color.Black
        Me.btnPrintMemID.Location = New System.Drawing.Point(481, 104)
        Me.btnPrintMemID.Name = "btnPrintMemID"
        Me.btnPrintMemID.Size = New System.Drawing.Size(104, 25)
        Me.btnPrintMemID.TabIndex = 2
        Me.btnPrintMemID.Text = "SHOW"
        Me.btnPrintMemID.UseVisualStyleBackColor = False
        '
        'crv2
        '
        Me.crv2.ActiveViewIndex = -1
        Me.crv2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv2.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crv2.Location = New System.Drawing.Point(0, 153)
        Me.crv2.Name = "crv2"
        Me.crv2.ReuseParameterValuesOnRefresh = True
        Me.crv2.ShowCloseButton = False
        Me.crv2.ShowCopyButton = False
        Me.crv2.ShowGroupTreeButton = False
        Me.crv2.ShowLogo = False
        Me.crv2.ShowParameterPanelButton = False
        Me.crv2.Size = New System.Drawing.Size(959, 279)
        Me.crv2.TabIndex = 63
        Me.crv2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'tabBookID
        '
        Me.tabBookID.BackColor = System.Drawing.Color.White
        Me.tabBookID.Controls.Add(Me.Label7)
        Me.tabBookID.Controls.Add(Me.Label3)
        Me.tabBookID.Controls.Add(Me.Label2)
        Me.tabBookID.Controls.Add(Me.cmbFrom)
        Me.tabBookID.Controls.Add(Me.cmbTo)
        Me.tabBookID.Controls.Add(Me.Label1)
        Me.tabBookID.Controls.Add(Me.btnPrintBookID)
        Me.tabBookID.Controls.Add(Me.crv1)
        Me.tabBookID.HorizontalScrollbarBarColor = True
        Me.tabBookID.HorizontalScrollbarHighlightOnWheel = False
        Me.tabBookID.HorizontalScrollbarSize = 10
        Me.tabBookID.Location = New System.Drawing.Point(4, 44)
        Me.tabBookID.Name = "tabBookID"
        Me.tabBookID.Size = New System.Drawing.Size(959, 432)
        Me.tabBookID.TabIndex = 0
        Me.tabBookID.Text = "Print Book Lables"
        Me.tabBookID.VerticalScrollbarBarColor = True
        Me.tabBookID.VerticalScrollbarHighlightOnWheel = False
        Me.tabBookID.VerticalScrollbarSize = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(3, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(257, 29)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "PRINT BOOK LABLES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(16, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(754, 16)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "To print IDs / Lables , please select the range (From  and To). You can generate " & _
    "IDs/Lables and print it for the easy recognition."
        '
        'PatronBindingSource
        '
        Me.PatronBindingSource.DataMember = "patron"
        Me.PatronBindingSource.DataSource = Me.LibraryDB
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
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.mtc1)
        Me.Controls.Add(btnExit)
        Me.Controls.Add(btnBack)
        Me.Controls.Add(Me.Title1)
        Me.Controls.Add(Me.Title2)
        Me.Controls.Add(Me.pbxLogo)
        Me.Name = "frmPrint"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.TransparencyKey = System.Drawing.Color.DarkViolet
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookascnBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookascnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mtc1.ResumeLayout(False)
        Me.tabMemID.ResumeLayout(False)
        Me.tabMemID.PerformLayout()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBookID.ResumeLayout(False)
        Me.tabBookID.PerformLayout()
        CType(Me.PatronBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title1 As System.Windows.Forms.Label
    Friend WithEvents Title2 As System.Windows.Forms.Label
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnPrintBookID As System.Windows.Forms.Button
    Friend WithEvents crv1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents printBCMEM1 As LibrarySystem.printBCMEM
    Friend WithEvents cmbTo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFrom As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mtc1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabBookID As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tabMemID As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbFromM As System.Windows.Forms.ComboBox
    Friend WithEvents cmbToM As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnPrintMemID As System.Windows.Forms.Button
    Friend WithEvents crv2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents LibraryDB As LibrarySystem.LibraryDB
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As LibrarySystem.LibraryDBTableAdapters.studentTableAdapter
    Friend WithEvents StudentBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BookascnBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Book_ascnTableAdapter As LibrarySystem.LibraryDBTableAdapters.book_ascnTableAdapter
    Friend WithEvents BookascnBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PatronBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PatronTableAdapter As LibrarySystem.LibraryDBTableAdapters.patronTableAdapter
End Class
