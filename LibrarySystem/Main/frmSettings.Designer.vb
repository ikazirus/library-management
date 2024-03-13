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
        Me.Title1 = New System.Windows.Forms.Label()
        Me.Title2 = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.btnHOME = New System.Windows.Forms.Button()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'btnHOME
        '
        Me.btnHOME.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHOME.BackColor = System.Drawing.Color.Transparent
        Me.btnHOME.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.blue_home_page_icon_png_16
        Me.btnHOME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHOME.FlatAppearance.BorderSize = 0
        Me.btnHOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHOME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHOME.Image = Global.LibrarySystem.My.Resources.Resources.blue_home_page_icon_png_16
        Me.btnHOME.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHOME.Location = New System.Drawing.Point(917, 7)
        Me.btnHOME.Name = "btnHOME"
        Me.btnHOME.Size = New System.Drawing.Size(83, 76)
        Me.btnHOME.TabIndex = 11
        Me.btnHOME.Text = "HOME"
        Me.btnHOME.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHOME.UseVisualStyleBackColor = False
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.btnHOME)
        Me.Controls.Add(Me.Title1)
        Me.Controls.Add(Me.Title2)
        Me.Controls.Add(Me.pbxLogo)
        Me.Name = "frmSettings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title1 As System.Windows.Forms.Label
    Friend WithEvents Title2 As System.Windows.Forms.Label
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnHOME As System.Windows.Forms.Button
End Class
