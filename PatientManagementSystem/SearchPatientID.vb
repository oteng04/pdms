Public Class SearchPatientID
    Dim searchSelectAllRecords As String
    Private Sub SerachPatientIDOkbtn_Paint(sender As Object, e As PaintEventArgs) Handles SerachPatientIDOkbtn.Paint
        Home.buttonBorderRadius(sender, 20)
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Dim bhandled As Boolean = False



        Select Case keyData
            Case Keys.Escape
                Me.Close()
                bhandled = True

            Case Keys.Enter

                If SearchPatientIDtxt.Text = Nothing Then
                    MessageBox.Show("Enter Patient ID")
                Else
                    Dim patientSelect2 As String
                    Dim patientRecordsDataTable As DataTable
                    patientSelect2 = "select * From Patient_Health_Records Where Patient_ID = '" & SearchPatientIDtxt.Text & "' AND Specialist_ID = '" & Home.LabelSpecialistId.Text & "' "
                    PatientHealthRecords_Table(patientSelect2)
                    patientRecordsDataTable = PatientHealthRecords_Table(patientSelect2)

                    If patientRecordsDataTable.Rows.Count Then




                        searchSelectAllRecords = "SELECT Patient_ID AS 'PATIENT ID' ,Date AS 'DATE',Time AS 'TIME',Body_Temperature AS 'BODY TEMP',Systolic AS 'BLOOD PRESSURE (Systolic)',Diastolic AS 'BLOOD PRESSURE (Diastolic)' ,Pulse AS 'PULSE' ,Weight AS 'WEIGHT'
                 
                  FROM  Patient_Health_Records 
                   WHERE Patient_ID = '" & SearchPatientIDtxt.Text & "' AND Specialist_ID = '" & Home.LabelSpecialistId.Text & "'ORDER BY Record_ID  DESC"


                        PatientHealthRecords_Table(searchSelectAllRecords)
                        Home.GroupBoxChart.Visible = False
                        Home.AllData.DataSource = PatientHealthRecords_Table(searchSelectAllRecords)

                        Me.Hide()
                        If Home.AllData.RowCount = 0 Then
                            Home.GroupBoxNoData.Visible = True
                        Else
                            Home.GroupBoxNoData.Visible = False
                        End If



                    Else
                        MessageBox.Show("Patient ID doesn't exit")
                        SearchPatientIDtxt.Select()
                        SearchPatientIDtxt.Clear()

                    End If
                End If

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

    Private Sub SearchPatientIDtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchPatientIDtxt.KeyPress
        Static firstLetter As Char
        Static secondLetter As Char
        Static thirdLetter As Char

        If firstLetter = "-"c Or SearchPatientIDtxt.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
        If firstLetter = "-"c Or SearchPatientIDtxt.Text.Length = 1 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        secondLetter = e.KeyChar
        If firstLetter = "-"c Or SearchPatientIDtxt.Text.Length = 2 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        thirdLetter = e.KeyChar
    End Sub

    Private Sub SearchPatientID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchPatientIDtxt.Select()
    End Sub

    Private Sub SerachPatientIDOkbtn_Click(sender As Object, e As EventArgs) Handles SerachPatientIDOkbtn.Click
        If SearchPatientIDtxt.Text = Nothing Then
            MessageBox.Show("Enter Patient ID")
        Else
            Dim patientSelect2 As String
            Dim patientRecordsDataTable As DataTable
            patientSelect2 = "select * From Patient_Health_Records Where Patient_ID = '" & SearchPatientIDtxt.Text & "' AND Specialist_ID = '" & Home.LabelSpecialistId.Text & "' "
            PatientHealthRecords_Table(patientSelect2)
            patientRecordsDataTable = PatientHealthRecords_Table(patientSelect2)

            If patientRecordsDataTable.Rows.Count Then




                searchSelectAllRecords = "SELECT Patient_ID AS 'PATIENT ID' ,Date AS 'DATE',Time AS 'TIME',Body_Temperature AS 'BODY TEMP',Systolic AS 'BLOOD PRESSURE (Systolic)',Diastolic AS 'BLOOD PRESSURE (Diastolic)' ,Pulse AS 'PULSE' ,Weight AS 'WEIGHT'
                 
                  FROM  Patient_Health_Records 
                   WHERE Patient_ID = '" & SearchPatientIDtxt.Text & "' AND Specialist_ID = '" & Home.LabelSpecialistId.Text & "'ORDER BY Record_ID  DESC"


                PatientHealthRecords_Table(searchSelectAllRecords)
                Home.GroupBoxChart.Visible = False
                Home.AllData.DataSource = PatientHealthRecords_Table(searchSelectAllRecords)

                Me.Hide()
                If Home.AllData.RowCount = 0 Then
                    Home.GroupBoxNoData.Visible = True
                Else
                    Home.GroupBoxNoData.Visible = False
                End If


            Else
                MessageBox.Show("Patient ID doesn't exit")
                SearchPatientIDtxt.Select()
                SearchPatientIDtxt.Clear()

            End If
        End If
    End Sub
End Class