<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Search
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonPatientID = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonDate = New System.Windows.Forms.RadioButton()
        Me.Okbtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonSex = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label_Invisivle = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonPatientID)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 45)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'RadioButtonPatientID
        '
        Me.RadioButtonPatientID.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButtonPatientID.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonPatientID.Location = New System.Drawing.Point(61, 10)
        Me.RadioButtonPatientID.Name = "RadioButtonPatientID"
        Me.RadioButtonPatientID.Size = New System.Drawing.Size(140, 29)
        Me.RadioButtonPatientID.TabIndex = 2
        Me.RadioButtonPatientID.Text = "Patient ID"
        Me.RadioButtonPatientID.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButtonDate)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 72)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(260, 45)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        '
        'RadioButtonDate
        '
        Me.RadioButtonDate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButtonDate.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonDate.Location = New System.Drawing.Point(84, 12)
        Me.RadioButtonDate.Name = "RadioButtonDate"
        Me.RadioButtonDate.Size = New System.Drawing.Size(116, 25)
        Me.RadioButtonDate.TabIndex = 3
        Me.RadioButtonDate.Text = "Date"
        Me.RadioButtonDate.UseVisualStyleBackColor = True
        '
        'Okbtn
        '
        Me.Okbtn.BackColor = System.Drawing.Color.Lime
        Me.Okbtn.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Okbtn.ForeColor = System.Drawing.Color.Black
        Me.Okbtn.Location = New System.Drawing.Point(90, 181)
        Me.Okbtn.Name = "Okbtn"
        Me.Okbtn.Size = New System.Drawing.Size(84, 33)
        Me.Okbtn.TabIndex = 7
        Me.Okbtn.Text = "OK"
        Me.Okbtn.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButtonSex)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 45)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'RadioButtonSex
        '
        Me.RadioButtonSex.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButtonSex.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonSex.Location = New System.Drawing.Point(84, 12)
        Me.RadioButtonSex.Name = "RadioButtonSex"
        Me.RadioButtonSex.Size = New System.Drawing.Size(116, 25)
        Me.RadioButtonSex.TabIndex = 3
        Me.RadioButtonSex.Text = "Sex"
        Me.RadioButtonSex.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label_Invisivle)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.Okbtn)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(274, 226)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search"
        '
        'Label_Invisivle
        '
        Me.Label_Invisivle.AutoSize = True
        Me.Label_Invisivle.Location = New System.Drawing.Point(209, 70)
        Me.Label_Invisivle.Name = "Label_Invisivle"
        Me.Label_Invisivle.Size = New System.Drawing.Size(0, 19)
        Me.Label_Invisivle.TabIndex = 18
        Me.Label_Invisivle.Visible = False
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(274, 226)
        Me.Controls.Add(Me.GroupBox3)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Search"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Okbtn As Button
    Friend WithEvents RadioButtonPatientID As RadioButton
    Friend WithEvents RadioButtonDate As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButtonSex As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label_Invisivle As Label
End Class
