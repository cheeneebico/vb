<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BT
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buttonBTM = New System.Windows.Forms.Button()
        Me.buttonBTQ = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 115)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BUSINESS TAX"
        '
        'buttonBTM
        '
        Me.buttonBTM.BackColor = System.Drawing.Color.SeaGreen
        Me.buttonBTM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonBTM.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonBTM.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.buttonBTM.Location = New System.Drawing.Point(117, 201)
        Me.buttonBTM.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonBTM.Name = "buttonBTM"
        Me.buttonBTM.Size = New System.Drawing.Size(204, 62)
        Me.buttonBTM.TabIndex = 1
        Me.buttonBTM.Text = "Monthly"
        Me.buttonBTM.UseVisualStyleBackColor = False
        '
        'buttonBTQ
        '
        Me.buttonBTQ.BackColor = System.Drawing.Color.SeaGreen
        Me.buttonBTQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonBTQ.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonBTQ.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.buttonBTQ.Location = New System.Drawing.Point(117, 274)
        Me.buttonBTQ.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonBTQ.Name = "buttonBTQ"
        Me.buttonBTQ.Size = New System.Drawing.Size(204, 62)
        Me.buttonBTQ.TabIndex = 2
        Me.buttonBTQ.Text = "Quarterly"
        Me.buttonBTQ.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(117, 348)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 62)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Simple_Accounting_System.My.Resources.Resources.inside_report1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(439, 473)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.buttonBTQ)
        Me.Controls.Add(Me.buttonBTM)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Business Tax"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents buttonBTM As System.Windows.Forms.Button
    Friend WithEvents buttonBTQ As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
End Class
