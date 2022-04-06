Public Class SearchBySex
    Private Sub SerachPatientIDOkbtn_Paint(sender As Object, e As PaintEventArgs) Handles SerachPatientIDOkbtn.Paint
        Home.buttonBorderRadius(sender, 20)
    End Sub

    Private Sub ComboBoxPatientSex_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxPatientSex.KeyPress
        Static firstLetter As Char
        If firstLetter = "-"c Or ComboBoxPatientSex.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
    End Sub

    Private Sub SerachPatientIDOkbtn_Click(sender As Object, e As EventArgs) Handles SerachPatientIDOkbtn.Click
        Try
            If ComboBoxPatientSex.SelectedIndex = -1 Then
                If ComboBoxPatientSex.Text.ToUpper = "MALE" Then
                    ComboBoxPatientSex.SelectedIndex = 0


                ElseIf ComboBoxPatientSex.Text.ToUpper = "FEMALE" Then
                    ComboBoxPatientSex.SelectedIndex = 1




                Else

                    MessageBox.Show("Select Patient's Sex")
                    ComboBoxPatientSex.Select()

                End If

            Else

                If ComboBoxPatientSex.SelectedIndex = 0 Then
                    Label_Invisivle.Text = "Male"
                ElseIf ComboBoxPatientSex.SelectedIndex = 1 Then
                    Label_Invisivle.Text = "Female"

                End If

            End If

            Dim sl As String
            sl = "SELECT Patient_Health_Records.Patient_ID AS 'PATIENT ID' ,Patient_Health_Records.Date AS 'DATE',Patient_Health_Records.Time AS 'TIME' ,Patient_Health_Records.Body_Temperature AS 'BODY TEMP' ,Patient_Health_Records.Systolic AS 'BLOOD PRESSURE (Systolic)' ,Patient_Health_Records.Diastolic AS 'BLOOD PRESSURE (Diastolic)' ,Patient_Health_Records.Pulse AS 'PULSE' ,Patient_Health_Records.Weight AS 'WEIGHT'
                 
                  FROM  Patient_Health_Records, Patient
                        WHERE Patient_Health_Records.Patient_ID = Patient.Patient_ID
                           AND Patient.Sex = '" & Label_Invisivle.Text & "'
                           AND Patient_Health_Records.Specialist_ID = '" & Home.LabelSpecialistId.Text & "'ORDER BY Record_ID  DESC"
            PatientHealthRecords_Table(sl)

            Home.GroupBoxChart.Visible = False
            Home.AllData.DataSource = PatientHealthRecords_Table(sl)
            Me.Hide()
            If Home.AllData.RowCount = 0 Then
                Home.GroupBoxNoData.Visible = True
            Else
                Home.GroupBoxNoData.Visible = False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Dim bhandled As Boolean = False



        Select Case keyData
            Case Keys.Escape
                Me.Close()
                bhandled = True

            Case Keys.Enter

                Try
                    If ComboBoxPatientSex.SelectedIndex = -1 Then
                        If ComboBoxPatientSex.Text.ToUpper = "MALE" Then
                            ComboBoxPatientSex.SelectedIndex = 0


                        ElseIf ComboBoxPatientSex.Text.ToUpper = "FEMALE" Then
                            ComboBoxPatientSex.SelectedIndex = 1




                        Else

                            MessageBox.Show("Select Patient's Sex")
                            ComboBoxPatientSex.Select()

                        End If

                    Else

                        If ComboBoxPatientSex.SelectedIndex = 0 Then
                            Label_Invisivle.Text = "Male"
                        ElseIf ComboBoxPatientSex.SelectedIndex = 1 Then
                            Label_Invisivle.Text = "Female"

                        End If

                    End If

                    Dim sl As String
                    sl = "SELECT Patient_Health_Records.Patient_ID AS 'PATIENT ID' ,Patient_Health_Records.Date AS 'DATE',Patient_Health_Records.Time AS 'TIME' ,Patient_Health_Records.Body_Temperature AS 'BODY TEMP' ,Patient_Health_Records.Systolic AS 'BLOOD PRESSURE (Systolic)' ,Patient_Health_Records.Diastolic AS 'BLOOD PRESSURE (Diastolic)' ,Patient_Health_Records.Pulse AS 'PULSE' ,Patient_Health_Records.Weight AS 'WEIGHT'
                 
                  FROM  Patient_Health_Records, Patient
                        WHERE Patient_Health_Records.Patient_ID = Patient.Patient_ID
                           AND Patient.Sex = '" & Label_Invisivle.Text & "' 
                           AND Patient_Health_Records.Specialist_ID = '" & Home.LabelSpecialistId.Text & "' ORDER BY Record_ID  DESC"

                    PatientHealthRecords_Table(sl)
                    Home.GroupBoxChart.Visible = False
                    Home.AllData.DataSource = PatientHealthRecords_Table(sl)
                    Me.Hide()
                    If Home.AllData.RowCount = 0 Then
                        Home.GroupBoxNoData.Visible = True
                    Else
                        Home.GroupBoxNoData.Visible = False
                    End If


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

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

End Class