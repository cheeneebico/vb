<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.buttonBT = New System.Windows.Forms.Button()
        Me.buttonIT = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonBT
        '
        Me.buttonBT.BackColor = System.Drawing.Color.SeaGreen
        Me.buttonBT.FlatAppearance.BorderSize = 0
        Me.buttonBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonBT.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonBT.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.buttonBT.Location = New System.Drawing.Point(368, 236)
        Me.buttonBT.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonBT.Name = "buttonBT"
        Me.buttonBT.Size = New System.Drawing.Size(190, 62)
        Me.buttonBT.TabIndex = 1
        Me.buttonBT.Text = "Business Tax"
        Me.buttonBT.UseVisualStyleBackColor = False
        '
        'buttonIT
        '
        Me.buttonIT.BackColor = System.Drawing.Color.SeaGreen
        Me.buttonIT.FlatAppearance.BorderSize = 0
        Me.buttonIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonIT.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonIT.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.buttonIT.Location = New System.Drawing.Point(368, 306)
        Me.buttonIT.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonIT.Name = "buttonIT"
        Me.buttonIT.Size = New System.Drawing.Size(190, 62)
        Me.buttonIT.TabIndex = 2
        Me.buttonIT.Text = "Income Tax"
        Me.buttonIT.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(368, 376)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 62)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Simple_Accounting_System.My.Resources.Resources.main_back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(582, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.buttonIT)
        Me.Controls.Add(Me.buttonBT)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents buttonBT As System.Windows.Forms.Button
    Friend WithEvents buttonIT As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
