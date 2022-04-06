<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _Update
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
        Me.updatePatientRecordBtn = New System.Windows.Forms.Button()
        Me.updatePatientBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'updatePatientRecordBtn
        '
        Me.updatePatientRecordBtn.BackColor = System.Drawing.Color.Lime
        Me.updatePatientRecordBtn.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatePatientRecordBtn.ForeColor = System.Drawing.Color.Black
        Me.updatePatientRecordBtn.Location = New System.Drawing.Point(64, 138)
        Me.updatePatientRecordBtn.Name = "updatePatientRecordBtn"
        Me.updatePatientRecordBtn.Size = New System.Drawing.Size(156, 50)
        Me.updatePatientRecordBtn.TabIndex = 3
        Me.updatePatientRecordBtn.Text = "Update Patient Health Record"
        Me.updatePatientRecordBtn.UseVisualStyleBackColor = False
        '
        'updatePatientBtn
        '
        Me.updatePatientBtn.BackColor = System.Drawing.Color.Lime
        Me.updatePatientBtn.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatePatientBtn.ForeColor = System.Drawing.Color.Black
        Me.updatePatientBtn.Location = New System.Drawing.Point(64, 73)
        Me.updatePatientBtn.Name = "updatePatientBtn"
        Me.updatePatientBtn.Size = New System.Drawing.Size(156, 43)
        Me.updatePatientBtn.TabIndex = 2
        Me.updatePatientBtn.Text = "Update Patient"
        Me.updatePatientBtn.UseVisualStyleBackColor = False
        '
        '_Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.updatePatientRecordBtn)
        Me.Controls.Add(Me.updatePatientBtn)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_Update"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents updatePatientRecordBtn As Button
    Friend WithEvents updatePatientBtn As Button
End Class
