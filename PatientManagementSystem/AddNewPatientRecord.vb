Public Class AddNewPatientRecord
    Dim patientRecordInsertString As String
    Dim selectAllRecords As String

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Dim bhandled As Boolean = False



        Select Case keyData
            Case Keys.Escape
                Me.Close()
                bhandled = True


            Case Keys.Home
                Me.Hide()
                Dim Msg1 As String
                Msg1 = MessageBox.Show("Are you sure you would like to exit?", "", MessageBoxButtons.YesNo)
                If Msg1 = DialogResult.Yes Then
                    Application.Exit()
                End If


        End Select



        Return False

    End Function

    Private Sub AddNewPatientRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewRecordTemperaturetxt.Select()
        AddRecordTimePicker.Format = DateTimePickerFormat.Time
        AddRecordTimePicker.ShowUpDown = True

        DateTimePicker3.Format = DateTimePickerFormat.Time
        DateTimePicker3.ShowUpDown = True
    End Sub

    Private Sub AddRecordSavebtn_Paint(sender As Object, e As PaintEventArgs) Handles AddRecordSavebtn.Paint
        Home.buttonBorderRadius(sender, 30)
    End Sub

    Private Sub NewRecordTemperaturetxt_KeyDown(sender As Object, e As KeyEventArgs) Handles NewRecordTemperaturetxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            NewRecordTemperaturePointtxt.Select()

        End If

    End Sub

    Private Sub NewRecordBPHtxt_KeyDown(sender As Object, e As KeyEventArgs) Handles NewRecordBPHtxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            NewRecordBpltxt1.Select()
        End If

    End Sub

    Private Sub NewRecordBpltxt1_KeyDown(sender As Object, e As KeyEventArgs) Handles NewRecordBpltxt1.KeyDown
        If e.KeyCode = Keys.Enter Then
            NewRecordPulsetxt4.Select()
        End If

    End Sub

    Private Sub NewRecordPulsetxt4_KeyDown(sender As Object, e As KeyEventArgs) Handles NewRecordPulsetxt4.KeyDown
        If e.KeyCode = Keys.Enter Then
            NewRecordPulsePointtxt4.Select()
        End If

    End Sub

    Private Sub NewRecordWeighttxt7_KeyDown(sender As Object, e As KeyEventArgs) Handles NewRecordWeighttxt7.KeyDown
        If e.KeyCode = Keys.Enter Then
            NewRecordWeightPointtxt7.Select()
        End If

    End Sub

    Private Sub AddRecordDateTimePicker_KeyDown(sender As Object, e As KeyEventArgs) Handles AddRecordDatePicker.KeyDown
        If e.KeyCode = Keys.Enter Then
            NewRecordTemperaturetxt.Select()
        End If
    End Sub

    Private Sub AddRecordSavebtn_KeyDown(sender As Object, e As KeyEventArgs) Handles AddRecordSavebtn.KeyDown
        If e.KeyCode = Keys.Up Then
            AddRecordSavebtn.Select()
        End If
        If e.KeyCode = Keys.Down Then
            AddRecordSavebtn.Select()
        End If
    End Sub
    Private Sub Alltxt1()
        Dim patientSelect3 As String
        Dim patientDataTable3 As DataTable
        patientSelect3 = "select * From Patient Where Patient_ID = '" & TextBoxPatIDtxt.Text & "' "
        Patient_Table(patientSelect3)
        patientDataTable3 = Patient_Table(patientSelect3)
        If NewRecordTemperaturetxt.Text = Nothing And NewRecordBPHtxt.Text = Nothing And NewRecordBpltxt1.Text = Nothing And NewRecordPulsetxt4.Text = Nothing And NewRecordWeighttxt7.Text = Nothing Then
            MessageBox.Show("Kindly fill in provided spaces")
            NewRecordTemperaturetxt.Select()
        ElseIf patientDataTable3.Rows.Count Then



            Temperaturetxt()

        Else
            MessageBox.Show("Invalid Patient ID")
            TextBoxPatIDtxt.Select()
        End If
    End Sub

    Private Sub Temperaturetxt()
        If NewRecordTemperaturetxt.Text = Nothing Then
            Dim dialogResult1 As DialogResult
            dialogResult1 = MessageBox.Show("No value for Body Temperature, SAVE?", "", MessageBoxButtons.YesNo)
            If dialogResult1 = DialogResult.No Then
                NewRecordTemperaturetxt.Select()
            ElseIf dialogResult1 = DialogResult.Yes Then


                BPH()
            End If
        Else
            BPH()


        End If
    End Sub

    Private Sub BPH()
        If NewRecordBPHtxt.Text = Nothing Then
            Dim dialogResult2 As DialogResult
            dialogResult2 = MessageBox.Show("No value for  Blood Pressure(Systolic), SAVE?", "", MessageBoxButtons.YesNo)
            If dialogResult2 = DialogResult.No Then
                NewRecordBPHtxt.Select()
            ElseIf dialogResult2 = DialogResult.Yes Then


                BPL()


            End If
        Else
            BPL()
        End If
    End Sub
    Private Sub BPL()
        If NewRecordBpltxt1.Text = Nothing Then
            Dim dialogResult3 As DialogResult
            dialogResult3 = MessageBox.Show("No value for  Blood Pressure(Diastolic), SAVE?", "", MessageBoxButtons.YesNo)
            If dialogResult3 = DialogResult.No Then
                NewRecordBpltxt1.Select()
            ElseIf dialogResult3 = DialogResult.Yes Then


                Pulse()


            End If
        Else
            Pulse()
        End If
    End Sub

    Private Sub Pulse()
        If NewRecordPulsetxt4.Text = Nothing Then
            Dim dialogResult4 As DialogResult
            dialogResult4 = MessageBox.Show("No value for Pulse, SAVE?", "", MessageBoxButtons.YesNo)
            If dialogResult4 = DialogResult.No Then
                NewRecordPulsetxt4.Select()
            ElseIf dialogResult4 = DialogResult.Yes Then


                Weight()


            End If
        Else
            Weight()
        End If
    End Sub

    Private Sub Weight()
        If NewRecordWeighttxt7.Text = Nothing Then
            Dim dialogResult5 As DialogResult
            dialogResult5 = MessageBox.Show("No value for Body weight, SAVE?", "", MessageBoxButtons.YesNo)
            If dialogResult5 = DialogResult.No Then
                NewRecordWeighttxt7.Select()
            ElseIf dialogResult5 = DialogResult.Yes Then



                InsertIntoPatientRecords()
                clear1()
                MessageBox.Show("Successfully Added")
                Dim dialogResult6 As DialogResult
                dialogResult6 = MessageBox.Show("Add another record?", "", MessageBoxButtons.YesNo)
                If dialogResult6 = DialogResult.No Then
                    Me.Close()

                Else
                    NewRecordTemperaturetxt.Select()
                End If

            End If
        Else
            InsertIntoPatientRecords()
            clear1()
            MessageBox.Show("Successfully Added")
            Dim dialogResult6 As DialogResult
            dialogResult6 = MessageBox.Show("Add another record?", "", MessageBoxButtons.YesNo)
            If dialogResult6 = DialogResult.No Then
                Me.Close()

            Else
                NewRecordTemperaturetxt.Select()
            End If
        End If
    End Sub
    Private Sub clear1()
        AddRecordDatePicker.Value = DateTimePicker1.Value
        AddRecordTimePicker.Value = DateTimePicker3.Value
        NewRecordTemperaturetxt.Clear()
        NewRecordBPHtxt.Clear()
        NewRecordBpltxt1.Clear()
        NewRecordPulsetxt4.Clear()
        NewRecordWeighttxt7.Clear()
        NewRecordWeightPointtxt7.Text = "00"
        NewRecordPulsePointtxt4.Text = "00"
        NewRecordTemperaturePointtxt.Text = "0"
    End Sub
    Private Sub AddRecordSavebtn_Click(sender As Object, e As EventArgs) Handles AddRecordSavebtn.Click

        Alltxt1()


    End Sub

    Public Sub InsertIntoPatientRecords()
        Dim patientSelect2 As String
        Dim patientDataTable2 As DataTable
        patientSelect2 = "select * From Patient Where Patient_ID = '" & TextBoxPatIDtxt.Text & "' "
        Patient_Table(patientSelect2)
        patientDataTable2 = Patient_Table(patientSelect2)

        If patientDataTable2.Rows.Count Then
            Dim Temp As String

            If NewRecordTemperaturetxt.Text = Nothing Then
                Temp = "0"
            Else
                If NewRecordTemperaturePointtxt.Text = Nothing Then
                    NewRecordTemperaturePointtxt.Text = "0"

                End If

                Temp = NewRecordTemperaturetxt.Text + "." + NewRecordTemperaturePointtxt.Text
            End If




            Dim Pul As String

            If NewRecordPulsetxt4.Text = Nothing Then
                Pul = "0"


            Else
                If NewRecordPulsePointtxt4.Text = Nothing Then
                    NewRecordPulsePointtxt4.Text = "00"

                End If

                Pul = NewRecordPulsetxt4.Text + "." + NewRecordPulsePointtxt4.Text
            End If






            Dim Wei As String

            If NewRecordWeighttxt7.Text = Nothing Then
                Wei = "0"



            Else
                If NewRecordWeightPointtxt7.Text = Nothing Then
                    NewRecordWeightPointtxt7.Text = "00"

                End If

                Wei = NewRecordWeighttxt7.Text + "." + NewRecordWeightPointtxt7.Text
            End If


            patientRecordInsertString = "INSERT INTO Patient_Health_Records
           (Patient_ID ,Date,Time ,Body_Temperature,Systolic ,Diastolic ,Pulse ,Weight ,Specialist_ID)
            VALUES('" & TextBoxPatIDtxt.Text & "', '" & AddRecordDatePicker.Value.Date.Date & "','" & AddRecordTimePicker.Value & "','" & Temp & "','" & NewRecordBPHtxt.Text & "','" & NewRecordBpltxt1.Text & "','" & Pul & "' ,'" & Wei & "' ,'" & Home.LabelSpecialistId.Text & "' )"
            PatientHealthRecords_Table(patientRecordInsertString)

            selectAllRecords = "SELECT Patient_ID AS 'PATIENT ID' ,Date AS 'DATE',Time AS 'TIME',Body_Temperature AS 'BODY TEMP',Systolic AS 'BLOOD PRESSURE (Systolic)',Diastolic AS 'BLOOD PRESSURE (Diastolic)' ,Pulse AS 'PULSE' ,Weight AS 'WEIGHT'
                 
                  FROM  Patient_Health_Records WHERE Specialist_ID = '" & Home.LabelSpecialistId.Text & "'ORDER BY Record_ID  DESC"

            PatientHealthRecords_Table(selectAllRecords)
            Home.GroupBoxChart.Visible = False
            Home.AllData.DataSource = PatientHealthRecords_Table(selectAllRecords)
            If Home.AllData.RowCount = 0 Then
                Home.GroupBoxNoData.Visible = True
            Else
                Home.GroupBoxNoData.Visible = False
            End If



        Else
            MessageBox.Show("Patient ID doesn't exit")
            TextBoxPatIDtxt.Select()


        End If

    End Sub

    Private Sub NewRecordTemperaturetxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewRecordTemperaturetxt.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True

        End If


    End Sub

    Private Sub NewRecordBPHtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewRecordBPHtxt.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub NewRecordBpltxt1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewRecordBpltxt1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub NewRecordPulsetxt4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewRecordPulsetxt4.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub NewRecordWeighttxt7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewRecordWeighttxt7.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxPatIDtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPatIDtxt.KeyPress
        Static firstLetter As Char
        Static secondLetter As Char
        Static thirdLetter As Char

        If firstLetter = "-"c Or TextBoxPatIDtxt.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
        If firstLetter = "-"c Or TextBoxPatIDtxt.Text.Length = 1 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        secondLetter = e.KeyChar
        If firstLetter = "-"c Or TextBoxPatIDtxt.Text.Length = 2 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        thirdLetter = e.KeyChar
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles AddRecordTimePicker.ValueChanged

    End Sub

    Private Sub NewRecordWeighttxt7_TextChanged(sender As Object, e As EventArgs) Handles NewRecordWeighttxt7.TextChanged

    End Sub

    Private Sub NewRecordTemperaturetxt_TextChanged(sender As Object, e As EventArgs) Handles NewRecordTemperaturetxt.TextChanged

    End Sub

    Private Sub NewRecordTemperaturePointtxt_KeyDown(sender As Object, e As KeyEventArgs) Handles NewRecordTemperaturePointtxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            NewRecordBPHtxt.Select()
        End If
    End Sub

    Private Sub NewRecordPulsePointtxt4_KeyDown(sender As Object, e As KeyEventArgs) Handles NewRecordPulsePointtxt4.KeyDown
        If e.KeyCode = Keys.Enter Then
            NewRecordWeighttxt7.Select()
        End If
    End Sub

    Private Sub NewRecordWeightPointtxt7_KeyDown(sender As Object, e As KeyEventArgs) Handles NewRecordWeightPointtxt7.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddRecordSavebtn.Select()
        End If
    End Sub

    Private Sub NewRecordTemperaturePointtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewRecordTemperaturePointtxt.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub NewRecordPulsePointtxt4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewRecordPulsePointtxt4.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub NewRecordWeightPointtxt7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewRecordWeightPointtxt7.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub NewRecordTemperaturePointtxt_TextChanged(sender As Object, e As EventArgs) Handles NewRecordTemperaturePointtxt.TextChanged

    End Sub
End Class