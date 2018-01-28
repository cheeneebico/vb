<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BTQuarterly
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BTQuarterly))
        Me.labelbtq = New System.Windows.Forms.Label()
        Me.comboboxbtq = New System.Windows.Forms.ComboBox()
        Me.boxbtqname = New System.Windows.Forms.TextBox()
        Me.labelbtqname = New System.Windows.Forms.Label()
        Me.labelbtq2 = New System.Windows.Forms.Label()
        Me.labelbtqgs = New System.Windows.Forms.Label()
        Me.boxbtqgs = New System.Windows.Forms.TextBox()
        Me.comboboxbtqv = New System.Windows.Forms.ComboBox()
        Me.labelbtqv = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.labelbtqtotal = New System.Windows.Forms.Label()
        Me.labelbtqprev = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btqtd = New System.Windows.Forms.TextBox()
        Me.labelbtqtd = New System.Windows.Forms.Label()
        Me.buttonbtqclear = New System.Windows.Forms.Button()
        Me.buttonbtqprint = New System.Windows.Forms.Button()
        Me.boxbtqtotal = New System.Windows.Forms.TextBox()
        Me.boxbtqprev = New System.Windows.Forms.TextBox()
        Me.PrintFormBTQ = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.labelbtyear = New System.Windows.Forms.Label()
        Me.textboxbtyear = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelbtq
        '
        Me.labelbtq.AutoSize = True
        Me.labelbtq.BackColor = System.Drawing.Color.Transparent
        Me.labelbtq.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbtq.Location = New System.Drawing.Point(385, 9)
        Me.labelbtq.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelbtq.Name = "labelbtq"
        Me.labelbtq.Size = New System.Drawing.Size(152, 18)
        Me.labelbtq.TabIndex = 18
        Me.labelbtq.Text = "Quarterly Tax Due"
        '
        'comboboxbtq
        '
        Me.comboboxbtq.FormattingEnabled = True
        Me.comboboxbtq.Items.AddRange(New Object() {"1st Quarter", "2nd Quarter", "3rd Quarter", "4th Quarter"})
        Me.comboboxbtq.Location = New System.Drawing.Point(254, 226)
        Me.comboboxbtq.Name = "comboboxbtq"
        Me.comboboxbtq.Size = New System.Drawing.Size(111, 21)
        Me.comboboxbtq.TabIndex = 3
        '
        'boxbtqname
        '
        Me.boxbtqname.Location = New System.Drawing.Point(254, 150)
        Me.boxbtqname.Multiline = True
        Me.boxbtqname.Name = "boxbtqname"
        Me.boxbtqname.Size = New System.Drawing.Size(172, 28)
        Me.boxbtqname.TabIndex = 1
        '
        'labelbtqname
        '
        Me.labelbtqname.AutoSize = True
        Me.labelbtqname.BackColor = System.Drawing.Color.Transparent
        Me.labelbtqname.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbtqname.Location = New System.Drawing.Point(81, 153)
        Me.labelbtqname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelbtqname.Name = "labelbtqname"
        Me.labelbtqname.Size = New System.Drawing.Size(154, 23)
        Me.labelbtqname.TabIndex = 20
        Me.labelbtqname.Text = "Name of Company:"
        '
        'labelbtq2
        '
        Me.labelbtq2.AutoSize = True
        Me.labelbtq2.BackColor = System.Drawing.Color.Transparent
        Me.labelbtq2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbtq2.Location = New System.Drawing.Point(162, 224)
        Me.labelbtq2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelbtq2.Name = "labelbtq2"
        Me.labelbtq2.Size = New System.Drawing.Size(72, 23)
        Me.labelbtq2.TabIndex = 22
        Me.labelbtq2.Text = "Quarter:"
        '
        'labelbtqgs
        '
        Me.labelbtqgs.AutoSize = True
        Me.labelbtqgs.BackColor = System.Drawing.Color.Transparent
        Me.labelbtqgs.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbtqgs.Location = New System.Drawing.Point(129, 257)
        Me.labelbtqgs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelbtqgs.Name = "labelbtqgs"
        Me.labelbtqgs.Size = New System.Drawing.Size(106, 23)
        Me.labelbtqgs.TabIndex = 23
        Me.labelbtqgs.Text = "Gross Sales:"
        '
        'boxbtqgs
        '
        Me.boxbtqgs.Location = New System.Drawing.Point(254, 256)
        Me.boxbtqgs.Multiline = True
        Me.boxbtqgs.Name = "boxbtqgs"
        Me.boxbtqgs.Size = New System.Drawing.Size(172, 28)
        Me.boxbtqgs.TabIndex = 4
        '
        'comboboxbtqv
        '
        Me.comboboxbtqv.FormattingEnabled = True
        Me.comboboxbtqv.Items.AddRange(New Object() {".12", ".3"})
        Me.comboboxbtqv.Location = New System.Drawing.Point(254, 294)
        Me.comboboxbtqv.Name = "comboboxbtqv"
        Me.comboboxbtqv.Size = New System.Drawing.Size(172, 21)
        Me.comboboxbtqv.TabIndex = 5
        '
        'labelbtqv
        '
        Me.labelbtqv.AutoSize = True
        Me.labelbtqv.BackColor = System.Drawing.Color.Transparent
        Me.labelbtqv.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbtqv.Location = New System.Drawing.Point(116, 292)
        Me.labelbtqv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelbtqv.Name = "labelbtqv"
        Me.labelbtqv.Size = New System.Drawing.Size(120, 23)
        Me.labelbtqv.TabIndex = 27
        Me.labelbtqv.Text = "VAT/NON-VAT:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(125, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(308, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "___________________________________________"
        '
        'labelbtqtotal
        '
        Me.labelbtqtotal.AutoSize = True
        Me.labelbtqtotal.BackColor = System.Drawing.Color.Transparent
        Me.labelbtqtotal.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbtqtotal.Location = New System.Drawing.Point(181, 336)
        Me.labelbtqtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelbtqtotal.Name = "labelbtqtotal"
        Me.labelbtqtotal.Size = New System.Drawing.Size(53, 23)
        Me.labelbtqtotal.TabIndex = 30
        Me.labelbtqtotal.Text = "Total:"
        '
        'labelbtqprev
        '
        Me.labelbtqprev.AutoSize = True
        Me.labelbtqprev.BackColor = System.Drawing.Color.Transparent
        Me.labelbtqprev.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbtqprev.Location = New System.Drawing.Point(72, 366)
        Me.labelbtqprev.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelbtqprev.Name = "labelbtqprev"
        Me.labelbtqprev.Size = New System.Drawing.Size(163, 28)
        Me.labelbtqprev.TabIndex = 31
        Me.labelbtqprev.Text = "Previous taxes paid:"
        Me.labelbtqprev.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 388)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "___________________________________________"
        '
        'btqtd
        '
        Me.btqtd.Location = New System.Drawing.Point(254, 408)
        Me.btqtd.Multiline = True
        Me.btqtd.Name = "btqtd"
        Me.btqtd.Size = New System.Drawing.Size(164, 28)
        Me.btqtd.TabIndex = 8
        '
        'labelbtqtd
        '
        Me.labelbtqtd.AutoSize = True
        Me.labelbtqtd.BackColor = System.Drawing.Color.Transparent
        Me.labelbtqtd.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbtqtd.Location = New System.Drawing.Point(141, 412)
        Me.labelbtqtd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelbtqtd.Name = "labelbtqtd"
        Me.labelbtqtd.Size = New System.Drawing.Size(93, 22)
        Me.labelbtqtd.TabIndex = 33
        Me.labelbtqtd.Text = "Tax Due:"
        '
        'buttonbtqclear
        '
        Me.buttonbtqclear.BackColor = System.Drawing.Color.SeaGreen
        Me.buttonbtqclear.FlatAppearance.BorderSize = 0
        Me.buttonbtqclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonbtqclear.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonbtqclear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.buttonbtqclear.Location = New System.Drawing.Point(202, 465)
        Me.buttonbtqclear.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonbtqclear.Name = "buttonbtqclear"
        Me.buttonbtqclear.Size = New System.Drawing.Size(125, 38)
        Me.buttonbtqclear.TabIndex = 36
        Me.buttonbtqclear.Text = "Clear"
        Me.buttonbtqclear.UseVisualStyleBackColor = False
        '
        'buttonbtqprint
        '
        Me.buttonbtqprint.BackColor = System.Drawing.Color.SeaGreen
        Me.buttonbtqprint.FlatAppearance.BorderSize = 0
        Me.buttonbtqprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonbtqprint.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonbtqprint.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.buttonbtqprint.Location = New System.Drawing.Point(40, 465)
        Me.buttonbtqprint.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonbtqprint.Name = "buttonbtqprint"
        Me.buttonbtqprint.Size = New System.Drawing.Size(115, 38)
        Me.buttonbtqprint.TabIndex = 35
        Me.buttonbtqprint.Text = "Print"
        Me.buttonbtqprint.UseVisualStyleBackColor = False
        '
        'boxbtqtotal
        '
        Me.boxbtqtotal.Location = New System.Drawing.Point(254, 337)
        Me.boxbtqtotal.Multiline = True
        Me.boxbtqtotal.Name = "boxbtqtotal"
        Me.boxbtqtotal.Size = New System.Drawing.Size(172, 20)
        Me.boxbtqtotal.TabIndex = 6
        '
        'boxbtqprev
        '
        Me.boxbtqprev.Location = New System.Drawing.Point(254, 365)
        Me.boxbtqprev.Multiline = True
        Me.boxbtqprev.Name = "boxbtqprev"
        Me.boxbtqprev.Size = New System.Drawing.Size(172, 28)
        Me.boxbtqprev.TabIndex = 7
        '
        'PrintFormBTQ
        '
        Me.PrintFormBTQ.DocumentName = "document"
        Me.PrintFormBTQ.Form = Me
        Me.PrintFormBTQ.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintFormBTQ.PrinterSettings = CType(resources.GetObject("PrintFormBTQ.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintFormBTQ.PrintFileName = Nothing
        '
        'labelbtyear
        '
        Me.labelbtyear.AutoSize = True
        Me.labelbtyear.BackColor = System.Drawing.Color.Transparent
        Me.labelbtyear.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbtyear.Location = New System.Drawing.Point(185, 192)
        Me.labelbtyear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelbtyear.Name = "labelbtyear"
        Me.labelbtyear.Size = New System.Drawing.Size(49, 23)
        Me.labelbtyear.TabIndex = 39
        Me.labelbtyear.Text = "Year:"
        '
        'textboxbtyear
        '
        Me.textboxbtyear.Location = New System.Drawing.Point(254, 188)
        Me.textboxbtyear.Multiline = True
        Me.textboxbtyear.Name = "textboxbtyear"
        Me.textboxbtyear.Size = New System.Drawing.Size(172, 28)
        Me.textboxbtyear.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(375, 465)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 38)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BTQuarterly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Simple_Accounting_System.My.Resources.Resources.inside_report
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(540, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textboxbtyear)
        Me.Controls.Add(Me.labelbtyear)
        Me.Controls.Add(Me.boxbtqprev)
        Me.Controls.Add(Me.boxbtqtotal)
        Me.Controls.Add(Me.buttonbtqclear)
        Me.Controls.Add(Me.buttonbtqprint)
        Me.Controls.Add(Me.btqtd)
        Me.Controls.Add(Me.labelbtqtd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labelbtqprev)
        Me.Controls.Add(Me.labelbtqtotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.comboboxbtqv)
        Me.Controls.Add(Me.labelbtqv)
        Me.Controls.Add(Me.boxbtqgs)
        Me.Controls.Add(Me.labelbtqgs)
        Me.Controls.Add(Me.labelbtq2)
        Me.Controls.Add(Me.boxbtqname)
        Me.Controls.Add(Me.labelbtqname)
        Me.Controls.Add(Me.comboboxbtq)
        Me.Controls.Add(Me.labelbtq)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BTQuarterly"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BTQuarterly"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelbtq As System.Windows.Forms.Label
    Friend WithEvents comboboxbtq As System.Windows.Forms.ComboBox
    Friend WithEvents boxbtqname As System.Windows.Forms.TextBox
    Friend WithEvents labelbtqname As System.Windows.Forms.Label
    Friend WithEvents labelbtq2 As System.Windows.Forms.Label
    Friend WithEvents labelbtqgs As System.Windows.Forms.Label
    Friend WithEvents boxbtqgs As System.Windows.Forms.TextBox
    Friend WithEvents comboboxbtqv As System.Windows.Forms.ComboBox
    Friend WithEvents labelbtqv As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents labelbtqtotal As System.Windows.Forms.Label
    Friend WithEvents labelbtqprev As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btqtd As System.Windows.Forms.TextBox
    Friend WithEvents labelbtqtd As System.Windows.Forms.Label
    Friend WithEvents buttonbtqclear As System.Windows.Forms.Button
    Friend WithEvents buttonbtqprint As System.Windows.Forms.Button
    Friend WithEvents boxbtqtotal As System.Windows.Forms.TextBox
    Friend WithEvents boxbtqprev As System.Windows.Forms.TextBox
    Friend WithEvents PrintFormBTQ As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents textboxbtyear As System.Windows.Forms.TextBox
    Friend WithEvents labelbtyear As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
