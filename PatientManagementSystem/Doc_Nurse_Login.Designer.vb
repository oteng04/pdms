<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doc_Nurse_Login
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
        Me.EnterDoc_Nurse_IDokbtn = New System.Windows.Forms.Button()
        Me.TextBoxDoc_Nurse_D = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EnterDoc_Nurse_IDokbtn)
        Me.GroupBox1.Controls.Add(Me.TextBoxDoc_Nurse_D)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 79)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doc/Nurse ID"
        '
        'EnterDoc_Nurse_IDokbtn
        '
        Me.EnterDoc_Nurse_IDokbtn.BackColor = System.Drawing.Color.Lime
        Me.EnterDoc_Nurse_IDokbtn.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterDoc_Nurse_IDokbtn.ForeColor = System.Drawing.Color.Black
        Me.EnterDoc_Nurse_IDokbtn.Location = New System.Drawing.Point(207, 32)
        Me.EnterDoc_Nurse_IDokbtn.Name = "EnterDoc_Nurse_IDokbtn"
        Me.EnterDoc_Nurse_IDokbtn.Size = New System.Drawing.Size(71, 22)
        Me.EnterDoc_Nurse_IDokbtn.TabIndex = 32
        Me.EnterDoc_Nurse_IDokbtn.Text = "OK"
        Me.EnterDoc_Nurse_IDokbtn.UseVisualStyleBackColor = False
        '
        'TextBoxDoc_Nurse_D
        '
        Me.TextBoxDoc_Nurse_D.Location = New System.Drawing.Point(29, 32)
        Me.TextBoxDoc_Nurse_D.Name = "TextBoxDoc_Nurse_D"
        Me.TextBoxDoc_Nurse_D.Size = New System.Drawing.Size(161, 22)
        Me.TextBoxDoc_Nurse_D.TabIndex = 0
        '
        'Doc_Nurse_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(303, 79)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Doc_Nurse_Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EnterDoc_Nurse_IDokbtn As Button
    Friend WithEvents TextBoxDoc_Nurse_D As TextBox
End Class
