Public Class UpdatePatientHealthRecord

    Dim patientFirstname As String
    Dim patientLastname As String
    Dim patientOthername As String
    Dim patientDOB4Age As String
    Dim patientSex As String
    Dim patientContact As String
    Dim recordIdSelect As String
    Dim patientRecordDelete As String
    Dim selectAllRecords As String
    Dim selectAllRecords1 As String
    Dim selectAllRecords2 As String
    Dim selectAllRecords3 As String
    Dim patientRecordUpdate As String
    Dim patientRecordSelect3 As String
    Dim patientRecordDataTable3 As DataTable
    Dim patientRecordSelectAll As String


    Private Sub SplitContainer2_Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUpdateRecords.CellContentClick

    End Sub
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True

            Me.Hide()
            Home.Show()

        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Dim bhandled As Boolean = False



        Select Case keyData
            Case Keys.Escape

                Me.Close()
                bhandled = True


            Case Keys.Home
                Home.Show()
                Me.Hide()
                Dim Msg1 As String
                Msg1 = MessageBox.Show("Are you sure you would like to exit?", "", MessageBoxButtons.YesNo)
                If Msg1 = DialogResult.Yes Then
                    Application.Exit()
                End If
                Me.Close()

                bhandled = True






        End Select
        Return False
    End Function



    Private Sub EnterPatientID_Update2okbtn_Paint(sender As Object, e As PaintEventArgs) Handles EnterPatientID_Update2okbtn.Paint
        Home.buttonBorderRadius(sender, 20)

    End Sub

    Private Sub Timelbl_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub update_Updatebtn1_Paint(sender As Object, e As PaintEventArgs) Handles update_Updatebtn1.Paint
        Home.buttonBorderRadius(sender, 30)
    End Sub

    Private Sub update_DeleteBtn1_Paint(sender As Object, e As PaintEventArgs) Handles update_DeleteBtn1.Paint
        Home.buttonBorderRadius(sender, 30)
    End Sub

    Private Sub DataGridViewUpdateRecords_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUpdateRecords.RowEnter
        'updatePatientIDlbl.Text = DataGridViewUpdateRecords.SelectedRows(0).Cells(1).Value.ToString
    End Sub

    Private Sub UpdatePatientHealthRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RecID.Text = "AARON"


        TextBoxTemperature_Update.Select()

        DateTimePicker3.Format = DateTimePickerFormat.Time
        DateTimePicker3.CustomFormat = "HH:mm tt"


        DateTimePicker3.ShowUpDown = True



        DateTimePicker4.Format = DateTimePickerFormat.Time
        DateTimePicker4.ShowUpDown = True

    End Sub

    Private Sub TextBoxTemperature_Update_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxTemperature_Update.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxTemperature_UpdatePoint.Select()
        End If
    End Sub

    Private Sub TextBoxBPH_update_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxBPH_update.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxBPL_update.Select()
        End If
    End Sub

    Private Sub TextBoxBPL_update_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxBPL_update.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxPulse_update.Select()
        End If
    End Sub

    Private Sub TextBoxPulse_update_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPulse_update.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxPulse_updatePoint.Select()
        End If
    End Sub

    Private Sub TextBoxWeight_update_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxWeight_update.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxWeight_updatePoint.Select()
        End If
    End Sub

    Private Sub selectFromPatient()






        patientFirstname = "select Firstname From Patient Where Patient_ID = '" & updatePatientIDlbl.Text & "' "
        Patient_Table(patientFirstname)
        getLabelText(patientFirstname, updateLastnamelbl)

        patientLastname = "select Lastname From Patient Where Patient_ID = '" & updatePatientIDlbl.Text & "' "
        Patient_Table(patientLastname)
        getLabelText(patientLastname, updateFirstnamelbl)


        patientOthername = "select Othername From Patient Where Patient_ID = '" & updatePatientIDlbl.Text & "' "
        Patient_Table(patientOthername)
        getLabelText(patientOthername, updateOthernamelbl)

        patientSex = "select Sex From Patient Where Patient_ID = '" & updatePatientIDlbl.Text & "' "
        Patient_Table(patientSex)
        getLabelText(patientSex, updateGenderlbl)


        patientDOB4Age = "select Date_Of_Birth From Patient Where Patient_ID = '" & updatePatientIDlbl.Text & "' "
        Patient_Table(patientDOB4Age)
        getDateTimePickerText(patientDOB4Age, DateTimek)

        Dim year As Integer = DateDiff(DateInterval.Year, DateTimek.Value, Now)
        Dim month As Integer = DateDiff(DateInterval.Month, DateTimek.Value, Now) Mod 12
        Dim day As Integer = DateDiff(DateInterval.Day, DateTimek.Value, Now) Mod 30 - 10
        If year > 0 Then
            If year = 1 Then
                updateAgelbl.Text = year & " year"
            Else
                updateAgelbl.Text = year & " years"

            End If

        ElseIf year = 0 Then
            If month = 1 Then
                updateAgelbl.Text = month & " month"
            ElseIf month > 1
                updateAgelbl.Text = month & " months"
            ElseIf month = 0 And year = 0 Then
                If day = 1 Then
                    updateAgelbl.Text = day & " day"
                ElseIf day > 1 Then
                    updateAgelbl.Text = day & " days"


                ElseIf day = 0 And year = 0 And month = 0
                    updateAgelbl.Text = "----"

                Else
                    updateAgelbl.Text = "----"
                End If
            End If

        End If



    End Sub

    Private Sub DataGridViewUpdateRecords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUpdateRecords.CellClick
        Dim i As Integer
        Dim ttime As String
        Dim Hour_Minute() As String
        Dim Hour As Integer
        Dim Minute As Integer
        Dim Seconds As Integer
        Dim Year As Integer
        Dim Month As Integer
        Dim Day As Integer
        Dim myDateTime As DateTime



        i = DataGridViewUpdateRecords.CurrentRow.Index
        updatePatientIDlbl.Text = DataGridViewUpdateRecords.Item(1, i).Value
        DateTimePicker1.Value = DataGridViewUpdateRecords.Item(2, i).Value


        ttime = DataGridViewUpdateRecords.Item(3, i).Value.ToString.Trim()
        Hour_Minute = ttime.Split(":")
        Hour = Convert.ToInt32(Hour_Minute(0))
        Minute = Convert.ToInt32(Hour_Minute(1))
        Seconds = 0
        Year = DateTime.Now.Year
        Month = DateTime.Now.Month
        Day = DateTime.Now.Day
        myDateTime = New DateTime(Year, Month, Day, Hour, Minute, Seconds)


        DateTimePicker3.Value = myDateTime

        DateTimePicker3.Format = DateTimePickerFormat.Time
        DateTimePicker3.CustomFormat = "HH:mm tt"

        TextBox1.Visible = False
        TextBox2.Visible = False
        DateTimePicker1.Visible = True
        DateTimePicker3.Visible = True

        selectFromPatient()

        ttemp.Text = DataGridViewUpdateRecords.Item(4, i).Value

        If ttemp.Text.Length = 4 Then




            TextBoxTemperature_Update.Text = ttemp.Text.Substring(0, 2)
            TextBoxTemperature_UpdatePoint.Text = ttemp.Text.Substring(3, 1)

        ElseIf ttemp.Text.Length = 3 Then




            TextBoxTemperature_Update.Text = ttemp.Text.Substring(0, 1)
            TextBoxTemperature_UpdatePoint.Text = ttemp.Text.Substring(2, 1)

        End If

        TextBoxBPH_update.Text = DataGridViewUpdateRecords.Item(5, i).Value
        TextBoxBPL_update.Text = DataGridViewUpdateRecords.Item(6, i).Value



        ppulse.Text = DataGridViewUpdateRecords.Item(7, i).Value

        If ppulse.Text.Length = 6 Then
            TextBoxPulse_update.Text = ppulse.Text.Substring(0, 3)
            TextBoxPulse_updatePoint.Text = ppulse.Text.Substring(4, 2)

        ElseIf ppulse.Text.Length = 5 Then
            TextBoxPulse_update.Text = ppulse.Text.Substring(0, 2)
            TextBoxPulse_updatePoint.Text = ppulse.Text.Substring(3, 2)

        ElseIf ppulse.Text.Length = 4 Then
            TextBoxPulse_update.Text = ppulse.Text.Substring(0, 1)
            TextBoxPulse_updatePoint.Text = ppulse.Text.Substring(2, 2)
        End If




        wwei.Text = DataGridViewUpdateRecords.Item(8, i).Value


        If wwei.Text.Length = 6 Then
            TextBoxWeight_update.Text = wwei.Text.Substring(0, 3)
            TextBoxWeight_updatePoint.Text = wwei.Text.Substring(4, 2)

        ElseIf wwei.Text.Length = 5 Then
            TextBoxWeight_update.Text = wwei.Text.Substring(0, 2)
            TextBoxWeight_updatePoint.Text = wwei.Text.Substring(3, 2)

        ElseIf wwei.Text.Length = 4 Then
            TextBoxWeight_update.Text = wwei.Text.Substring(0, 1)
            TextBoxWeight_updatePoint.Text = wwei.Text.Substring(2, 2)
        End If






        RecID.Text = DataGridViewUpdateRecords.Item(0, i).Value


        TextBoxTemperature_Update.Select()
    End Sub

    Private Sub update_DeleteBtn1_Click(sender As Object, e As EventArgs) Handles update_DeleteBtn1.Click

        If RecID.Text = "AARON" Then
            MessageBox.Show("Select a record")
        Else
            Dim _dialogResults As DialogResult
            _dialogResults = MessageBox.Show("Delete [" & updateLastnamelbl.Text & "'s] record ", "", MessageBoxButtons.YesNo)

            If _dialogResults = DialogResult.Yes Then
                patientRecordDelete = "DELETE 
                                     FROM Patient_Health_Records 
                                     WHERE Record_ID = '" & RecID.Text & "' "
                PatientHealthRecords_Table(patientRecordDelete)

                selectAllRecords = "SELECT Record_ID AS 'RECORD ID', Patient_ID AS 'PATIENT ID' ,Date AS 'DATE',Time AS 'TIME',Body_Temperature AS 'BODY TEMP',Systolic AS 'BLOOD PRESSURE (Systolic)',Diastolic AS 'BLOOD PRESSURE (Diastolic)' ,Pulse AS 'PULSE' ,Weight AS 'WEIGHT'
                 
                  FROM  Patient_Health_Records
                   WHERE Specialist_ID = '" & Home.LabelSpecialistId.Text & "'
                   AND Patient_ID = '" & updatePatientIDlbl.Text & "'ORDER BY Record_ID  DESC"

                PatientHealthRecords_Table(selectAllRecords)

                selectAllRecords2 = "SELECT Patient_ID AS 'PATIENT ID' ,Date AS 'DATE',Time AS 'TIME',Body_Temperature AS 'BODY TEMP',Systolic AS 'BLOOD PRESSURE (Systolic)',Diastolic AS 'BLOOD PRESSURE (Diastolic)' ,Pulse AS 'PULSE' ,Weight AS 'WEIGHT'
                 
                  FROM  Patient_Health_Records
                   WHERE Specialist_ID = '" & Home.LabelSpecialistId.Text & "'
                   ORDER BY Record_ID  DESC"

                PatientHealthRecords_Table(selectAllRecords2)

                DataGridViewUpdateRecords.DataSource = PatientHealthRecords_Table(selectAllRecords)
                Home.AllData.DataSource = PatientHealthRecords_Table(selectAllRecords2)

                If Home.AllData.RowCount = 0 Then
                    Home.GroupBoxNoData.Visible = True
                Else
                    Home.GroupBoxNoData.Visible = False
                End If

                If DataGridViewUpdateRecords.RowCount = 0 Then
                    GroupBoxNoData.Visible = True
                Else
                    GroupBoxNoData.Visible = False
                End If

                updatePatientIDlbl.Text = "Patient ID"
                updateFirstnamelbl.Text = "Firstname"
                updateLastnamelbl.Text = "Lastname"
                updateOthernamelbl.Text = "Othername"
                updateAgelbl.Text = "Age"
                updateGenderlbl.Text = "Sex"

                TextBox1.Visible = True
                TextBox2.Visible = True
                DateTimePicker1.Visible = False
                DateTimePicker3.Visible = False

                TextBoxTemperature_Update.Clear()
                TextBoxBPH_update.Clear()
                TextBoxBPL_update.Clear()
                TextBoxPulse_update.Clear()
                TextBoxWeight_update.Clear()
                TextBoxWeight_updatePoint.Text = "00"
                TextBoxTemperature_UpdatePoint.Text = "0"
                TextBoxPulse_updatePoint.Text = "00"


            End If

        End If

    End Sub

    Private Sub update_Updatebtn1_Click(sender As Object, e As EventArgs) Handles update_Updatebtn1.Click
        If RecID.Text = "AARON" Then
            MessageBox.Show("Select a record")
        Else
            Alltxt1()





        End If
    End Sub
    Private Sub Alltxt1()
        If TextBoxTemperature_Update.Text = Nothing And TextBoxBPH_update.Text = Nothing And TextBoxBPL_update.Text = Nothing And TextBoxPulse_update.Text = Nothing And TextBoxWeight_update.Text = Nothing Then
            MessageBox.Show("Kindly fill in provided spaces")
            TextBoxTemperature_Update.Select()
        Else
            Temperaturetxt()
        End If
    End Sub

    Private Sub Temperaturetxt()
        If TextBoxTemperature_Update.Text = Nothing Then
            Dim dialogResult1 As DialogResult
            dialogResult1 = MessageBox.Show("No value for Body Temperature, SAVE?", "", MessageBoxButtons.YesNo)
            If dialogResult1 = DialogResult.No Then
                TextBoxTemperature_Update.Select()
            Else


                BPH()
            End If
        Else
            BPH()


        End If
    End Sub

    Private Sub BPH()
        If TextBoxBPH_update.Text = Nothing Then
            Dim dialogResult2 As DialogResult
            dialogResult2 = MessageBox.Show("No value for Blood Pressure (Systolic), SAVE?", "", MessageBoxButtons.YesNo)
            If dialogResult2 = DialogResult.No Then
                TextBoxBPH_update.Select()
            Else



                BPL()
            End If
        Else
            BPL()
        End If
    End Sub
    Private Sub BPL()
        If TextBoxBPL_update.Text = Nothing Then
            Dim dialogResult3 As DialogResult
            dialogResult3 = MessageBox.Show("No value for Blood Pressure (Diastolic), SAVE?", "", MessageBoxButtons.YesNo)
            If dialogResult3 = DialogResult.No Then
                TextBoxBPL_update.Select()
            Else


                Pulse()

            End If
        Else
            Pulse()
        End If
    End Sub

    Private Sub Pulse()
        If TextBoxPulse_update.Text = Nothing Then
            Dim dialogResult4 As DialogResult
            dialogResult4 = MessageBox.Show("No value for Pulse, SAVE?", "", MessageBoxButtons.YesNo)
            If dialogResult4 = DialogResult.No Then
                TextBoxPulse_update.Select()
            Else


                Weight()

            End If
        Else
            Weight()
        End If
    End Sub
    Private Sub UpdatingPatientRecords()
        Dim Temp As String

        If TextBoxTemperature_Update.Text = Nothing Then
            Temp = "0"
        Else
            If TextBoxTemperature_UpdatePoint.Text = Nothing Then
                TextBoxTemperature_UpdatePoint.Text = "0"

            End If



            Temp = TextBoxTemperature_Update.Text + "." + TextBoxTemperature_UpdatePoint.Text
        End If




        Dim Pul As String


        If TextBoxPulse_update.Text = Nothing Then
            Pul = "0"


        Else
            If TextBoxPulse_updatePoint.Text = Nothing Then
                TextBoxPulse_updatePoint.Text = "00"

            End If

            Pul = TextBoxPulse_update.Text + "." + TextBoxPulse_updatePoint.Text
        End If






        Dim Wei As String


        If TextBoxWeight_update.Text = Nothing Then
            Wei = "0"



        Else
            If TextBoxWeight_updatePoint.Text = Nothing Then
                TextBoxWeight_updatePoint.Text = "00"

            End If

            Wei = TextBoxWeight_update.Text + "." + TextBoxWeight_updatePoint.Text
        End If

        Try

            patientRecordUpdate = "UPDATE Patient_Health_Records SET Date = '" & DateTimePicker1.Value.Date.Date & "', Time = '" & DateTimePicker3.Value & "', Body_Temperature = '" & Temp & "', Systolic =  '" & TextBoxBPH_update.Text & "' , Diastolic = '" & TextBoxBPL_update.Text & "',
              Pulse = '" & Pul & "' , Weight = '" & Wei & "'
                    WHERE Record_ID = '" & RecID.Text & "'"

            PatientHealthRecords_Table(patientRecordUpdate)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub clearAndSelect()
        selectAllRecords3 = "SELECT Record_ID AS 'RECORD ID', Patient_ID AS 'PATIENT ID' ,Date AS 'DATE',Time AS 'TIME',Body_Temperature AS 'BODY TEMP',Systolic AS 'BLOOD PRESSURE (Systolic)',Diastolic AS 'BLOOD PRESSURE (Diastolic)' ,Pulse AS 'PULSE' ,Weight AS 'WEIGHT'
                 
                  FROM  Patient_Health_Records
                      WHERE  Patient_ID = '" & updatePatientIDlbl.Text & "' AND Specialist_ID = '" & Home.LabelSpecialistId.Text & "' 
                     ORDER BY Record_ID  DESC"

        PatientHealthRecords_Table(selectAllRecords3)

        selectAllRecords1 = "SELECT Patient_ID AS 'PATIENT ID' ,Date AS 'DATE',Time AS 'TIME',Body_Temperature AS 'BODY TEMP',Systolic AS 'BLOOD PRESSURE (Systolic)',Diastolic AS 'BLOOD PRESSURE (Diastolic)' ,Pulse AS 'PULSE' ,Weight AS 'WEIGHT'
                 
                  FROM  Patient_Health_Records
                    WHERE Specialist_ID = '" & Home.LabelSpecialistId.Text & "'
                     ORDER BY Record_ID  DESC"

        PatientHealthRecords_Table(selectAllRecords1)


        DataGridViewUpdateRecords.DataSource = PatientHealthRecords_Table(selectAllRecords3)
        Home.AllData.DataSource = PatientHealthRecords_Table(selectAllRecords1)


        If Home.AllData.RowCount = 0 Then
            Home.GroupBoxNoData.Visible = True
        Else
            Home.GroupBoxNoData.Visible = False
        End If

        If DataGridViewUpdateRecords.RowCount = 0 Then
            GroupBoxNoData.Visible = True
        Else
            GroupBoxNoData.Visible = False
        End If

        updatePatientIDlbl.Text = "Patient ID"
        updateFirstnamelbl.Text = "Firstname"
        updateLastnamelbl.Text = "Laststname"
        updateOthernamelbl.Text = "Othername"
        updateAgelbl.Text = "Age"
        updateGenderlbl.Text = "Sex"

        TextBox1.Visible = True
        TextBox2.Visible = True
        DateTimePicker1.Visible = False
        DateTimePicker3.Visible = False


        TextBoxTemperature_Update.Clear()
        TextBoxBPH_update.Clear()
        TextBoxBPL_update.Clear()
        TextBoxPulse_update.Clear()
        TextBoxWeight_update.Clear()
        TextBoxWeight_updatePoint.Text = "00"
        TextBoxTemperature_UpdatePoint.Text = "0"
        TextBoxPulse_updatePoint.Text = "00"
    End Sub
    Private Sub Weight()
        If TextBoxWeight_update.Text = Nothing Then
            Dim dialogResult5 As DialogResult
            dialogResult5 = MessageBox.Show("No value for Body weight, SAVE?", "", MessageBoxButtons.YesNo)
            If dialogResult5 = DialogResult.No Then
                TextBoxWeight_update.Select()
            Else


                UpdatingPatientRecords()
                clearAndSelect()
                MessageBox.Show("Successfully Updated")

            End If
        Else
            UpdatingPatientRecords()
            clearAndSelect()
            MessageBox.Show("Successfully Updated")

        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSearch.KeyPress
        Static firstLetter As Char
        Static secondLetter As Char
        Static thirdLetter As Char

        If firstLetter = "-"c Or TextBoxSearch.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
        If firstLetter = "-"c Or TextBoxSearch.Text.Length = 1 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        secondLetter = e.KeyChar
        If firstLetter = "-"c Or TextBoxSearch.Text.Length = 2 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        thirdLetter = e.KeyChar
    End Sub

    Private Sub GroupBoxNoData_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub EnterPatientID_Update2okbtn_Click(sender As Object, e As EventArgs) Handles EnterPatientID_Update2okbtn.Click
        Try

            If TextBoxSearch.Text = Nothing Then
                MessageBox.Show("Enter Patient ID")
            Else
                patientRecordSelect3 = "select * From Patient_Health_Records Where Patient_ID = '" & TextBoxSearch.Text & "' AND Specialist_ID = '" & Home.LabelSpecialistId.Text & "' "
                PatientHealthRecords_Table(patientRecordSelect3)
                patientRecordDataTable3 = PatientHealthRecords_Table(patientRecordSelect3)
                If patientRecordDataTable3.Rows.Count Then





                    patientRecordSelectAll = "SELECT Record_ID AS 'RECORD ID', Patient_ID AS 'PATIENT ID' ,Date AS 'DATE',Time AS 'TIME',Body_Temperature AS 'BODY TEMP',Systolic AS 'BLOOD PRESSURE (Systolic)',Diastolic AS 'BLOOD PRESSURE (Diastolic)',Pulse AS 'PULSE' ,Weight AS 'WEIGHT'
                 
                  FROM  Patient_Health_Records
                  WHERE  Patient_ID = '" & TextBoxSearch.Text & "' AND Specialist_ID = '" & Home.LabelSpecialistId.Text & "'ORDER BY Record_ID  DESC"

                    PatientHealthRecords_Table(patientRecordSelectAll)
                    DataGridViewUpdateRecords.DataSource = PatientHealthRecords_Table(patientRecordSelectAll)
                    If DataGridViewUpdateRecords.RowCount = 0 Then
                        GroupBoxNoData.Visible = True
                    Else
                        GroupBoxNoData.Visible = False
                    End If


                Else
                    MessageBox.Show("Patient ID doesn't exit")
                    TextBoxSearch.Select()
                    TextBoxSearch.Clear()

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try

                If TextBoxSearch.Text = Nothing Then
                    MessageBox.Show("Enter Patient ID")
                Else
                    patientRecordSelect3 = "select * From Patient_Health_Records Where Patient_ID = '" & TextBoxSearch.Text & "' AND Specialist_ID = '" & Home.LabelSpecialistId.Text & "' "
                    PatientHealthRecords_Table(patientRecordSelect3)
                    patientRecordDataTable3 = PatientHealthRecords_Table(patientRecordSelect3)
                    If patientRecordDataTable3.Rows.Count Then





                        patientRecordSelectAll = "SELECT Record_ID AS 'RECORD ID',Patient_ID AS 'PATIENT ID' ,Date AS 'DATE',Time AS 'TIME',Body_Temperature AS 'BODY TEMP',Systolic AS 'BLOOD PRESSURE (Systolic)',Diastolic AS 'BLOOD PRESSURE (Diastolic)' ,Pulse AS 'PULSE' ,Weight AS 'WEIGHT'
                 
                  FROM  Patient_Health_Records
                  WHERE  Patient_ID = '" & TextBoxSearch.Text & "' AND Specialist_ID = '" & Home.LabelSpecialistId.Text & "'ORDER BY Record_ID  DESC"

                        PatientHealthRecords_Table(patientRecordSelectAll)
                        DataGridViewUpdateRecords.DataSource = PatientHealthRecords_Table(patientRecordSelectAll)
                        If DataGridViewUpdateRecords.RowCount = 0 Then
                            GroupBoxNoData.Visible = True
                        Else
                            GroupBoxNoData.Visible = False
                        End If


                    Else
                        MessageBox.Show("Patient ID doesn't exit")
                        TextBoxSearch.Select()
                        TextBoxSearch.Clear()

                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxTemperature_UpdatePoint_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxTemperature_UpdatePoint.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxBPH_update.Select()
        End If
    End Sub

    Private Sub TextBoxPulse_updatePoint_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPulse_updatePoint.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxWeight_update.Select()
        End If
    End Sub

    Private Sub TextBoxWeight_updatePoint_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxWeight_updatePoint.KeyDown
        If e.KeyCode = Keys.Enter Then
            update_Updatebtn1.Select()
        End If
    End Sub

    Private Sub TextBoxTemperature_Update_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTemperature_Update.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub TextBoxTemperature_UpdatePoint_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTemperature_UpdatePoint.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub TextBoxBPH_update_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxBPH_update.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub TextBoxBPL_update_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxBPL_update.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub TextBoxPulse_update_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPulse_update.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub TextBoxPulse_updatePoint_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPulse_updatePoint.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub TextBoxWeight_update_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxWeight_update.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub TextBoxWeight_updatePoint_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxWeight_updatePoint.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub
End Class