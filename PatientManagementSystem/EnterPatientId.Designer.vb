<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterPatientId
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
        Me.EnterPatientIDokbtn = New System.Windows.Forms.Button()
        Me.TextBoxPatID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EnterPatientIDokbtn)
        Me.GroupBox1.Controls.Add(Me.TextBoxPatID)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 58)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient ID"
        '
        'EnterPatientIDokbtn
        '
        Me.EnterPatientIDokbtn.BackColor = System.Drawing.Color.Lime
        Me.EnterPatientIDokbtn.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterPatientIDokbtn.ForeColor = System.Drawing.Color.Black
        Me.EnterPatientIDokbtn.Location = New System.Drawing.Point(201, 21)
        Me.EnterPatientIDokbtn.Name = "EnterPatientIDokbtn"
        Me.EnterPatientIDokbtn.Size = New System.Drawing.Size(54, 22)
        Me.EnterPatientIDokbtn.TabIndex = 32
        Me.EnterPatientIDokbtn.Text = "OK"
        Me.EnterPatientIDokbtn.UseVisualStyleBackColor = False
        '
        'TextBoxPatID
        '
        Me.TextBoxPatID.Location = New System.Drawing.Point(34, 21)
        Me.TextBoxPatID.Name = "TextBoxPatID"
        Me.TextBoxPatID.Size = New System.Drawing.Size(144, 22)
        Me.TextBoxPatID.TabIndex = 0
        '
        'EnterPatientId
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(284, 58)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EnterPatientId"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxPatID As TextBox
    Friend WithEvents EnterPatientIDokbtn As Button
End Class
