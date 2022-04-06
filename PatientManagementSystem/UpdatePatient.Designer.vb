<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdatePatient
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
        Me.Gb = New System.Windows.Forms.GroupBox()
        Me.TextBoxPatientID_UpdateMain = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxFirstname_updateMain = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxLastname_updateMain = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBoxOthername_updateMain = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.update_Updatebtn2 = New System.Windows.Forms.Button()
        Me.update_DeleteBtn2 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxPatientSex_updateMain = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerDOB_updateMain = New System.Windows.Forms.DateTimePicker()
        Me.Gb.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.TextBoxPatientID_UpdateMain)
        Me.Gb.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gb.ForeColor = System.Drawing.Color.Lime
        Me.Gb.Location = New System.Drawing.Point(3, 18)
        Me.Gb.Name = "Gb"
        Me.Gb.Size = New System.Drawing.Size(318, 49)
        Me.Gb.TabIndex = 3
        Me.Gb.TabStop = False
        Me.Gb.Text = "Patient ID"
        '
        'TextBoxPatientID_UpdateMain
        '
        Me.TextBoxPatientID_UpdateMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxPatientID_UpdateMain.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPatientID_UpdateMain.ForeColor = System.Drawing.Color.White
        Me.TextBoxPatientID_UpdateMain.Location = New System.Drawing.Point(3, 18)
        Me.TextBoxPatientID_UpdateMain.Name = "TextBoxPatientID_UpdateMain"
        Me.TextBoxPatientID_UpdateMain.Size = New System.Drawing.Size(312, 28)
        Me.TextBoxPatientID_UpdateMain.TabIndex = 0
        Me.TextBoxPatientID_UpdateMain.Text = "ID"
        Me.TextBoxPatientID_UpdateMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxFirstname_updateMain)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox2.Location = New System.Drawing.Point(3, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 61)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Firstname"
        '
        'TextBoxFirstname_updateMain
        '
        Me.TextBoxFirstname_updateMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxFirstname_updateMain.Location = New System.Drawing.Point(3, 18)
        Me.TextBoxFirstname_updateMain.Name = "TextBoxFirstname_updateMain"
        Me.TextBoxFirstname_updateMain.Size = New System.Drawing.Size(312, 22)
        Me.TextBoxFirstname_updateMain.TabIndex = 0
        Me.TextBoxFirstname_updateMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxLastname_updateMain)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox3.Location = New System.Drawing.Point(3, 128)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(318, 61)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lastname"
        '
        'TextBoxLastname_updateMain
        '
        Me.TextBoxLastname_updateMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxLastname_updateMain.Location = New System.Drawing.Point(3, 18)
        Me.TextBoxLastname_updateMain.Name = "TextBoxLastname_updateMain"
        Me.TextBoxLastname_updateMain.Size = New System.Drawing.Size(312, 22)
        Me.TextBoxLastname_updateMain.TabIndex = 0
        Me.TextBoxLastname_updateMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBoxOthername_updateMain)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox4.Location = New System.Drawing.Point(3, 189)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(318, 61)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Othername"
        '
        'TextBoxOthername_updateMain
        '
        Me.TextBoxOthername_updateMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxOthername_updateMain.Location = New System.Drawing.Point(3, 18)
        Me.TextBoxOthername_updateMain.Name = "TextBoxOthername_updateMain"
        Me.TextBoxOthername_updateMain.Size = New System.Drawing.Size(312, 22)
        Me.TextBoxOthername_updateMain.TabIndex = 0
        Me.TextBoxOthername_updateMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Gb)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 456)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.update_Updatebtn2)
        Me.GroupBox8.Controls.Add(Me.update_DeleteBtn2)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox8.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox8.Location = New System.Drawing.Point(3, 393)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(318, 60)
        Me.GroupBox8.TabIndex = 10
        Me.GroupBox8.TabStop = False
        '
        'update_Updatebtn2
        '
        Me.update_Updatebtn2.BackColor = System.Drawing.Color.Lime
        Me.update_Updatebtn2.Dock = System.Windows.Forms.DockStyle.Right
        Me.update_Updatebtn2.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_Updatebtn2.ForeColor = System.Drawing.Color.Black
        Me.update_Updatebtn2.Location = New System.Drawing.Point(227, 18)
        Me.update_Updatebtn2.Name = "update_Updatebtn2"
        Me.update_Updatebtn2.Size = New System.Drawing.Size(88, 39)
        Me.update_Updatebtn2.TabIndex = 8
        Me.update_Updatebtn2.Text = "Update"
        Me.update_Updatebtn2.UseVisualStyleBackColor = False
        '
        'update_DeleteBtn2
        '
        Me.update_DeleteBtn2.BackColor = System.Drawing.Color.Red
        Me.update_DeleteBtn2.Dock = System.Windows.Forms.DockStyle.Left
        Me.update_DeleteBtn2.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_DeleteBtn2.ForeColor = System.Drawing.Color.Black
        Me.update_DeleteBtn2.Location = New System.Drawing.Point(3, 18)
        Me.update_DeleteBtn2.Name = "update_DeleteBtn2"
        Me.update_DeleteBtn2.Size = New System.Drawing.Size(88, 39)
        Me.update_DeleteBtn2.TabIndex = 7
        Me.update_DeleteBtn2.Text = "Delete"
        Me.update_DeleteBtn2.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ComboBoxPatientSex_updateMain)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox6.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox6.Location = New System.Drawing.Point(3, 311)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(318, 57)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Sex"
        '
        'ComboBoxPatientSex_updateMain
        '
        Me.ComboBoxPatientSex_updateMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxPatientSex_updateMain.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPatientSex_updateMain.FormattingEnabled = True
        Me.ComboBoxPatientSex_updateMain.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxPatientSex_updateMain.Location = New System.Drawing.Point(3, 18)
        Me.ComboBoxPatientSex_updateMain.Name = "ComboBoxPatientSex_updateMain"
        Me.ComboBoxPatientSex_updateMain.Size = New System.Drawing.Size(312, 23)
        Me.ComboBoxPatientSex_updateMain.TabIndex = 18
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DateTimePickerDOB_updateMain)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox5.Location = New System.Drawing.Point(3, 250)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(318, 61)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Date Of Birth"
        '
        'DateTimePickerDOB_updateMain
        '
        Me.DateTimePickerDOB_updateMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePickerDOB_updateMain.Location = New System.Drawing.Point(3, 18)
        Me.DateTimePickerDOB_updateMain.Name = "DateTimePickerDOB_updateMain"
        Me.DateTimePickerDOB_updateMain.Size = New System.Drawing.Size(312, 22)
        Me.DateTimePickerDOB_updateMain.TabIndex = 0
        '
        'UpdatePatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(324, 456)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdatePatient"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Gb.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Gb As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBoxFirstname_updateMain As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBoxLastname_updateMain As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBoxOthername_updateMain As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DateTimePickerDOB_updateMain As DateTimePicker
    Friend WithEvents ComboBoxPatientSex_updateMain As ComboBox
    Friend WithEvents update_DeleteBtn2 As Button
    Friend WithEvents update_Updatebtn2 As Button
    Friend WithEvents TextBoxPatientID_UpdateMain As Label
End Class
