<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctor_Nurse
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
        Me.labelInvisible1 = New System.Windows.Forms.Label()
        Me.specialistSavebtn = New System.Windows.Forms.Button()
        Me.ComboBoxSpecialistSex = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxSpecialistOthername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxSpecialistFirstname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxSpecialistLastname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxSpecialist_ID = New System.Windows.Forms.TextBox()
        Me.SpecialistIDlbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.labelInvisible1)
        Me.GroupBox1.Controls.Add(Me.specialistSavebtn)
        Me.GroupBox1.Controls.Add(Me.ComboBoxSpecialistSex)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxSpecialistOthername)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxSpecialistFirstname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxSpecialistLastname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxSpecialist_ID)
        Me.GroupBox1.Controls.Add(Me.SpecialistIDlbl)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 358)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'labelInvisible1
        '
        Me.labelInvisible1.AutoSize = True
        Me.labelInvisible1.Location = New System.Drawing.Point(43, 286)
        Me.labelInvisible1.Name = "labelInvisible1"
        Me.labelInvisible1.Size = New System.Drawing.Size(39, 13)
        Me.labelInvisible1.TabIndex = 20
        Me.labelInvisible1.Text = "Label7"
        Me.labelInvisible1.Visible = False
        '
        'specialistSavebtn
        '
        Me.specialistSavebtn.BackColor = System.Drawing.Color.Lime
        Me.specialistSavebtn.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specialistSavebtn.ForeColor = System.Drawing.Color.Black
        Me.specialistSavebtn.Location = New System.Drawing.Point(239, 286)
        Me.specialistSavebtn.Name = "specialistSavebtn"
        Me.specialistSavebtn.Size = New System.Drawing.Size(88, 33)
        Me.specialistSavebtn.TabIndex = 17
        Me.specialistSavebtn.Text = "Save"
        Me.specialistSavebtn.UseVisualStyleBackColor = False
        '
        'ComboBoxSpecialistSex
        '
        Me.ComboBoxSpecialistSex.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSpecialistSex.FormattingEnabled = True
        Me.ComboBoxSpecialistSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxSpecialistSex.Location = New System.Drawing.Point(276, 230)
        Me.ComboBoxSpecialistSex.Name = "ComboBoxSpecialistSex"
        Me.ComboBoxSpecialistSex.Size = New System.Drawing.Size(204, 27)
        Me.ComboBoxSpecialistSex.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(111, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(159, 26)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Sex:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxSpecialistOthername
        '
        Me.TextBoxSpecialistOthername.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSpecialistOthername.Location = New System.Drawing.Point(276, 186)
        Me.TextBoxSpecialistOthername.Name = "TextBoxSpecialistOthername"
        Me.TextBoxSpecialistOthername.Size = New System.Drawing.Size(204, 26)
        Me.TextBoxSpecialistOthername.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(111, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(159, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Othername:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxSpecialistFirstname
        '
        Me.TextBoxSpecialistFirstname.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSpecialistFirstname.Location = New System.Drawing.Point(276, 98)
        Me.TextBoxSpecialistFirstname.Name = "TextBoxSpecialistFirstname"
        Me.TextBoxSpecialistFirstname.Size = New System.Drawing.Size(204, 26)
        Me.TextBoxSpecialistFirstname.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(159, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Firstname:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxSpecialistLastname
        '
        Me.TextBoxSpecialistLastname.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSpecialistLastname.Location = New System.Drawing.Point(276, 143)
        Me.TextBoxSpecialistLastname.Name = "TextBoxSpecialistLastname"
        Me.TextBoxSpecialistLastname.Size = New System.Drawing.Size(204, 26)
        Me.TextBoxSpecialistLastname.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(159, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Lastname:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxSpecialist_ID
        '
        Me.TextBoxSpecialist_ID.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSpecialist_ID.Location = New System.Drawing.Point(276, 57)
        Me.TextBoxSpecialist_ID.Name = "TextBoxSpecialist_ID"
        Me.TextBoxSpecialist_ID.Size = New System.Drawing.Size(204, 26)
        Me.TextBoxSpecialist_ID.TabIndex = 2
        '
        'SpecialistIDlbl
        '
        Me.SpecialistIDlbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialistIDlbl.Location = New System.Drawing.Point(54, 57)
        Me.SpecialistIDlbl.Name = "SpecialistIDlbl"
        Me.SpecialistIDlbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SpecialistIDlbl.Size = New System.Drawing.Size(216, 26)
        Me.SpecialistIDlbl.TabIndex = 1
        Me.SpecialistIDlbl.Text = "Doctor ID / Nurse ID:"
        Me.SpecialistIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(3, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(582, 26)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "NEW DOCTOR/NURSE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Doctor_Nurse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(588, 358)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Doctor_Nurse"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents specialistSavebtn As Button
    Friend WithEvents ComboBoxSpecialistSex As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxSpecialistOthername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxSpecialistFirstname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxSpecialistLastname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxSpecialist_ID As TextBox
    Friend WithEvents SpecialistIDlbl As Label
    Friend WithEvents labelInvisible1 As Label
    Friend WithEvents Label6 As Label
End Class
