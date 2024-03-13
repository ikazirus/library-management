<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewBatch
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
        Me.txtMemNum = New System.Windows.Forms.TextBox()
        Me.cbxDep = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibrarydbDataSet = New LibrarySystem.LibraryDB()
        Me.cbxYear = New System.Windows.Forms.ComboBox()
        Me.YearBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rbtFullT = New System.Windows.Forms.RadioButton()
        Me.rbtPart = New System.Windows.Forms.RadioButton()
        Me.btnCancelNBW = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DepartmentTableAdapter = New LibrarySystem.LibraryDBTableAdapters.departmentTableAdapter()
        Me.YearTableAdapter = New LibrarySystem.LibraryDBTableAdapters.yearTableAdapter()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrarydbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YearBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMemNum
        '
        Me.txtMemNum.BackColor = System.Drawing.Color.White
        Me.txtMemNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemNum.Location = New System.Drawing.Point(403, 188)
        Me.txtMemNum.Name = "txtMemNum"
        Me.txtMemNum.Size = New System.Drawing.Size(186, 22)
        Me.txtMemNum.TabIndex = 16
        '
        'cbxDep
        '
        Me.cbxDep.BackColor = System.Drawing.Color.White
        Me.cbxDep.DataSource = Me.DepartmentBindingSource
        Me.cbxDep.DisplayMember = "DepName"
        Me.cbxDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDep.FormattingEnabled = True
        Me.cbxDep.Location = New System.Drawing.Point(403, 77)
        Me.cbxDep.Name = "cbxDep"
        Me.cbxDep.Size = New System.Drawing.Size(372, 24)
        Me.cbxDep.TabIndex = 7
        Me.cbxDep.ValueMember = "DepID"
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "department"
        Me.DepartmentBindingSource.DataSource = Me.LibrarydbDataSet
        '
        'LibrarydbDataSet
        '
        Me.LibrarydbDataSet.DataSetName = "librarydbDataSet"
        Me.LibrarydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbxYear
        '
        Me.cbxYear.BackColor = System.Drawing.Color.White
        Me.cbxYear.DataSource = Me.YearBindingSource
        Me.cbxYear.DisplayMember = "Year"
        Me.cbxYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxYear.FormattingEnabled = True
        Me.cbxYear.Location = New System.Drawing.Point(403, 114)
        Me.cbxYear.Name = "cbxYear"
        Me.cbxYear.Size = New System.Drawing.Size(186, 24)
        Me.cbxYear.TabIndex = 12
        Me.cbxYear.ValueMember = "Year"
        '
        'YearBindingSource
        '
        Me.YearBindingSource.DataMember = "year"
        Me.YearBindingSource.DataSource = Me.LibrarydbDataSet
        '
        'rbtFullT
        '
        Me.rbtFullT.AutoSize = True
        Me.rbtFullT.Checked = True
        Me.rbtFullT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFullT.ForeColor = System.Drawing.Color.Black
        Me.rbtFullT.Location = New System.Drawing.Point(403, 152)
        Me.rbtFullT.Name = "rbtFullT"
        Me.rbtFullT.Size = New System.Drawing.Size(81, 20)
        Me.rbtFullT.TabIndex = 13
        Me.rbtFullT.TabStop = True
        Me.rbtFullT.Text = "Full Time"
        Me.rbtFullT.UseVisualStyleBackColor = True
        '
        'rbtPart
        '
        Me.rbtPart.AutoSize = True
        Me.rbtPart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtPart.ForeColor = System.Drawing.Color.Black
        Me.rbtPart.Location = New System.Drawing.Point(505, 152)
        Me.rbtPart.Name = "rbtPart"
        Me.rbtPart.Size = New System.Drawing.Size(84, 20)
        Me.rbtPart.TabIndex = 15
        Me.rbtPart.Text = "Part Time"
        Me.rbtPart.UseVisualStyleBackColor = True
        '
        'btnCancelNBW
        '
        Me.btnCancelNBW.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelNBW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelNBW.Location = New System.Drawing.Point(663, 230)
        Me.btnCancelNBW.Name = "btnCancelNBW"
        Me.btnCancelNBW.Size = New System.Drawing.Size(112, 23)
        Me.btnCancelNBW.TabIndex = 18
        Me.btnCancelNBW.Text = "Cancel"
        Me.btnCancelNBW.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(545, 230)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(112, 23)
        Me.btnNext.TabIndex = 17
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(179, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Number of Students :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(179, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Course Type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(179, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Year :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(179, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Department :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.Membership
        Me.PictureBox1.Location = New System.Drawing.Point(23, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'YearTableAdapter
        '
        Me.YearTableAdapter.ClearBeforeFill = True
        '
        'frmNewBatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 284)
        Me.Controls.Add(Me.txtMemNum)
        Me.Controls.Add(Me.cbxDep)
        Me.Controls.Add(Me.cbxYear)
        Me.Controls.Add(Me.rbtFullT)
        Me.Controls.Add(Me.rbtPart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancelNBW)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmNewBatch"
        Me.Text = "NEW BATCH WIZARD"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.TopMost = True
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrarydbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YearBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMemNum As System.Windows.Forms.TextBox
    Friend WithEvents cbxDep As System.Windows.Forms.ComboBox
    Friend WithEvents cbxYear As System.Windows.Forms.ComboBox
    Friend WithEvents rbtFullT As System.Windows.Forms.RadioButton
    Friend WithEvents rbtPart As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancelNBW As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LibrarydbDataSet As LibrarySystem.LibraryDB
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As LibrarySystem.LibraryDBTableAdapters.departmentTableAdapter
    Friend WithEvents YearBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YearTableAdapter As LibrarySystem.LibraryDBTableAdapters.yearTableAdapter
   
End Class
