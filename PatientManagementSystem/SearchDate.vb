Public Class SearchDate

    Dim searchSelectAllRecords1 As String
    Private Sub SerachDateOkbtn_Paint(sender As Object, e As PaintEventArgs) Handles SerachDateOkbtn.Paint
        Home.buttonBorderRadius(sender, 20)
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Dim bhandled As Boolean = False



        Select Case keyData
            Case Keys.Escape
                Me.Close()
                bhandled = True

            Case Keys.Enter
                searchSelectAllRecords1 = "SELECT Patient_ID AS 'PATIENT ID' ,Date AS 'DATE',Time AS 'TIME',Body_Temperature AS 'BODY TEMP',Systolic AS 'BLOOD PRESSURE (Systolic)',Diastolic AS 'BLOOD PRESSURE (Diastolic)' ,Pulse AS 'PULSE' ,Weight AS 'WEIGHT'
                 
                  FROM  Patient_Health_Records 
                   WHERE Date = '" & SearchDateTimePicker.Value & "' AND Specialist_ID = '" & Home.LabelSpecialistId.Text & "'ORDER BY Record_ID  DESC"


                PatientHealthRecords_Table(searchSelectAllRecords1)
                Home.GroupBoxChart.Visible = False
                Home.AllData.DataSource = PatientHealthRecords_Table(searchSelectAllRecords1)
                Me.Hide()
                If Home.AllData.RowCount = 0 Then
                    Home.GroupBoxNoData.Visible = True
                Else
                    Home.GroupBoxNoData.Visible = False
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

    Private Sub SerachDateOkbtn_Click(sender As Object, e As EventArgs) Handles SerachDateOkbtn.Click





        searchSelectAllRecords1 = "SELECT Patient_ID AS 'PATIENT ID' ,Date AS 'DATE',Time AS 'TIME',Body_Temperature AS 'BODY TEMP',Systolic AS 'BLOOD PRESSURE (Systolic)',Diastolic AS 'BLOOD PRESSURE (Diastolic)' ,Pulse AS 'PULSE' ,Weight AS 'WEIGHT'
                 
                  FROM  Patient_Health_Records 
                   WHERE Date = '" & SearchDateTimePicker.Value & "' AND Specialist_ID = '" & Home.LabelSpecialistId.Text & "' ORDER BY Record_ID  DESC"


        PatientHealthRecords_Table(searchSelectAllRecords1)
        Home.GroupBoxChart.Visible = False
        Home.AllData.DataSource = PatientHealthRecords_Table(searchSelectAllRecords1)

        Me.Hide()
        If Home.AllData.RowCount = 0 Then
            Home.GroupBoxNoData.Visible = True
        Else
            Home.GroupBoxNoData.Visible = False
        End If





    End Sub
End Class