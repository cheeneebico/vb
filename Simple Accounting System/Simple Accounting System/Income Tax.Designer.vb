<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Income_Tax
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Income_Tax))
        Me.labelbtm = New System.Windows.Forms.Label()
        Me.textboxitnoc = New System.Windows.Forms.TextBox()
        Me.labelbtmname = New System.Windows.Forms.Label()
        Me.labelitquarter = New System.Windows.Forms.Label()
        Me.comboboxitq = New System.Windows.Forms.ComboBox()
        Me.textboxqitni = New System.Windows.Forms.TextBox()
        Me.labelitnetincome = New System.Windows.Forms.Label()
        Me.textboxittd = New System.Windows.Forms.TextBox()
        Me.labelittd = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.buttonbtmClear = New System.Windows.Forms.Button()
        Me.buttonbtmPrint = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.labelityear = New System.Windows.Forms.Label()
        Me.textboxityear = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelbtm
        '
        Me.labelbtm.AutoSize = True
        Me.labelbtm.BackColor = System.Drawing.Color.Transparent
        Me.labelbtm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbtm.Location = New System.Drawing.Point(354, 9)
        Me.labelbtm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelbtm.Name = "labelbtm"
        Me.labelbtm.Size = New System.Drawing.Size(179, 18)
        Me.labelbtm.TabIndex = 18
        Me.labelbtm.Text = "Quarterly Income Tax"
        '
        'textboxitnoc
        '
        Me.textboxitnoc.Location = New System.Drawing.Point(246, 147)
        Me.textboxitnoc.Multiline = True
        Me.textboxitnoc.Name = "textboxitnoc"
        Me.textboxitnoc.Size = New System.Drawing.Size(172, 28)
        Me.textboxitnoc.TabIndex = 1
        '
        'labelbtmname
        '
        Me.labelbtmname.AutoSize = True
        Me.labelbtmname.BackColor = System.Drawing.Color.Transparent
        Me.labelbtmname.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelbtmname.Location = New System.Drawing.Point(72, 147)
        Me.labelbtmname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelbtmname.Name = "labelbtmname"
        Me.labelbtmname.Size = New System.Drawing.Size(154, 23)
        Me.labelbtmname.TabIndex = 20
        Me.labelbtmname.Text = "Name of Company:"
        '
        'labelitquarter
        '
        Me.labelitquarter.AutoSize = True
        Me.labelitquarter.BackColor = System.Drawing.Color.Transparent
        Me.labelitquarter.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelitquarter.Location = New System.Drawing.Point(154, 181)
        Me.labelitquarter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelitquarter.Name = "labelitquarter"
        Me.labelitquarter.Size = New System.Drawing.Size(72, 23)
        Me.labelitquarter.TabIndex = 22
        Me.labelitquarter.Text = "Quarter:"
        '
        'comboboxitq
        '
        Me.comboboxitq.FormattingEnabled = True
        Me.comboboxitq.Items.AddRange(New Object() {"First Quarter", "Second Quarter", "Third Quarter"})
        Me.comboboxitq.Location = New System.Drawing.Point(246, 186)
        Me.comboboxitq.Name = "comboboxitq"
        Me.comboboxitq.Size = New System.Drawing.Size(172, 21)
        Me.comboboxitq.TabIndex = 2
        '
        'textboxqitni
        '
        Me.textboxqitni.Location = New System.Drawing.Point(246, 265)
        Me.textboxqitni.Multiline = True
        Me.textboxqitni.Name = "textboxqitni"
        Me.textboxqitni.Size = New System.Drawing.Size(172, 28)
        Me.textboxqitni.TabIndex = 4
        '
        'labelitnetincome
        '
        Me.labelitnetincome.AutoSize = True
        Me.labelitnetincome.BackColor = System.Drawing.Color.Transparent
        Me.labelitnetincome.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelitnetincome.Location = New System.Drawing.Point(126, 270)
        Me.labelitnetincome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelitnetincome.Name = "labelitnetincome"
        Me.labelitnetincome.Size = New System.Drawing.Size(100, 23)
        Me.labelitnetincome.TabIndex = 24
        Me.labelitnetincome.Text = "Net Income:"
        '
        'textboxittd
        '
        Me.textboxittd.Location = New System.Drawing.Point(246, 332)
        Me.textboxittd.Multiline = True
        Me.textboxittd.Name = "textboxittd"
        Me.textboxittd.Size = New System.Drawing.Size(172, 28)
        Me.textboxittd.TabIndex = 5
        '
        'labelittd
        '
        Me.labelittd.AutoSize = True
        Me.labelittd.BackColor = System.Drawing.Color.Transparent
        Me.labelittd.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelittd.Location = New System.Drawing.Point(126, 338)
        Me.labelittd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelittd.Name = "labelittd"
        Me.labelittd.Size = New System.Drawing.Size(93, 22)
        Me.labelittd.TabIndex = 26
        Me.labelittd.Text = "Tax Due:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(127, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(308, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "___________________________________________"
        '
        'buttonbtmClear
        '
        Me.buttonbtmClear.BackColor = System.Drawing.Color.SeaGreen
        Me.buttonbtmClear.FlatAppearance.BorderSize = 0
        Me.buttonbtmClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonbtmClear.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonbtmClear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.buttonbtmClear.Location = New System.Drawing.Point(193, 389)
        Me.buttonbtmClear.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonbtmClear.Name = "buttonbtmClear"
        Me.buttonbtmClear.Size = New System.Drawing.Size(140, 38)
        Me.buttonbtmClear.TabIndex = 32
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
        Me.buttonbtmPrint.Location = New System.Drawing.Point(31, 389)
        Me.buttonbtmPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonbtmPrint.Name = "buttonbtmPrint"
        Me.buttonbtmPrint.Size = New System.Drawing.Size(141, 38)
        Me.buttonbtmPrint.TabIndex = 31
        Me.buttonbtmPrint.Text = "Print"
        Me.buttonbtmPrint.UseVisualStyleBackColor = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'labelityear
        '
        Me.labelityear.AutoSize = True
        Me.labelityear.BackColor = System.Drawing.Color.Transparent
        Me.labelityear.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelityear.Location = New System.Drawing.Point(177, 224)
        Me.labelityear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelityear.Name = "labelityear"
        Me.labelityear.Size = New System.Drawing.Size(49, 23)
        Me.labelityear.TabIndex = 33
        Me.labelityear.Text = "Year:"
        '
        'textboxityear
        '
        Me.textboxityear.Location = New System.Drawing.Point(246, 219)
        Me.textboxityear.Multiline = True
        Me.textboxityear.Name = "textboxityear"
        Me.textboxityear.Size = New System.Drawing.Size(172, 28)
        Me.textboxityear.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(357, 389)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 38)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Income_Tax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Simple_Accounting_System.My.Resources.Resources.inside_report
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(537, 456)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textboxityear)
        Me.Controls.Add(Me.labelityear)
        Me.Controls.Add(Me.buttonbtmClear)
        Me.Controls.Add(Me.buttonbtmPrint)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.textboxittd)
        Me.Controls.Add(Me.labelittd)
        Me.Controls.Add(Me.textboxqitni)
        Me.Controls.Add(Me.labelitnetincome)
        Me.Controls.Add(Me.comboboxitq)
        Me.Controls.Add(Me.labelitquarter)
        Me.Controls.Add(Me.textboxitnoc)
        Me.Controls.Add(Me.labelbtmname)
        Me.Controls.Add(Me.labelbtm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Income_Tax"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Income_Tax"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelbtm As System.Windows.Forms.Label
    Friend WithEvents textboxitnoc As System.Windows.Forms.TextBox
    Friend WithEvents labelbtmname As System.Windows.Forms.Label
    Friend WithEvents labelitquarter As System.Windows.Forms.Label
    Friend WithEvents comboboxitq As System.Windows.Forms.ComboBox
    Friend WithEvents textboxqitni As System.Windows.Forms.TextBox
    Friend WithEvents labelitnetincome As System.Windows.Forms.Label
    Friend WithEvents textboxittd As System.Windows.Forms.TextBox
    Friend WithEvents labelittd As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents buttonbtmClear As System.Windows.Forms.Button
    Friend WithEvents buttonbtmPrint As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents labelityear As System.Windows.Forms.Label
    Friend WithEvents textboxityear As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
