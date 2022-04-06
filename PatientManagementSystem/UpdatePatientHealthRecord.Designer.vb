<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdatePatientHealthRecord
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.updateGenderlbl = New System.Windows.Forms.Label()
        Me.updateAgelbl = New System.Windows.Forms.Label()
        Me.updateOthernamelbl = New System.Windows.Forms.Label()
        Me.updateLastnamelbl = New System.Windows.Forms.Label()
        Me.updateFirstnamelbl = New System.Windows.Forms.Label()
        Me.updatePatientIDlbl = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.update_DeleteBtn1 = New System.Windows.Forms.Button()
        Me.update_Updatebtn1 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxWeight_updatePoint = New System.Windows.Forms.TextBox()
        Me.TextBoxWeight_update = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxPulse_updatePoint = New System.Windows.Forms.TextBox()
        Me.TextBoxPulse_update = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBoxBPL_update = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBoxBPH_update = New System.Windows.Forms.TextBox()
        Me.TemperatureGb = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxTemperature_UpdatePoint = New System.Windows.Forms.TextBox()
        Me.TextBoxTemperature_Update = New System.Windows.Forms.TextBox()
        Me.updateDateTimeGb = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ttime = New System.Windows.Forms.Label()
        Me.wwei = New System.Windows.Forms.Label()
        Me.ttemp = New System.Windows.Forms.Label()
        Me.ppulse = New System.Windows.Forms.Label()
        Me.RecID = New System.Windows.Forms.Label()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.RecordIDlbl = New System.Windows.Forms.Label()
        Me.DateTimek = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.EnterPatientID_Update2okbtn = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBoxNoData = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewUpdateRecords = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TemperatureGb.SuspendLayout()
        Me.updateDateTimeGb.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBoxNoData.SuspendLayout()
        CType(Me.DataGridViewUpdateRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ttime)
        Me.SplitContainer1.Panel2.Controls.Add(Me.wwei)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ttemp)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ppulse)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RecID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DateTimePicker4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RecordIDlbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DateTimek)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(984, 691)
        Me.SplitContainer1.SplitterDistance = 189
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SplitContainer2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 691)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Info"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 18)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.updateGenderlbl)
        Me.SplitContainer2.Panel1.Controls.Add(Me.updateAgelbl)
        Me.SplitContainer2.Panel1.Controls.Add(Me.updateOthernamelbl)
        Me.SplitContainer2.Panel1.Controls.Add(Me.updateLastnamelbl)
        Me.SplitContainer2.Panel1.Controls.Add(Me.updateFirstnamelbl)
        Me.SplitContainer2.Panel1.Controls.Add(Me.updatePatientIDlbl)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox8)
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox7)
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox6)
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox5)
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TemperatureGb)
        Me.SplitContainer2.Panel2.Controls.Add(Me.updateDateTimeGb)
        Me.SplitContainer2.Size = New System.Drawing.Size(183, 670)
        Me.SplitContainer2.SplitterDistance = 210
        Me.SplitContainer2.TabIndex = 0
        '
        'updateGenderlbl
        '
        Me.updateGenderlbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.updateGenderlbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateGenderlbl.Location = New System.Drawing.Point(0, 170)
        Me.updateGenderlbl.Name = "updateGenderlbl"
        Me.updateGenderlbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.updateGenderlbl.Size = New System.Drawing.Size(183, 40)
        Me.updateGenderlbl.TabIndex = 6
        Me.updateGenderlbl.Text = "Sex"
        Me.updateGenderlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'updateAgelbl
        '
        Me.updateAgelbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.updateAgelbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateAgelbl.Location = New System.Drawing.Point(0, 139)
        Me.updateAgelbl.Name = "updateAgelbl"
        Me.updateAgelbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.updateAgelbl.Size = New System.Drawing.Size(183, 31)
        Me.updateAgelbl.TabIndex = 5
        Me.updateAgelbl.Text = "Age"
        Me.updateAgelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'updateOthernamelbl
        '
        Me.updateOthernamelbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.updateOthernamelbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateOthernamelbl.Location = New System.Drawing.Point(0, 106)
        Me.updateOthernamelbl.Name = "updateOthernamelbl"
        Me.updateOthernamelbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.updateOthernamelbl.Size = New System.Drawing.Size(183, 33)
        Me.updateOthernamelbl.TabIndex = 4
        Me.updateOthernamelbl.Text = "Othername"
        Me.updateOthernamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'updateLastnamelbl
        '
        Me.updateLastnamelbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.updateLastnamelbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateLastnamelbl.Location = New System.Drawing.Point(0, 66)
        Me.updateLastnamelbl.Name = "updateLastnamelbl"
        Me.updateLastnamelbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.updateLastnamelbl.Size = New System.Drawing.Size(183, 40)
        Me.updateLastnamelbl.TabIndex = 3
        Me.updateLastnamelbl.Text = "Lastname"
        Me.updateLastnamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'updateFirstnamelbl
        '
        Me.updateFirstnamelbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.updateFirstnamelbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateFirstnamelbl.Location = New System.Drawing.Point(0, 26)
        Me.updateFirstnamelbl.Margin = New System.Windows.Forms.Padding(3)
        Me.updateFirstnamelbl.Name = "updateFirstnamelbl"
        Me.updateFirstnamelbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.updateFirstnamelbl.Size = New System.Drawing.Size(183, 40)
        Me.updateFirstnamelbl.TabIndex = 2
        Me.updateFirstnamelbl.Text = "Firstname"
        Me.updateFirstnamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'updatePatientIDlbl
        '
        Me.updatePatientIDlbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.updatePatientIDlbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatePatientIDlbl.Location = New System.Drawing.Point(0, 0)
        Me.updatePatientIDlbl.Name = "updatePatientIDlbl"
        Me.updatePatientIDlbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.updatePatientIDlbl.Size = New System.Drawing.Size(183, 26)
        Me.updatePatientIDlbl.TabIndex = 1
        Me.updatePatientIDlbl.Text = "Patient ID"
        Me.updatePatientIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.update_DeleteBtn1)
        Me.GroupBox8.Controls.Add(Me.update_Updatebtn1)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox8.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox8.Location = New System.Drawing.Point(0, 403)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(183, 53)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        '
        'update_DeleteBtn1
        '
        Me.update_DeleteBtn1.BackColor = System.Drawing.Color.Red
        Me.update_DeleteBtn1.Dock = System.Windows.Forms.DockStyle.Left
        Me.update_DeleteBtn1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_DeleteBtn1.ForeColor = System.Drawing.Color.Black
        Me.update_DeleteBtn1.Location = New System.Drawing.Point(3, 18)
        Me.update_DeleteBtn1.Name = "update_DeleteBtn1"
        Me.update_DeleteBtn1.Size = New System.Drawing.Size(88, 32)
        Me.update_DeleteBtn1.TabIndex = 6
        Me.update_DeleteBtn1.Text = "Delete"
        Me.update_DeleteBtn1.UseVisualStyleBackColor = False
        '
        'update_Updatebtn1
        '
        Me.update_Updatebtn1.BackColor = System.Drawing.Color.Lime
        Me.update_Updatebtn1.Dock = System.Windows.Forms.DockStyle.Right
        Me.update_Updatebtn1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_Updatebtn1.ForeColor = System.Drawing.Color.Black
        Me.update_Updatebtn1.Location = New System.Drawing.Point(92, 18)
        Me.update_Updatebtn1.Name = "update_Updatebtn1"
        Me.update_Updatebtn1.Size = New System.Drawing.Size(88, 32)
        Me.update_Updatebtn1.TabIndex = 5
        Me.update_Updatebtn1.Text = "Update"
        Me.update_Updatebtn1.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.TextBoxWeight_updatePoint)
        Me.GroupBox7.Controls.Add(Me.TextBoxWeight_update)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox7.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox7.Location = New System.Drawing.Point(0, 281)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(183, 55)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Weight"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(113, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 21)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxWeight_updatePoint
        '
        Me.TextBoxWeight_updatePoint.Dock = System.Windows.Forms.DockStyle.Right
        Me.TextBoxWeight_updatePoint.Location = New System.Drawing.Point(129, 18)
        Me.TextBoxWeight_updatePoint.MaxLength = 2
        Me.TextBoxWeight_updatePoint.Name = "TextBoxWeight_updatePoint"
        Me.TextBoxWeight_updatePoint.Size = New System.Drawing.Size(51, 22)
        Me.TextBoxWeight_updatePoint.TabIndex = 3
        Me.TextBoxWeight_updatePoint.Text = "00"
        Me.TextBoxWeight_updatePoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxWeight_update
        '
        Me.TextBoxWeight_update.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxWeight_update.Location = New System.Drawing.Point(3, 18)
        Me.TextBoxWeight_update.MaxLength = 3
        Me.TextBoxWeight_update.Name = "TextBoxWeight_update"
        Me.TextBoxWeight_update.Size = New System.Drawing.Size(177, 22)
        Me.TextBoxWeight_update.TabIndex = 0
        Me.TextBoxWeight_update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.TextBoxPulse_updatePoint)
        Me.GroupBox6.Controls.Add(Me.TextBoxPulse_update)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox6.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox6.Location = New System.Drawing.Point(0, 226)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(183, 55)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Pulse"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(113, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 21)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxPulse_updatePoint
        '
        Me.TextBoxPulse_updatePoint.Dock = System.Windows.Forms.DockStyle.Right
        Me.TextBoxPulse_updatePoint.Location = New System.Drawing.Point(129, 18)
        Me.TextBoxPulse_updatePoint.MaxLength = 2
        Me.TextBoxPulse_updatePoint.Name = "TextBoxPulse_updatePoint"
        Me.TextBoxPulse_updatePoint.Size = New System.Drawing.Size(51, 22)
        Me.TextBoxPulse_updatePoint.TabIndex = 2
        Me.TextBoxPulse_updatePoint.Text = "00"
        Me.TextBoxPulse_updatePoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxPulse_update
        '
        Me.TextBoxPulse_update.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxPulse_update.Location = New System.Drawing.Point(3, 18)
        Me.TextBoxPulse_update.MaxLength = 3
        Me.TextBoxPulse_update.Name = "TextBoxPulse_update"
        Me.TextBoxPulse_update.Size = New System.Drawing.Size(177, 22)
        Me.TextBoxPulse_update.TabIndex = 0
        Me.TextBoxPulse_update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TextBoxBPL_update)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox5.Location = New System.Drawing.Point(0, 171)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(183, 55)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "BP (Diastoric)"
        '
        'TextBoxBPL_update
        '
        Me.TextBoxBPL_update.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxBPL_update.Location = New System.Drawing.Point(3, 18)
        Me.TextBoxBPL_update.MaxLength = 2
        Me.TextBoxBPL_update.Name = "TextBoxBPL_update"
        Me.TextBoxBPL_update.Size = New System.Drawing.Size(177, 22)
        Me.TextBoxBPL_update.TabIndex = 0
        Me.TextBoxBPL_update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBoxBPH_update)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox4.Location = New System.Drawing.Point(0, 116)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(183, 55)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "BP (Systoric)"
        '
        'TextBoxBPH_update
        '
        Me.TextBoxBPH_update.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxBPH_update.Location = New System.Drawing.Point(3, 18)
        Me.TextBoxBPH_update.MaxLength = 3
        Me.TextBoxBPH_update.Name = "TextBoxBPH_update"
        Me.TextBoxBPH_update.Size = New System.Drawing.Size(177, 22)
        Me.TextBoxBPH_update.TabIndex = 0
        Me.TextBoxBPH_update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TemperatureGb
        '
        Me.TemperatureGb.Controls.Add(Me.Label12)
        Me.TemperatureGb.Controls.Add(Me.TextBoxTemperature_UpdatePoint)
        Me.TemperatureGb.Controls.Add(Me.TextBoxTemperature_Update)
        Me.TemperatureGb.Dock = System.Windows.Forms.DockStyle.Top
        Me.TemperatureGb.ForeColor = System.Drawing.Color.Lime
        Me.TemperatureGb.Location = New System.Drawing.Point(0, 67)
        Me.TemperatureGb.Name = "TemperatureGb"
        Me.TemperatureGb.Size = New System.Drawing.Size(183, 49)
        Me.TemperatureGb.TabIndex = 2
        Me.TemperatureGb.TabStop = False
        Me.TemperatureGb.Text = "Body Temperature"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label12.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(113, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 21)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxTemperature_UpdatePoint
        '
        Me.TextBoxTemperature_UpdatePoint.Dock = System.Windows.Forms.DockStyle.Right
        Me.TextBoxTemperature_UpdatePoint.Location = New System.Drawing.Point(129, 18)
        Me.TextBoxTemperature_UpdatePoint.MaxLength = 1
        Me.TextBoxTemperature_UpdatePoint.Name = "TextBoxTemperature_UpdatePoint"
        Me.TextBoxTemperature_UpdatePoint.Size = New System.Drawing.Size(51, 22)
        Me.TextBoxTemperature_UpdatePoint.TabIndex = 1
        Me.TextBoxTemperature_UpdatePoint.Text = "0"
        Me.TextBoxTemperature_UpdatePoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxTemperature_Update
        '
        Me.TextBoxTemperature_Update.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxTemperature_Update.Location = New System.Drawing.Point(3, 18)
        Me.TextBoxTemperature_Update.MaxLength = 2
        Me.TextBoxTemperature_Update.Name = "TextBoxTemperature_Update"
        Me.TextBoxTemperature_Update.Size = New System.Drawing.Size(177, 22)
        Me.TextBoxTemperature_Update.TabIndex = 0
        Me.TextBoxTemperature_Update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'updateDateTimeGb
        '
        Me.updateDateTimeGb.Controls.Add(Me.TextBox2)
        Me.updateDateTimeGb.Controls.Add(Me.TextBox1)
        Me.updateDateTimeGb.Controls.Add(Me.DateTimePicker3)
        Me.updateDateTimeGb.Controls.Add(Me.DateTimePicker1)
        Me.updateDateTimeGb.Dock = System.Windows.Forms.DockStyle.Top
        Me.updateDateTimeGb.ForeColor = System.Drawing.Color.Lime
        Me.updateDateTimeGb.Location = New System.Drawing.Point(0, 0)
        Me.updateDateTimeGb.Name = "updateDateTimeGb"
        Me.updateDateTimeGb.Size = New System.Drawing.Size(183, 67)
        Me.updateDateTimeGb.TabIndex = 1
        Me.updateDateTimeGb.TabStop = False
        Me.updateDateTimeGb.Text = "Date  & Time"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Black
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox2.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(3, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(177, 25)
        Me.TextBox2.TabIndex = 39
        Me.TextBox2.Text = "Time"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox1.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(3, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(177, 25)
        Me.TextBox1.TabIndex = 38
        Me.TextBox1.Text = "Date"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DateTimePicker3.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Location = New System.Drawing.Point(3, 38)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(177, 26)
        Me.DateTimePicker3.TabIndex = 37
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DateTimePicker1.Location = New System.Drawing.Point(3, 18)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(177, 22)
        Me.DateTimePicker1.TabIndex = 8
        '
        'ttime
        '
        Me.ttime.AutoSize = True
        Me.ttime.ForeColor = System.Drawing.Color.Lime
        Me.ttime.Location = New System.Drawing.Point(299, 640)
        Me.ttime.Name = "ttime"
        Me.ttime.Size = New System.Drawing.Size(39, 13)
        Me.ttime.TabIndex = 13
        Me.ttime.Text = "Label1"
        Me.ttime.Visible = False
        '
        'wwei
        '
        Me.wwei.AutoSize = True
        Me.wwei.ForeColor = System.Drawing.Color.Lime
        Me.wwei.Location = New System.Drawing.Point(389, 618)
        Me.wwei.Name = "wwei"
        Me.wwei.Size = New System.Drawing.Size(39, 13)
        Me.wwei.TabIndex = 12
        Me.wwei.Text = "Label1"
        Me.wwei.Visible = False
        '
        'ttemp
        '
        Me.ttemp.AutoSize = True
        Me.ttemp.ForeColor = System.Drawing.Color.Lime
        Me.ttemp.Location = New System.Drawing.Point(344, 618)
        Me.ttemp.Name = "ttemp"
        Me.ttemp.Size = New System.Drawing.Size(39, 13)
        Me.ttemp.TabIndex = 11
        Me.ttemp.Text = "Label1"
        Me.ttemp.Visible = False
        '
        'ppulse
        '
        Me.ppulse.AutoSize = True
        Me.ppulse.ForeColor = System.Drawing.Color.Lime
        Me.ppulse.Location = New System.Drawing.Point(299, 618)
        Me.ppulse.Name = "ppulse"
        Me.ppulse.Size = New System.Drawing.Size(39, 13)
        Me.ppulse.TabIndex = 10
        Me.ppulse.Text = "Label1"
        Me.ppulse.Visible = False
        '
        'RecID
        '
        Me.RecID.AutoSize = True
        Me.RecID.ForeColor = System.Drawing.Color.Lime
        Me.RecID.Location = New System.Drawing.Point(590, 653)
        Me.RecID.Name = "RecID"
        Me.RecID.Size = New System.Drawing.Size(39, 13)
        Me.RecID.TabIndex = 9
        Me.RecID.Text = "Label1"
        Me.RecID.Visible = False
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Location = New System.Drawing.Point(441, 634)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(109, 20)
        Me.DateTimePicker4.TabIndex = 8
        Me.DateTimePicker4.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(441, 665)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(109, 20)
        Me.DateTimePicker2.TabIndex = 7
        Me.DateTimePicker2.Visible = False
        '
        'RecordIDlbl
        '
        Me.RecordIDlbl.AutoSize = True
        Me.RecordIDlbl.Location = New System.Drawing.Point(479, 641)
        Me.RecordIDlbl.Name = "RecordIDlbl"
        Me.RecordIDlbl.Size = New System.Drawing.Size(0, 13)
        Me.RecordIDlbl.TabIndex = 4
        '
        'DateTimek
        '
        Me.DateTimek.Location = New System.Drawing.Point(332, 665)
        Me.DateTimek.Name = "DateTimek"
        Me.DateTimek.Size = New System.Drawing.Size(92, 20)
        Me.DateTimek.TabIndex = 1
        Me.DateTimek.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.EnterPatientID_Update2okbtn)
        Me.GroupBox3.Controls.Add(Me.TextBoxSearch)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(0, 615)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(284, 76)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Patient ID"
        '
        'EnterPatientID_Update2okbtn
        '
        Me.EnterPatientID_Update2okbtn.BackColor = System.Drawing.Color.Lime
        Me.EnterPatientID_Update2okbtn.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterPatientID_Update2okbtn.ForeColor = System.Drawing.Color.Black
        Me.EnterPatientID_Update2okbtn.Location = New System.Drawing.Point(187, 32)
        Me.EnterPatientID_Update2okbtn.Name = "EnterPatientID_Update2okbtn"
        Me.EnterPatientID_Update2okbtn.Size = New System.Drawing.Size(73, 27)
        Me.EnterPatientID_Update2okbtn.TabIndex = 32
        Me.EnterPatientID_Update2okbtn.Text = "Search"
        Me.EnterPatientID_Update2okbtn.UseVisualStyleBackColor = False
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(28, 32)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(144, 26)
        Me.TextBoxSearch.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBoxNoData)
        Me.GroupBox2.Controls.Add(Me.DataGridViewUpdateRecords)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(791, 615)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'GroupBoxNoData
        '
        Me.GroupBoxNoData.Controls.Add(Me.Label2)
        Me.GroupBoxNoData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxNoData.ForeColor = System.Drawing.Color.White
        Me.GroupBoxNoData.Location = New System.Drawing.Point(3, 18)
        Me.GroupBoxNoData.Name = "GroupBoxNoData"
        Me.GroupBoxNoData.Size = New System.Drawing.Size(785, 594)
        Me.GroupBoxNoData.TabIndex = 12
        Me.GroupBoxNoData.TabStop = False
        Me.GroupBoxNoData.Visible = False
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(779, 573)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Data"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewUpdateRecords
        '
        Me.DataGridViewUpdateRecords.AllowUserToAddRows = False
        Me.DataGridViewUpdateRecords.AllowUserToDeleteRows = False
        Me.DataGridViewUpdateRecords.AllowUserToResizeColumns = False
        Me.DataGridViewUpdateRecords.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewUpdateRecords.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewUpdateRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewUpdateRecords.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewUpdateRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewUpdateRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewUpdateRecords.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewUpdateRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewUpdateRecords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewUpdateRecords.GridColor = System.Drawing.Color.Black
        Me.DataGridViewUpdateRecords.Location = New System.Drawing.Point(3, 18)
        Me.DataGridViewUpdateRecords.Name = "DataGridViewUpdateRecords"
        Me.DataGridViewUpdateRecords.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewUpdateRecords.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewUpdateRecords.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewUpdateRecords.RowTemplate.ReadOnly = True
        Me.DataGridViewUpdateRecords.Size = New System.Drawing.Size(785, 594)
        Me.DataGridViewUpdateRecords.TabIndex = 0
        '
        'UpdatePatientHealthRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(984, 691)
        Me.Controls.Add(Me.SplitContainer1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "UpdatePatientHealthRecord"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TemperatureGb.ResumeLayout(False)
        Me.TemperatureGb.PerformLayout()
        Me.updateDateTimeGb.ResumeLayout(False)
        Me.updateDateTimeGb.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBoxNoData.ResumeLayout(False)
        CType(Me.DataGridViewUpdateRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewUpdateRecords As DataGridView
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents EnterPatientID_Update2okbtn As Button
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents updatePatientIDlbl As Label
    Friend WithEvents updateFirstnamelbl As Label
    Friend WithEvents updateLastnamelbl As Label
    Friend WithEvents updateOthernamelbl As Label
    Friend WithEvents updateAgelbl As Label
    Friend WithEvents updateGenderlbl As Label
    Friend WithEvents TemperatureGb As GroupBox
    Friend WithEvents TextBoxTemperature_Update As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TextBoxWeight_update As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TextBoxPulse_update As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents update_DeleteBtn1 As Button
    Friend WithEvents update_Updatebtn1 As Button
    Friend WithEvents updateDateTimeGb As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimek As DateTimePicker
    Friend WithEvents RecordIDlbl As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBoxBPL_update As TextBox
    Friend WithEvents TextBoxBPH_update As TextBox
    Friend WithEvents GroupBoxNoData As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RecID As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBoxTemperature_UpdatePoint As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxWeight_updatePoint As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxPulse_updatePoint As TextBox
    Friend WithEvents wwei As Label
    Friend WithEvents ttemp As Label
    Friend WithEvents ppulse As Label
    Friend WithEvents ttime As Label
End Class
