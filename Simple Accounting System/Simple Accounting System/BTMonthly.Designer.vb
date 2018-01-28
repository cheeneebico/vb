<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BTMonthly
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BTMonthly))
        Me.buttonbtmClear = New System.Windows.Forms.Button()
        Me.buttonbtmPrint = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.comboboxbtmmon = New System.Windows.Forms.ComboBox()
        Me.comboboxbtmv = New System.Windows.Forms.ComboBox()
        Me.btmtd = New System.Windows.Forms.TextBox()
        Me.btmgs = New System.Windows.Forms.TextBox()
        Me.labelbtmtd = New System.Windows.Forms.Label()
        Me.labelbtmv = New System.Windows.Forms.Label()
        Me.labelbtmgs = New System.Windows.Forms.Label()
        Me.labelbtmmon = New System.Windows.Forms.Label()
        Me.boxbtmname = New System.Windows.Forms.TextBox()
        Me.labelbtmname = New System.Windows.Forms.Label()
        Me.labelbtm = New System.Windows.Forms.Label()
        Me.labelbtyear = New System.Windows.Forms.Label()
        Me.textboxbtyear = New System.Windows.Forms.TextBox()
        Me.PrintFormBTM = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonbtmClear
        '
        Me.buttonbtmClear.BackColor = System.Drawing.Color.SeaGreen
        Me.buttonbtmClear.FlatAppearance.BorderSize = 0
        Me.buttonbtmClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonbtmClear.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonbtmClear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.buttonbtmClear.Location = New System.Drawing.Point(179, 380)
        Me.buttonbtmClear.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonbtmClear.Name = "buttonbtmClear"
        Me.buttonbtmClear.Size = New System.Drawing.Size(140, 38)
        Me.buttonbtmClear.TabIndex = 30
        Me.buttonbtmClear.Text = "Clear"
        Me.buttonbtmClear.UseVisualStyleBackColor = False
        '
        'buttonbtmPrint
        '
        Me.buttonbtmPrint.BackColor = System.Drawing.Color.SeaGreen
        Me.buttonbtmPrint.FlatAppearance.BorderSize = 0
        Me.buttonbtmPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonbtmPrint.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonbtmPrint.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.buttonbtmPrint.Location = New System.Drawing.Point(13, 380)
        Me.buttonbtmPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonbtmPrint.Name = "buttonbtmPrint"
        Me.buttonbtmPrint.Size = New System.Drawing.Size(140, 38)
        Me.buttonbtmPrint.TabIndex = 29
        Me.buttonbtmPrint.Text = "Print"
        Me.buttonbtmPrint.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(123, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(308, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "___________________________________________"
        '
        'comboboxbtmmon
        '
        Me.comboboxbtmmon.FormattingEnabled = True
        Me.comboboxbtmmon.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.comboboxbtmmon.Location = New System.Drawing.Point(246, 172)
        Me.comboboxbtmmon.Name = "comboboxbtmmon"
        Me.comboboxbtmmon.Size = New System.Drawing.Size(172, 21)
        Me.comboboxbtmmon.TabIndex = 2
        '
        'comboboxbtmv
        '
        Me.comboboxbtmv.FormattingEnabled = True
        Me.comboboxbtmv.Items.AddRange(New Object() {".12", ".3"})
        Me.comboboxbtmv.Location = New System.Drawing.Point(246, 279)
        Me.comboboxbtmv.Name = "comboboxbtmv"
        Me.comboboxbtmv.Size = New System.Drawing.Size(172, 21)
        Me.comboboxbtmv.TabIndex = 5
        '
        'btmtd
        '
        Me.btmtd.Location = New System.Drawing.Point(246, 327)
        Me.btmtd.Multiline = True
        Me.btmtd.Name = "btmtd"
        Me.btmtd.Size = New System.Drawing.Size(172, 28)
        Me.btmtd.TabIndex = 6
        '
        'btmgs
        '
        Me.btmgs.Location = New System.Drawing.Point(246, 241)
        Me.btmgs.Multiline = True
        Me.btmgs.Name = "btmgs"
        Me.btmgs.Size = New System.Drawing.Size(172, 28)
        Me.btmgs.TabIndex = 4
        '
        'labelbtmtd
        '
        Me.labelbtmtd.AutoSize = True
        Me.labelbtmtd.BackColor = System.Drawing.Color.Transparent
        Me.labelbtmtd.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbtmtd.Location = New System.Drawing.Point(124, 329)
        Me.labelbtmtd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelbtmtd.Name = "labelbtmtd"
        Me.labelbtmtd.Size = New System.Drawing.Size(93, 22)
        Me.labelbtmtd.TabIndex = 23
        Me.labelbtmtd.Text = "Tax Due:"
        '
        'labelbtmv
        '
        Me.labelbtmv.AutoSize = True
        Me.labelbtmv.BackColor = System.Drawing.Color.Transparent
        Me.labelbtmv.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbtmv.Location = New System.Drawing.Point(105, 276)
        Me.labelbtmv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelbtmv.Name = "labelbtmv"
        Me.labelbtmv.Size = New System.Drawing.Size(120, 23)
        Me.labelbtmv.TabIndex = 22
        Me.labelbtmv.Text = "VAT/NON-VAT:"
        '
        'labelbtmgs
        '
        Me.labelbtmgs.AutoSize = True
        Me.labelbtmgs.BackColor = System.Drawing.Color.Transparent
        Me.labelbtmgs.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbtmgs.Location = New System.Drawing.Point(118, 241)
        Me.labelbtmgs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelbtmgs.Name = "labelbtmgs"
        Me.labelbtmgs.Size = New System.Drawing.Size(106, 23)
        Me.labelbtmgs.TabIndex = 21
        Me.labelbtmgs.Text = "Gross Sales:"
        '
        'labelbtmmon
        '
        Me.labelbtmmon.AutoSize = True
        Me.labelbtmmon.BackColor = System.Drawing.Color.Transparent
        Me.labelbtmmon.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbtmmon.Location = New System.Drawing.Point(162, 170)
        Me.labelbtmmon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelbtmmon.Name = "labelbtmmon"
        Me.labelbtmmon.Size = New System.Drawing.Size(63, 23)
        Me.labelbtmmon.TabIndex = 20
        Me.labelbtmmon.Text = "Month:"
        '
        'boxbtmname
        '
        Me.boxbtmname.Location = New System.Drawing.Point(246, 134)
        Me.boxbtmname.Multiline = True
        Me.boxbtmname.Name = "boxbtmname"
        Me.boxbtmname.Size = New System.Drawing.Size(172, 28)
        Me.boxbtmname.TabIndex = 1
        '
        'labelbtmname
        '
        Me.labelbtmname.AutoSize = True
        Me.labelbtmname.BackColor = System.Drawing.Color.Transparent
        Me.labelbtmname.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbtmname.Location = New System.Drawing.Point(72, 132)
        Me.labelbtmname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelbtmname.Name = "labelbtmname"
        Me.labelbtmname.Size = New System.Drawing.Size(154, 23)
        Me.labelbtmname.TabIndex = 18
        Me.labelbtmname.Text = "Name of Company:"
        '
        'labelbtm
        '
        Me.labelbtm.AutoSize = True
        Me.labelbtm.BackColor = System.Drawing.Color.Transparent
        Me.labelbtm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbtm.Location = New System.Drawing.Point(340, 9)
        Me.labelbtm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelbtm.Name = "labelbtm"
        Me.labelbtm.Size = New System.Drawing.Size(138, 18)
        Me.labelbtm.TabIndex = 17
        Me.labelbtm.Text = "Monthly Tax Due"
        '
        'labelbtyear
        '
        Me.labelbtyear.AutoSize = True
        Me.labelbtyear.BackColor = System.Drawing.Color.Transparent
        Me.labelbtyear.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbtyear.Location = New System.Drawing.Point(175, 204)
        Me.labelbtyear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelbtyear.Name = "labelbtyear"
        Me.labelbtyear.Size = New System.Drawing.Size(49, 23)
        Me.labelbtyear.TabIndex = 31
        Me.labelbtyear.Text = "Year:"
        '
        'textboxbtyear
        '
        Me.textboxbtyear.Location = New System.Drawing.Point(246, 203)
        Me.textboxbtyear.Multiline = True
        Me.textboxbtyear.Name = "textboxbtyear"
        Me.textboxbtyear.Size = New System.Drawing.Size(172, 28)
        Me.textboxbtyear.TabIndex = 3
        '
        'PrintFormBTM
        '
        Me.PrintFormBTM.DocumentName = "document"
        Me.PrintFormBTM.Form = Me
        Me.PrintFormBTM.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintFormBTM.PrinterSettings = CType(resources.GetObject("PrintFormBTM.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintFormBTM.PrintFileName = Nothing
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(343, 380)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 38)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BTMonthly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Simple_Accounting_System.My.Resources.Resources.inside_report
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(503, 441)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textboxbtyear)
        Me.Controls.Add(Me.labelbtyear)
        Me.Controls.Add(Me.buttonbtmClear)
        Me.Controls.Add(Me.buttonbtmPrint)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.comboboxbtmmon)
        Me.Controls.Add(Me.comboboxbtmv)
        Me.Controls.Add(Me.btmtd)
        Me.Controls.Add(Me.btmgs)
        Me.Controls.Add(Me.labelbtmtd)
        Me.Controls.Add(Me.labelbtmv)
        Me.Controls.Add(Me.labelbtmgs)
        Me.Controls.Add(Me.labelbtmmon)
        Me.Controls.Add(Me.boxbtmname)
        Me.Controls.Add(Me.labelbtmname)
        Me.Controls.Add(Me.labelbtm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BTMonthly"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BTMonthly"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonbtmClear As System.Windows.Forms.Button
    Friend WithEvents buttonbtmPrint As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents comboboxbtmmon As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxbtmv As System.Windows.Forms.ComboBox
    Friend WithEvents btmtd As System.Windows.Forms.TextBox
    Friend WithEvents btmgs As System.Windows.Forms.TextBox
    Friend WithEvents labelbtmtd As System.Windows.Forms.Label
    Friend WithEvents labelbtmv As System.Windows.Forms.Label
    Friend WithEvents labelbtmgs As System.Windows.Forms.Label
    Friend WithEvents labelbtmmon As System.Windows.Forms.Label
    Friend WithEvents boxbtmname As System.Windows.Forms.TextBox
    Friend WithEvents labelbtmname As System.Windows.Forms.Label
    Friend WithEvents labelbtm As System.Windows.Forms.Label
    Friend WithEvents labelbtyear As System.Windows.Forms.Label
    Friend WithEvents textboxbtyear As System.Windows.Forms.TextBox
    Friend WithEvents PrintFormBTM As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
