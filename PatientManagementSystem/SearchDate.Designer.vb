<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchDate
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
        Me.SearchDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SerachDateOkbtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SearchDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.SerachDateOkbtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 101)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date"
        '
        'SearchDateTimePicker
        '
        Me.SearchDateTimePicker.CalendarFont = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Lime
        Me.SearchDateTimePicker.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchDateTimePicker.Location = New System.Drawing.Point(6, 27)
        Me.SearchDateTimePicker.Name = "SearchDateTimePicker"
        Me.SearchDateTimePicker.Size = New System.Drawing.Size(286, 26)
        Me.SearchDateTimePicker.TabIndex = 9
        '
        'SerachDateOkbtn
        '
        Me.SerachDateOkbtn.BackColor = System.Drawing.Color.Lime
        Me.SerachDateOkbtn.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerachDateOkbtn.ForeColor = System.Drawing.Color.Black
        Me.SerachDateOkbtn.Location = New System.Drawing.Point(113, 59)
        Me.SerachDateOkbtn.Name = "SerachDateOkbtn"
        Me.SerachDateOkbtn.Size = New System.Drawing.Size(70, 26)
        Me.SerachDateOkbtn.TabIndex = 8
        Me.SerachDateOkbtn.Text = "OK"
        Me.SerachDateOkbtn.UseVisualStyleBackColor = False
        '
        'SearchDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(322, 122)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SearchDate"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SearchDateTimePicker As DateTimePicker
    Friend WithEvents SerachDateOkbtn As Button
End Class
