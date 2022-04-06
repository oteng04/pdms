<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchBySex
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SerachPatientIDOkbtn = New System.Windows.Forms.Button()
        Me.ComboBoxPatientSex = New System.Windows.Forms.ComboBox()
        Me.Label_Invisivle = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label_Invisivle)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPatientSex)
        Me.GroupBox1.Controls.Add(Me.SerachPatientIDOkbtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 91)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sex"
        '
        'SerachPatientIDOkbtn
        '
        Me.SerachPatientIDOkbtn.BackColor = System.Drawing.Color.Lime
        Me.SerachPatientIDOkbtn.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerachPatientIDOkbtn.ForeColor = System.Drawing.Color.Black
        Me.SerachPatientIDOkbtn.Location = New System.Drawing.Point(96, 59)
        Me.SerachPatientIDOkbtn.Name = "SerachPatientIDOkbtn"
        Me.SerachPatientIDOkbtn.Size = New System.Drawing.Size(70, 26)
        Me.SerachPatientIDOkbtn.TabIndex = 8
        Me.SerachPatientIDOkbtn.Text = "OK"
        Me.SerachPatientIDOkbtn.UseVisualStyleBackColor = False
        '
        'ComboBoxPatientSex
        '
        Me.ComboBoxPatientSex.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPatientSex.FormattingEnabled = True
        Me.ComboBoxPatientSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxPatientSex.Location = New System.Drawing.Point(29, 21)
        Me.ComboBoxPatientSex.Name = "ComboBoxPatientSex"
        Me.ComboBoxPatientSex.Size = New System.Drawing.Size(204, 27)
        Me.ComboBoxPatientSex.TabIndex = 17
        '
        'Label_Invisivle
        '
        Me.Label_Invisivle.AutoSize = True
        Me.Label_Invisivle.Location = New System.Drawing.Point(203, 70)
        Me.Label_Invisivle.Name = "Label_Invisivle"
        Me.Label_Invisivle.Size = New System.Drawing.Size(0, 15)
        Me.Label_Invisivle.TabIndex = 18
        Me.Label_Invisivle.Visible = False
        '
        'SearchBySex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(284, 116)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SearchBySex"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SerachPatientIDOkbtn As Button
    Friend WithEvents ComboBoxPatientSex As ComboBox
    Friend WithEvents Label_Invisivle As Label
End Class
