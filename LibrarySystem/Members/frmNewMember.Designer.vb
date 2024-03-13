<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewMember
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
        Me.pb1 = New MetroFramework.Controls.MetroProgressBar()
        Me.btnClearMember = New System.Windows.Forms.Button()
        Me.btnAddMem = New System.Windows.Forms.Button()
        Me.rbnMale = New System.Windows.Forms.RadioButton()
        Me.rbnFemale = New System.Windows.Forms.RadioButton()
        Me.txtAdmNo = New System.Windows.Forms.TextBox()
        Me.txtTP = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtNIC = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMemID = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pb1
        '
        Me.pb1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb1.Location = New System.Drawing.Point(-4, 63)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(886, 10)
        Me.pb1.Step = 1
        Me.pb1.Style = MetroFramework.MetroColorStyle.Green
        Me.pb1.TabIndex = 29
        '
        'btnClearMember
        '
        Me.btnClearMember.AutoSize = True
        Me.btnClearMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearMember.Location = New System.Drawing.Point(706, 306)
        Me.btnClearMember.Name = "btnClearMember"
        Me.btnClearMember.Size = New System.Drawing.Size(120, 30)
        Me.btnClearMember.TabIndex = 28
        Me.btnClearMember.Text = "Clear"
        Me.btnClearMember.UseVisualStyleBackColor = True
        '
        'btnAddMem
        '
        Me.btnAddMem.AutoSize = True
        Me.btnAddMem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMem.Location = New System.Drawing.Point(580, 306)
        Me.btnAddMem.Name = "btnAddMem"
        Me.btnAddMem.Size = New System.Drawing.Size(120, 30)
        Me.btnAddMem.TabIndex = 27
        Me.btnAddMem.Text = "Next"
        Me.btnAddMem.UseVisualStyleBackColor = True
        '
        'rbnMale
        '
        Me.rbnMale.AutoSize = True
        Me.rbnMale.Checked = True
        Me.rbnMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnMale.ForeColor = System.Drawing.Color.Black
        Me.rbnMale.Location = New System.Drawing.Point(636, 216)
        Me.rbnMale.Name = "rbnMale"
        Me.rbnMale.Size = New System.Drawing.Size(56, 20)
        Me.rbnMale.TabIndex = 25
        Me.rbnMale.TabStop = True
        Me.rbnMale.Text = "Male"
        Me.rbnMale.UseVisualStyleBackColor = True
        '
        'rbnFemale
        '
        Me.rbnFemale.AutoSize = True
        Me.rbnFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnFemale.ForeColor = System.Drawing.Color.Black
        Me.rbnFemale.Location = New System.Drawing.Point(725, 216)
        Me.rbnFemale.Name = "rbnFemale"
        Me.rbnFemale.Size = New System.Drawing.Size(72, 20)
        Me.rbnFemale.TabIndex = 26
        Me.rbnFemale.Text = "Female"
        Me.rbnFemale.UseVisualStyleBackColor = True
        '
        'txtAdmNo
        '
        Me.txtAdmNo.BackColor = System.Drawing.Color.White
        Me.txtAdmNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdmNo.Location = New System.Drawing.Point(636, 171)
        Me.txtAdmNo.Name = "txtAdmNo"
        Me.txtAdmNo.Size = New System.Drawing.Size(190, 22)
        Me.txtAdmNo.TabIndex = 23
        '
        'txtTP
        '
        Me.txtTP.BackColor = System.Drawing.Color.White
        Me.txtTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTP.Location = New System.Drawing.Point(636, 130)
        Me.txtTP.Name = "txtTP"
        Me.txtTP.Size = New System.Drawing.Size(190, 22)
        Me.txtTP.TabIndex = 22
        '
        'txtLName
        '
        Me.txtLName.BackColor = System.Drawing.Color.White
        Me.txtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(157, 130)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(236, 22)
        Me.txtLName.TabIndex = 14
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(157, 171)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(236, 65)
        Me.txtAddress.TabIndex = 18
        '
        'txtNIC
        '
        Me.txtNIC.BackColor = System.Drawing.Color.White
        Me.txtNIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIC.Location = New System.Drawing.Point(636, 89)
        Me.txtNIC.Name = "txtNIC"
        Me.txtNIC.Size = New System.Drawing.Size(176, 22)
        Me.txtNIC.TabIndex = 20
        '
        'txtFName
        '
        Me.txtFName.BackColor = System.Drawing.Color.White
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(157, 89)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(236, 22)
        Me.txtFName.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(425, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Gender :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(425, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Admission Number :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Address :"
        '
        'lblMemID
        '
        Me.lblMemID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMemID.Font = New System.Drawing.Font("IDAHC39M Code 39 Barcode", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblMemID.ForeColor = System.Drawing.Color.Blue
        Me.lblMemID.Location = New System.Drawing.Point(157, 264)
        Me.lblMemID.Name = "lblMemID"
        Me.lblMemID.Size = New System.Drawing.Size(335, 97)
        Me.lblMemID.TabIndex = 17
        Me.lblMemID.Text = "Membership ID"
        Me.lblMemID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(425, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "NIC Number :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(425, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Telephone Number :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Last Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "First Name :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(11, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 18)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "MEMBERSHIP ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(815, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 16)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "V"
        '
        'frmNewMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 381)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.btnClearMember)
        Me.Controls.Add(Me.btnAddMem)
        Me.Controls.Add(Me.rbnMale)
        Me.Controls.Add(Me.rbnFemale)
        Me.Controls.Add(Me.txtAdmNo)
        Me.Controls.Add(Me.txtTP)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtNIC)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblMemID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmNewMember"
        Me.Text = "MEMBER : 1"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb1 As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents btnClearMember As System.Windows.Forms.Button
    Friend WithEvents btnAddMem As System.Windows.Forms.Button
    Friend WithEvents rbnMale As System.Windows.Forms.RadioButton
    Friend WithEvents rbnFemale As System.Windows.Forms.RadioButton
    Friend WithEvents txtAdmNo As System.Windows.Forms.TextBox
    Friend WithEvents txtTP As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtNIC As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMemID As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
