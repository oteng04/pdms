Public Class EnterPatientID_Update2
    Dim patientRecordSelect3 As String
    Dim patientRecordSelectAll As String
    Dim patientRecordDataTable3 As DataTable
    Private Sub EnterPatientID_Update2okbtn_Click(sender As Object, e As EventArgs) Handles EnterPatientID_Update2okbtn.Click


        Try
            patientRecordSelect3 = "select * From Patient_Health_Records Where Patient_ID = '" & TextBoxEnterID.Text & "' AND Specialist_ID = '" & Home.LabelSpecialistId.Text & "' "
            PatientHealthRecords_Table(patientRecordSelect3)
            patientRecordDataTable3 = PatientHealthRecords_Table(patientRecordSelect3)
            If TextBoxEnterID.Text = Nothing Then
                MessageBox.Show("Enter Patient ID")
            Else
                If patientRecordDataTable3.Rows.Count Then



                    patientRecordSelectAll = "SELECT Record_ID AS 'RECORD ID',Patient_ID AS 'PATIENT ID' ,Date AS 'DATE',Time AS 'TIME',Body_Temperature AS 'BODY TEMP',Systolic AS 'BLOOD PRESSURE (Systolic)',Diastolic AS 'BLOOD PRESSURE (Diastolic)' ,Pulse AS 'PULSE' ,Weight AS 'WEIGHT'
                 
                  FROM  Patient_Health_Records
                  WHERE  Patient_ID = '" & TextBoxEnterID.Text & "' AND Specialist_ID = '" & Home.LabelSpecialistId.Text & "' ORDER BY Record_ID  DESC"

                    PatientHealthRecords_Table(patientRecordSelectAll)
                    UpdatePatientHealthRecord.DataGridViewUpdateRecords.DataSource = PatientHealthRecords_Table(patientRecordSelectAll)
                    If UpdatePatientHealthRecord.DataGridViewUpdateRecords.RowCount = 0 Then
                        UpdatePatientHealthRecord.GroupBoxNoData.Visible = True
                    Else
                        UpdatePatientHealthRecord.GroupBoxNoData.Visible = False
                    End If

                    UpdatePatientHealthRecord.Show()
                    Home.Hide()
                    Me.Close()
                Else
                    MessageBox.Show("Patient ID doesn't exit")
                    TextBoxEnterID.Select()
                    TextBoxEnterID.Clear()

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub EnterPatientID_Update2okbtn_Paint(sender As Object, e As PaintEventArgs) Handles EnterPatientID_Update2okbtn.Paint
        Home.buttonBorderRadius(sender, 20)
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Dim bhandled As Boolean = False



        Select Case keyData
            Case Keys.Escape
                Me.Close()
                bhandled = True

            Case Keys.Enter

                Try
                    patientRecordSelect3 = "select * From Patient_Health_Records Where Patient_ID = '" & TextBoxEnterID.Text & "' AND Specialist_ID = '" & Home.LabelSpecialistId.Text & "' "
                    PatientHealthRecords_Table(patientRecordSelect3)
                    patientRecordDataTable3 = PatientHealthRecords_Table(patientRecordSelect3)
                    If TextBoxEnterID.Text = Nothing Then
                        MessageBox.Show("Enter Patient ID")
                    Else
                        If patientRecordDataTable3.Rows.Count Then



                            patientRecordSelectAll = "SELECT Record_ID AS 'RECORD ID', Patient_ID AS 'PATIENT ID' ,Date AS 'DATE',Time AS 'TIME',Body_Temperature AS 'BODY TEMP',Systolic AS 'BLOOD PRESSURE (Systolic)',Diastolic AS 'BLOOD PRESSURE (Diastolic)' ,Pulse AS 'PULSE' ,Weight AS 'WEIGHT'
                 
                  FROM  Patient_Health_Records
                  WHERE  Patient_ID = '" & TextBoxEnterID.Text & "'  AND Specialist_ID = '" & Home.LabelSpecialistId.Text & "' ORDER BY Record_ID  DESC"

                            PatientHealthRecords_Table(patientRecordSelectAll)
                            UpdatePatientHealthRecord.DataGridViewUpdateRecords.DataSource = PatientHealthRecords_Table(patientRecordSelectAll)
                            If UpdatePatientHealthRecord.DataGridViewUpdateRecords.RowCount = 0 Then
                                UpdatePatientHealthRecord.GroupBoxNoData.Visible = True
                            Else
                                UpdatePatientHealthRecord.GroupBoxNoData.Visible = False
                            End If
                            UpdatePatientHealthRecord.Show()
                            Home.Hide()
                            Me.Close()
                        Else
                            MessageBox.Show("Patient ID doesn't exit")
                            TextBoxEnterID.Select()
                            TextBoxEnterID.Clear()

                        End If
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                bhandled = True

            Case Keys.Home
                Home.Show()
                Me.Hide()

                Dim Msg1 As String
                Msg1 = MessageBox.Show("Are you sure you would like to exit?", "", MessageBoxButtons.YesNo)
                If Msg1 = DialogResult.Yes Then
                    Application.Exit()
                End If
                bhandled = True

        End Select



        Return False

    End Function

    Private Sub TextBoxEnterID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxEnterID.KeyPress
        Static firstLetter As Char
        Static secondLetter As Char
        Static thirdLetter As Char

        If firstLetter = "-"c Or TextBoxEnterID.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
        If firstLetter = "-"c Or TextBoxEnterID.Text.Length = 1 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        secondLetter = e.KeyChar
        If firstLetter = "-"c Or TextBoxEnterID.Text.Length = 2 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        thirdLetter = e.KeyChar
    End Sub
End Class