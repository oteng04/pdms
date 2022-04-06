<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewPatient
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
        Me.PatientIDlbl = New System.Windows.Forms.Label()
        Me.TextBoxPatient_ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxPatientLastname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPatientFirstname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPatientOthername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePickerPatientDOB = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxPatientSex = New System.Windows.Forms.ComboBox()
        Me.AddSavebtn = New System.Windows.Forms.Button()
        Me.DateTimePickerInvisible = New System.Windows.Forms.DateTimePicker()
        Me.labelInvisible = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PatientIDlbl
        '
        Me.PatientIDlbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientIDlbl.Location = New System.Drawing.Point(139, 59)
        Me.PatientIDlbl.Name = "PatientIDlbl"
        Me.PatientIDlbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PatientIDlbl.Size = New System.Drawing.Size(159, 26)
        Me.PatientIDlbl.TabIndex = 1
        Me.PatientIDlbl.Text = "Patient ID:"
        Me.PatientIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxPatient_ID
        '
        Me.TextBoxPatient_ID.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPatient_ID.Location = New System.Drawing.Point(304, 59)
        Me.TextBoxPatient_ID.Name = "TextBoxPatient_ID"
        Me.TextBoxPatient_ID.Size = New System.Drawing.Size(204, 26)
        Me.TextBoxPatient_ID.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(159, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Lastname:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxPatientLastname
        '
        Me.TextBoxPatientLastname.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPatientLastname.Location = New System.Drawing.Point(304, 144)
        Me.TextBoxPatientLastname.Name = "TextBoxPatientLastname"
        Me.TextBoxPatientLastname.Size = New System.Drawing.Size(204, 26)
        Me.TextBoxPatientLastname.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(159, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Firstname:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxPatientFirstname
        '
        Me.TextBoxPatientFirstname.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPatientFirstname.Location = New System.Drawing.Point(304, 102)
        Me.TextBoxPatientFirstname.Name = "TextBoxPatientFirstname"
        Me.TextBoxPatientFirstname.Size = New System.Drawing.Size(204, 26)
        Me.TextBoxPatientFirstname.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(139, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(159, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Othername:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxPatientOthername
        '
        Me.TextBoxPatientOthername.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPatientOthername.Location = New System.Drawing.Point(304, 188)
        Me.TextBoxPatientOthername.Name = "TextBoxPatientOthername"
        Me.TextBoxPatientOthername.Size = New System.Drawing.Size(204, 26)
        Me.TextBoxPatientOthername.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(139, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(159, 26)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Date of Birth:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(139, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(159, 26)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Sex:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePickerPatientDOB
        '
        Me.DateTimePickerPatientDOB.Checked = False
        Me.DateTimePickerPatientDOB.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerPatientDOB.Location = New System.Drawing.Point(304, 235)
        Me.DateTimePickerPatientDOB.Name = "DateTimePickerPatientDOB"
        Me.DateTimePickerPatientDOB.Size = New System.Drawing.Size(282, 26)
        Me.DateTimePickerPatientDOB.TabIndex = 15
        '
        'ComboBoxPatientSex
        '
        Me.ComboBoxPatientSex.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPatientSex.FormattingEnabled = True
        Me.ComboBoxPatientSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxPatientSex.Location = New System.Drawing.Point(304, 283)
        Me.ComboBoxPatientSex.Name = "ComboBoxPatientSex"
        Me.ComboBoxPatientSex.Size = New System.Drawing.Size(204, 27)
        Me.ComboBoxPatientSex.TabIndex = 16
        '
        'AddSavebtn
        '
        Me.AddSavebtn.BackColor = System.Drawing.Color.Lime
        Me.AddSavebtn.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSavebtn.ForeColor = System.Drawing.Color.Black
        Me.AddSavebtn.Location = New System.Drawing.Point(268, 370)
        Me.AddSavebtn.Name = "AddSavebtn"
        Me.AddSavebtn.Size = New System.Drawing.Size(88, 33)
        Me.AddSavebtn.TabIndex = 17
        Me.AddSavebtn.Text = "Save"
        Me.AddSavebtn.UseVisualStyleBackColor = False
        '
        'DateTimePickerInvisible
        '
        Me.DateTimePickerInvisible.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerInvisible.Location = New System.Drawing.Point(12, 370)
        Me.DateTimePickerInvisible.Name = "DateTimePickerInvisible"
        Me.DateTimePickerInvisible.Size = New System.Drawing.Size(125, 26)
        Me.DateTimePickerInvisible.TabIndex = 18
        Me.DateTimePickerInvisible.Visible = False
        '
        'labelInvisible
        '
        Me.labelInvisible.AutoSize = True
        Me.labelInvisible.Location = New System.Drawing.Point(45, 351)
        Me.labelInvisible.Name = "labelInvisible"
        Me.labelInvisible.Size = New System.Drawing.Size(39, 13)
        Me.labelInvisible.TabIndex = 19
        Me.labelInvisible.Text = "Label7"
        Me.labelInvisible.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.labelInvisible)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerInvisible)
        Me.GroupBox1.Controls.Add(Me.AddSavebtn)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPatientSex)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerPatientDOB)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxPatientOthername)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxPatientFirstname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxPatientLastname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxPatient_ID)
        Me.GroupBox1.Controls.Add(Me.PatientIDlbl)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 415)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(3, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(636, 26)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "NEW PATIENT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddNewPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(642, 415)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddNewPatient"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PatientIDlbl As Label
    Friend WithEvents TextBoxPatient_ID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxPatientLastname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPatientFirstname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxPatientOthername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePickerPatientDOB As DateTimePicker
    Friend WithEvents ComboBoxPatientSex As ComboBox
    Friend WithEvents AddSavebtn As Button
    Friend WithEvents DateTimePickerInvisible As DateTimePicker
    Friend WithEvents labelInvisible As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
End Class
