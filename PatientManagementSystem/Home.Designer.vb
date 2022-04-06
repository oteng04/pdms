<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PatentInfo = New System.Windows.Forms.GroupBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Genderlbl = New System.Windows.Forms.Label()
        Me.Agelbl = New System.Windows.Forms.Label()
        Me.Othernamelbl = New System.Windows.Forms.Label()
        Me.Lastnamelbl = New System.Windows.Forms.Label()
        Me.Firstnamelbl = New System.Windows.Forms.Label()
        Me.PatientIDlbl = New System.Windows.Forms.Label()
        Me.WeightGb = New System.Windows.Forms.GroupBox()
        Me.weightlbl = New System.Windows.Forms.Label()
        Me.PulseGb = New System.Windows.Forms.GroupBox()
        Me.Pulselbl = New System.Windows.Forms.Label()
        Me.BloodPressureHGb = New System.Windows.Forms.GroupBox()
        Me.BloodPressureHlbl = New System.Windows.Forms.Label()
        Me.TemperatureGb = New System.Windows.Forms.GroupBox()
        Me.Temperaturelbl = New System.Windows.Forms.Label()
        Me.DateTimeGb = New System.Windows.Forms.GroupBox()
        Me.Timelbl = New System.Windows.Forms.Label()
        Me.Datelbl = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ButtonChart = New System.Windows.Forms.Button()
        Me.LabelSpecialistId = New System.Windows.Forms.Label()
        Me.DateTimeker1 = New System.Windows.Forms.DateTimePicker()
        Me.Dateker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonAllRecords = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Updatebtn = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBoxChart = New System.Windows.Forms.GroupBox()
        Me.GroupBoxNoData = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AllData = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.PatentInfo.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.WeightGb.SuspendLayout()
        Me.PulseGb.SuspendLayout()
        Me.BloodPressureHGb.SuspendLayout()
        Me.TemperatureGb.SuspendLayout()
        Me.DateTimeGb.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxNoData.SuspendLayout()
        CType(Me.AllData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PatentInfo)
        Me.SplitContainer1.Panel1.ForeColor = System.Drawing.Color.White
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelSpecialistId)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DateTimeker1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Dateker1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.ForeColor = System.Drawing.Color.White
        Me.SplitContainer1.Size = New System.Drawing.Size(909, 695)
        Me.SplitContainer1.SplitterDistance = 175
        Me.SplitContainer1.TabIndex = 0
        '
        'PatentInfo
        '
        Me.PatentInfo.BackColor = System.Drawing.Color.Transparent
        Me.PatentInfo.Controls.Add(Me.SplitContainer2)
        Me.PatentInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PatentInfo.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatentInfo.ForeColor = System.Drawing.Color.White
        Me.PatentInfo.Location = New System.Drawing.Point(0, 0)
        Me.PatentInfo.Name = "PatentInfo"
        Me.PatentInfo.Size = New System.Drawing.Size(175, 695)
        Me.PatentInfo.TabIndex = 0
        Me.PatentInfo.TabStop = False
        Me.PatentInfo.Text = "Patient Info"
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.Genderlbl)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Agelbl)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Othernamelbl)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Lastnamelbl)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Firstnamelbl)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PatientIDlbl)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.WeightGb)
        Me.SplitContainer2.Panel2.Controls.Add(Me.PulseGb)
        Me.SplitContainer2.Panel2.Controls.Add(Me.BloodPressureHGb)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TemperatureGb)
        Me.SplitContainer2.Panel2.Controls.Add(Me.DateTimeGb)
        Me.SplitContainer2.Size = New System.Drawing.Size(169, 674)
        Me.SplitContainer2.SplitterDistance = 244
        Me.SplitContainer2.TabIndex = 0
        '
        'Genderlbl
        '
        Me.Genderlbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.Genderlbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Genderlbl.Location = New System.Drawing.Point(0, 200)
        Me.Genderlbl.Name = "Genderlbl"
        Me.Genderlbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Genderlbl.Size = New System.Drawing.Size(169, 41)
        Me.Genderlbl.TabIndex = 5
        Me.Genderlbl.Text = "Sex"
        Me.Genderlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Agelbl
        '
        Me.Agelbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agelbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agelbl.Location = New System.Drawing.Point(0, 158)
        Me.Agelbl.Name = "Agelbl"
        Me.Agelbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Agelbl.Size = New System.Drawing.Size(169, 42)
        Me.Agelbl.TabIndex = 4
        Me.Agelbl.Text = "Age"
        Me.Agelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Othernamelbl
        '
        Me.Othernamelbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.Othernamelbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Othernamelbl.Location = New System.Drawing.Point(0, 116)
        Me.Othernamelbl.Name = "Othernamelbl"
        Me.Othernamelbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Othernamelbl.Size = New System.Drawing.Size(169, 42)
        Me.Othernamelbl.TabIndex = 3
        Me.Othernamelbl.Text = "Othername"
        Me.Othernamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lastnamelbl
        '
        Me.Lastnamelbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lastnamelbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lastnamelbl.Location = New System.Drawing.Point(0, 69)
        Me.Lastnamelbl.Name = "Lastnamelbl"
        Me.Lastnamelbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lastnamelbl.Size = New System.Drawing.Size(169, 47)
        Me.Lastnamelbl.TabIndex = 2
        Me.Lastnamelbl.Text = "Lastname"
        Me.Lastnamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Firstnamelbl
        '
        Me.Firstnamelbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.Firstnamelbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Firstnamelbl.Location = New System.Drawing.Point(0, 26)
        Me.Firstnamelbl.Margin = New System.Windows.Forms.Padding(3)
        Me.Firstnamelbl.Name = "Firstnamelbl"
        Me.Firstnamelbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Firstnamelbl.Size = New System.Drawing.Size(169, 43)
        Me.Firstnamelbl.TabIndex = 1
        Me.Firstnamelbl.Text = "Firstname"
        Me.Firstnamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PatientIDlbl
        '
        Me.PatientIDlbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.PatientIDlbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientIDlbl.Location = New System.Drawing.Point(0, 0)
        Me.PatientIDlbl.Name = "PatientIDlbl"
        Me.PatientIDlbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PatientIDlbl.Size = New System.Drawing.Size(169, 26)
        Me.PatientIDlbl.TabIndex = 0
        Me.PatientIDlbl.Text = "Patient ID"
        Me.PatientIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WeightGb
        '
        Me.WeightGb.Controls.Add(Me.weightlbl)
        Me.WeightGb.Dock = System.Windows.Forms.DockStyle.Top
        Me.WeightGb.ForeColor = System.Drawing.Color.Lime
        Me.WeightGb.Location = New System.Drawing.Point(0, 273)
        Me.WeightGb.Name = "WeightGb"
        Me.WeightGb.Size = New System.Drawing.Size(169, 58)
        Me.WeightGb.TabIndex = 5
        Me.WeightGb.TabStop = False
        Me.WeightGb.Text = "Weight"
        '
        'weightlbl
        '
        Me.weightlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.weightlbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weightlbl.ForeColor = System.Drawing.Color.White
        Me.weightlbl.Location = New System.Drawing.Point(3, 18)
        Me.weightlbl.Name = "weightlbl"
        Me.weightlbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.weightlbl.Size = New System.Drawing.Size(163, 37)
        Me.weightlbl.TabIndex = 10
        Me.weightlbl.Text = "Weight"
        Me.weightlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PulseGb
        '
        Me.PulseGb.Controls.Add(Me.Pulselbl)
        Me.PulseGb.Dock = System.Windows.Forms.DockStyle.Top
        Me.PulseGb.ForeColor = System.Drawing.Color.Lime
        Me.PulseGb.Location = New System.Drawing.Point(0, 209)
        Me.PulseGb.Name = "PulseGb"
        Me.PulseGb.Size = New System.Drawing.Size(169, 64)
        Me.PulseGb.TabIndex = 4
        Me.PulseGb.TabStop = False
        Me.PulseGb.Text = " Pulse"
        '
        'Pulselbl
        '
        Me.Pulselbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pulselbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pulselbl.ForeColor = System.Drawing.Color.White
        Me.Pulselbl.Location = New System.Drawing.Point(3, 18)
        Me.Pulselbl.Name = "Pulselbl"
        Me.Pulselbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Pulselbl.Size = New System.Drawing.Size(163, 43)
        Me.Pulselbl.TabIndex = 9
        Me.Pulselbl.Text = "Pulse"
        Me.Pulselbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BloodPressureHGb
        '
        Me.BloodPressureHGb.Controls.Add(Me.BloodPressureHlbl)
        Me.BloodPressureHGb.Dock = System.Windows.Forms.DockStyle.Top
        Me.BloodPressureHGb.ForeColor = System.Drawing.Color.Lime
        Me.BloodPressureHGb.Location = New System.Drawing.Point(0, 155)
        Me.BloodPressureHGb.Name = "BloodPressureHGb"
        Me.BloodPressureHGb.Size = New System.Drawing.Size(169, 54)
        Me.BloodPressureHGb.TabIndex = 2
        Me.BloodPressureHGb.TabStop = False
        Me.BloodPressureHGb.Text = "Blood Pressure"
        '
        'BloodPressureHlbl
        '
        Me.BloodPressureHlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BloodPressureHlbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodPressureHlbl.ForeColor = System.Drawing.Color.White
        Me.BloodPressureHlbl.Location = New System.Drawing.Point(3, 18)
        Me.BloodPressureHlbl.Name = "BloodPressureHlbl"
        Me.BloodPressureHlbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BloodPressureHlbl.Size = New System.Drawing.Size(163, 33)
        Me.BloodPressureHlbl.TabIndex = 9
        Me.BloodPressureHlbl.Text = "Blood pressure"
        Me.BloodPressureHlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TemperatureGb
        '
        Me.TemperatureGb.Controls.Add(Me.Temperaturelbl)
        Me.TemperatureGb.Dock = System.Windows.Forms.DockStyle.Top
        Me.TemperatureGb.ForeColor = System.Drawing.Color.Lime
        Me.TemperatureGb.Location = New System.Drawing.Point(0, 89)
        Me.TemperatureGb.Name = "TemperatureGb"
        Me.TemperatureGb.Size = New System.Drawing.Size(169, 66)
        Me.TemperatureGb.TabIndex = 1
        Me.TemperatureGb.TabStop = False
        Me.TemperatureGb.Text = "Body Temperature"
        '
        'Temperaturelbl
        '
        Me.Temperaturelbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Temperaturelbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Temperaturelbl.ForeColor = System.Drawing.Color.White
        Me.Temperaturelbl.Location = New System.Drawing.Point(3, 18)
        Me.Temperaturelbl.Name = "Temperaturelbl"
        Me.Temperaturelbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Temperaturelbl.Size = New System.Drawing.Size(163, 45)
        Me.Temperaturelbl.TabIndex = 8
        Me.Temperaturelbl.Text = "Temperature"
        Me.Temperaturelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimeGb
        '
        Me.DateTimeGb.Controls.Add(Me.Timelbl)
        Me.DateTimeGb.Controls.Add(Me.Datelbl)
        Me.DateTimeGb.Dock = System.Windows.Forms.DockStyle.Top
        Me.DateTimeGb.ForeColor = System.Drawing.Color.Lime
        Me.DateTimeGb.Location = New System.Drawing.Point(0, 0)
        Me.DateTimeGb.Name = "DateTimeGb"
        Me.DateTimeGb.Size = New System.Drawing.Size(169, 89)
        Me.DateTimeGb.TabIndex = 0
        Me.DateTimeGb.TabStop = False
        Me.DateTimeGb.Text = "Date and Time"
        '
        'Timelbl
        '
        Me.Timelbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.Timelbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timelbl.ForeColor = System.Drawing.Color.White
        Me.Timelbl.Location = New System.Drawing.Point(3, 47)
        Me.Timelbl.Name = "Timelbl"
        Me.Timelbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Timelbl.Size = New System.Drawing.Size(163, 29)
        Me.Timelbl.TabIndex = 7
        Me.Timelbl.Text = "Time"
        Me.Timelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Datelbl
        '
        Me.Datelbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.Datelbl.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datelbl.ForeColor = System.Drawing.Color.White
        Me.Datelbl.Location = New System.Drawing.Point(3, 18)
        Me.Datelbl.Name = "Datelbl"
        Me.Datelbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Datelbl.Size = New System.Drawing.Size(163, 29)
        Me.Datelbl.TabIndex = 6
        Me.Datelbl.Text = "Date"
        Me.Datelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ButtonChart)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox6.Location = New System.Drawing.Point(474, 630)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(128, 65)
        Me.GroupBox6.TabIndex = 35
        Me.GroupBox6.TabStop = False
        '
        'ButtonChart
        '
        Me.ButtonChart.BackColor = System.Drawing.Color.Lime
        Me.ButtonChart.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonChart.ForeColor = System.Drawing.Color.Black
        Me.ButtonChart.Location = New System.Drawing.Point(21, 19)
        Me.ButtonChart.Name = "ButtonChart"
        Me.ButtonChart.Size = New System.Drawing.Size(85, 40)
        Me.ButtonChart.TabIndex = 4
        Me.ButtonChart.Tag = "3"
        Me.ButtonChart.Text = "Chart"
        Me.ButtonChart.UseVisualStyleBackColor = False
        '
        'LabelSpecialistId
        '
        Me.LabelSpecialistId.AutoSize = True
        Me.LabelSpecialistId.Location = New System.Drawing.Point(494, 636)
        Me.LabelSpecialistId.Name = "LabelSpecialistId"
        Me.LabelSpecialistId.Size = New System.Drawing.Size(0, 13)
        Me.LabelSpecialistId.TabIndex = 34
        Me.LabelSpecialistId.Visible = False
        '
        'DateTimeker1
        '
        Me.DateTimeker1.Location = New System.Drawing.Point(401, 636)
        Me.DateTimeker1.Name = "DateTimeker1"
        Me.DateTimeker1.Size = New System.Drawing.Size(24, 20)
        Me.DateTimeker1.TabIndex = 10
        Me.DateTimeker1.Visible = False
        '
        'Dateker1
        '
        Me.Dateker1.Location = New System.Drawing.Point(401, 662)
        Me.Dateker1.Name = "Dateker1"
        Me.Dateker1.Size = New System.Drawing.Size(32, 20)
        Me.Dateker1.TabIndex = 9
        Me.Dateker1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonAllRecords)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Location = New System.Drawing.Point(602, 630)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 65)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'ButtonAllRecords
        '
        Me.ButtonAllRecords.BackColor = System.Drawing.Color.Lime
        Me.ButtonAllRecords.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAllRecords.ForeColor = System.Drawing.Color.Black
        Me.ButtonAllRecords.Location = New System.Drawing.Point(21, 19)
        Me.ButtonAllRecords.Name = "ButtonAllRecords"
        Me.ButtonAllRecords.Size = New System.Drawing.Size(85, 40)
        Me.ButtonAllRecords.TabIndex = 4
        Me.ButtonAllRecords.Tag = "3"
        Me.ButtonAllRecords.Text = "All Records"
        Me.ButtonAllRecords.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Updatebtn)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox5.Location = New System.Drawing.Point(256, 630)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(128, 65)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        '
        'Updatebtn
        '
        Me.Updatebtn.BackColor = System.Drawing.Color.Lime
        Me.Updatebtn.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updatebtn.ForeColor = System.Drawing.Color.Black
        Me.Updatebtn.Location = New System.Drawing.Point(25, 19)
        Me.Updatebtn.Name = "Updatebtn"
        Me.Updatebtn.Size = New System.Drawing.Size(88, 33)
        Me.Updatebtn.TabIndex = 4
        Me.Updatebtn.Tag = "3"
        Me.Updatebtn.Text = "Update"
        Me.Updatebtn.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Searchbtn)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox4.Location = New System.Drawing.Point(128, 630)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(128, 65)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        '
        'Searchbtn
        '
        Me.Searchbtn.BackColor = System.Drawing.Color.Lime
        Me.Searchbtn.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Searchbtn.ForeColor = System.Drawing.Color.Black
        Me.Searchbtn.Location = New System.Drawing.Point(21, 19)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(88, 33)
        Me.Searchbtn.TabIndex = 2
        Me.Searchbtn.Tag = "2"
        Me.Searchbtn.Text = "Search"
        Me.Searchbtn.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Addbtn)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Location = New System.Drawing.Point(0, 630)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(128, 65)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'Addbtn
        '
        Me.Addbtn.BackColor = System.Drawing.Color.Lime
        Me.Addbtn.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addbtn.ForeColor = System.Drawing.Color.Black
        Me.Addbtn.Location = New System.Drawing.Point(20, 19)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(88, 33)
        Me.Addbtn.TabIndex = 3
        Me.Addbtn.Tag = "1"
        Me.Addbtn.Text = "Add"
        Me.Addbtn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBoxChart)
        Me.GroupBox1.Controls.Add(Me.GroupBoxNoData)
        Me.GroupBox1.Controls.Add(Me.AllData)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(730, 630)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBoxChart
        '
        Me.GroupBoxChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxChart.Location = New System.Drawing.Point(3, 18)
        Me.GroupBoxChart.Name = "GroupBoxChart"
        Me.GroupBoxChart.Size = New System.Drawing.Size(724, 609)
        Me.GroupBoxChart.TabIndex = 1
        Me.GroupBoxChart.TabStop = False
        '
        'GroupBoxNoData
        '
        Me.GroupBoxNoData.Controls.Add(Me.Label1)
        Me.GroupBoxNoData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxNoData.ForeColor = System.Drawing.Color.White
        Me.GroupBoxNoData.Location = New System.Drawing.Point(3, 18)
        Me.GroupBoxNoData.Name = "GroupBoxNoData"
        Me.GroupBoxNoData.Size = New System.Drawing.Size(724, 609)
        Me.GroupBoxNoData.TabIndex = 6
        Me.GroupBoxNoData.TabStop = False
        Me.GroupBoxNoData.Visible = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(718, 588)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Data"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AllData
        '
        Me.AllData.AllowUserToAddRows = False
        Me.AllData.AllowUserToDeleteRows = False
        Me.AllData.AllowUserToResizeColumns = False
        Me.AllData.AllowUserToResizeRows = False
        Me.AllData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AllData.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AllData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AllData.DefaultCellStyle = DataGridViewCellStyle2
        Me.AllData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AllData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.AllData.GridColor = System.Drawing.Color.Black
        Me.AllData.Location = New System.Drawing.Point(3, 18)
        Me.AllData.Name = "AllData"
        Me.AllData.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AllData.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.AllData.RowTemplate.ReadOnly = True
        Me.AllData.ShowCellErrors = False
        Me.AllData.ShowCellToolTips = False
        Me.AllData.ShowEditingIcon = False
        Me.AllData.ShowRowErrors = False
        Me.AllData.Size = New System.Drawing.Size(724, 609)
        Me.AllData.TabIndex = 5
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(909, 695)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.Name = "Home"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.PatentInfo.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.WeightGb.ResumeLayout(False)
        Me.PulseGb.ResumeLayout(False)
        Me.BloodPressureHGb.ResumeLayout(False)
        Me.TemperatureGb.ResumeLayout(False)
        Me.DateTimeGb.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBoxNoData.ResumeLayout(False)
        CType(Me.AllData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PatentInfo As GroupBox
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Firstnamelbl As Label
    Friend WithEvents PatientIDlbl As Label
    Friend WithEvents Genderlbl As Label
    Friend WithEvents Agelbl As Label
    Friend WithEvents Othernamelbl As Label
    Friend WithEvents Lastnamelbl As Label
    Friend WithEvents BloodPressureHGb As GroupBox
    Friend WithEvents TemperatureGb As GroupBox
    Friend WithEvents DateTimeGb As GroupBox
    Friend WithEvents WeightGb As GroupBox
    Friend WithEvents PulseGb As GroupBox
    Friend WithEvents Timelbl As Label
    Friend WithEvents Datelbl As Label
    Friend WithEvents Pulselbl As Label
    Friend WithEvents BloodPressureHlbl As Label
    Friend WithEvents Temperaturelbl As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AllData As DataGridView
    Friend WithEvents Searchbtn As Button
    Friend WithEvents Updatebtn As Button
    Friend WithEvents Addbtn As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents weightlbl As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonAllRecords As Button
    Friend WithEvents Dateker1 As DateTimePicker
    Friend WithEvents DateTimeker1 As DateTimePicker
    Friend WithEvents LabelSpecialistId As Label
    Friend WithEvents GroupBoxNoData As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents ButtonChart As Button
    Friend WithEvents GroupBoxChart As GroupBox
End Class
