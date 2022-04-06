<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterPatientID_Update2
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
        Me.EnterPatientID_Update2okbtn = New System.Windows.Forms.Button()
        Me.TextBoxEnterID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EnterPatientID_Update2okbtn)
        Me.GroupBox1.Controls.Add(Me.TextBoxEnterID)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 58)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient ID"
        '
        'EnterPatientID_Update2okbtn
        '
        Me.EnterPatientID_Update2okbtn.BackColor = System.Drawing.Color.Lime
        Me.EnterPatientID_Update2okbtn.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterPatientID_Update2okbtn.ForeColor = System.Drawing.Color.Black
        Me.EnterPatientID_Update2okbtn.Location = New System.Drawing.Point(201, 21)
        Me.EnterPatientID_Update2okbtn.Name = "EnterPatientID_Update2okbtn"
        Me.EnterPatientID_Update2okbtn.Size = New System.Drawing.Size(54, 22)
        Me.EnterPatientID_Update2okbtn.TabIndex = 32
        Me.EnterPatientID_Update2okbtn.Text = "OK"
        Me.EnterPatientID_Update2okbtn.UseVisualStyleBackColor = False
        '
        'TextBoxEnterID
        '
        Me.TextBoxEnterID.Location = New System.Drawing.Point(34, 21)
        Me.TextBoxEnterID.Name = "TextBoxEnterID"
        Me.TextBoxEnterID.Size = New System.Drawing.Size(144, 22)
        Me.TextBoxEnterID.TabIndex = 0
        '
        'EnterPatientID_Update2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(284, 58)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EnterPatientID_Update2"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EnterPatientID_Update2okbtn As Button
    Friend WithEvents TextBoxEnterID As TextBox
End Class
