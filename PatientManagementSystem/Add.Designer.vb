<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add
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
        Me.NewPatient = New System.Windows.Forms.Button()
        Me.NewPatientRecord = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NewPatient
        '
        Me.NewPatient.BackColor = System.Drawing.Color.Lime
        Me.NewPatient.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPatient.ForeColor = System.Drawing.Color.Black
        Me.NewPatient.Location = New System.Drawing.Point(65, 72)
        Me.NewPatient.Name = "NewPatient"
        Me.NewPatient.Size = New System.Drawing.Size(156, 43)
        Me.NewPatient.TabIndex = 0
        Me.NewPatient.Text = "New Patient"
        Me.NewPatient.UseVisualStyleBackColor = False
        '
        'NewPatientRecord
        '
        Me.NewPatientRecord.BackColor = System.Drawing.Color.Lime
        Me.NewPatientRecord.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPatientRecord.ForeColor = System.Drawing.Color.Black
        Me.NewPatientRecord.Location = New System.Drawing.Point(65, 137)
        Me.NewPatientRecord.Name = "NewPatientRecord"
        Me.NewPatientRecord.Size = New System.Drawing.Size(156, 50)
        Me.NewPatientRecord.TabIndex = 1
        Me.NewPatientRecord.Text = "New Patient Health Record"
        Me.NewPatientRecord.UseVisualStyleBackColor = False
        '
        'Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.NewPatientRecord)
        Me.Controls.Add(Me.NewPatient)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NewPatient As Button
    Friend WithEvents NewPatientRecord As Button
End Class
