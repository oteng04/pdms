<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchPatientID
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
        Me.SearchPatientIDtxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SerachPatientIDOkbtn)
        Me.GroupBox1.Controls.Add(Me.SearchPatientIDtxt)
        Me.GroupBox1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 91)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient ID"
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
        'SearchPatientIDtxt
        '
        Me.SearchPatientIDtxt.Location = New System.Drawing.Point(59, 31)
        Me.SearchPatientIDtxt.Name = "SearchPatientIDtxt"
        Me.SearchPatientIDtxt.Size = New System.Drawing.Size(155, 22)
        Me.SearchPatientIDtxt.TabIndex = 0
        '
        'SearchPatientID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(284, 109)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SearchPatientID"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SearchPatientIDtxt As TextBox
    Friend WithEvents SerachPatientIDOkbtn As Button
End Class
