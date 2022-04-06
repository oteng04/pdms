Public Class EnterPatientID_Update1
    Dim SelectPatID As String
    Dim SelectPatSurname As String
    Dim SelectPatFirstname As String
    Dim SelectPatOthername As String
    Dim SelectPatDOB As String
    Dim SelectPatSex As String
    Dim SelectPatContact As String
    Dim patientSelect3 As String
    Dim patientDataTable3 As DataTable

    Private Sub EnterPatientID_Update1okbtn_Click(sender As Object, e As EventArgs) Handles EnterPatientID_Update1okbtn.Click

        patientSelect3 = "select * From Patient Where Patient_ID = '" & Enter_ID1.Text & "' "
        'Specialist_ID = '" & Home.LabelSpecialistId.Text & "' "
        Patient_Table(patientSelect3)
        patientDataTable3 = Patient_Table(patientSelect3)
        If Enter_ID1.Text = Nothing Then
            MessageBox.Show("Enter Patient ID")
        Else
            If patientDataTable3.Rows.Count Then

                SelectPatID = "select Patient_ID From Patient Where Patient_ID = '" & Enter_ID1.Text & "' "
                getLabelText(SelectPatID, UpdatePatient.TextBoxPatientID_UpdateMain)

                SelectPatFirstname = "select Firstname From Patient Where Patient_ID = '" & Enter_ID1.Text & "' "
                getTextBoxText(SelectPatFirstname, UpdatePatient.TextBoxFirstname_updateMain)


                SelectPatSurname = "select Lastname From Patient Where Patient_ID = '" & Enter_ID1.Text & "' "
                getTextBoxText(SelectPatSurname, UpdatePatient.TextBoxLastname_updateMain)

                SelectPatOthername = "select Othername From Patient Where Patient_ID = '" & Enter_ID1.Text & "' "
                getTextBoxText(SelectPatOthername, UpdatePatient.TextBoxOthername_updateMain)



                SelectPatSex = "select Sex From Patient Where Patient_ID = '" & Enter_ID1.Text & "' "
                getComboBoxText(SelectPatSex, UpdatePatient.ComboBoxPatientSex_updateMain)

                SelectPatDOB = "select Date_Of_Birth From Patient Where Patient_ID = '" & Enter_ID1.Text & "' "
                getDateTimePickerText(SelectPatDOB, UpdatePatient.DateTimePickerDOB_updateMain)

                UpdatePatient.Show()

                Me.Close()
            Else
                MessageBox.Show("Patient ID doesn't exit")
                Enter_ID1.Select()
                Enter_ID1.Clear()

            End If
        End If


    End Sub

    Private Sub EnterPatientID_Update1okbtn_Paint(sender As Object, e As PaintEventArgs) Handles EnterPatientID_Update1okbtn.Paint
        Home.buttonBorderRadius(sender, 20)
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Dim bhandled As Boolean = False



        Select Case keyData
            Case Keys.Escape
                Me.Close()
                bhandled = True


            Case Keys.Enter
                patientSelect3 = "select * From Patient Where Patient_ID = '" & Enter_ID1.Text & "' "
                Patient_Table(patientSelect3)
                patientDataTable3 = Patient_Table(patientSelect3)
                If Enter_ID1.Text = Nothing Then
                    MessageBox.Show("Enter Patient ID")
                Else
                    If patientDataTable3.Rows.Count Then

                        SelectPatID = "select Patient_ID From Patient Where Patient_ID = '" & Enter_ID1.Text & "' "
                        getLabelText(SelectPatID, UpdatePatient.TextBoxPatientID_UpdateMain)

                        SelectPatFirstname = "select Firstname From Patient Where Patient_ID = '" & Enter_ID1.Text & "' "
                        getTextBoxText(SelectPatFirstname, UpdatePatient.TextBoxFirstname_updateMain)


                        SelectPatSurname = "select Lastname From Patient Where Patient_ID = '" & Enter_ID1.Text & "' "
                        getTextBoxText(SelectPatSurname, UpdatePatient.TextBoxLastname_updateMain)

                        SelectPatOthername = "select Othername From Patient Where Patient_ID = '" & Enter_ID1.Text & "' "
                        getTextBoxText(SelectPatOthername, UpdatePatient.TextBoxOthername_updateMain)


                        SelectPatSex = "select Sex From Patient Where Patient_ID = '" & Enter_ID1.Text & "' "
                        getComboBoxText(SelectPatSex, UpdatePatient.ComboBoxPatientSex_updateMain)

                        SelectPatDOB = "select Date_Of_Birth From Patient Where Patient_ID = '" & Enter_ID1.Text & "' "
                        getDateTimePickerText(SelectPatDOB, UpdatePatient.DateTimePickerDOB_updateMain)

                        UpdatePatient.Show()




                        Me.Close()
                    Else
                        MessageBox.Show("Patient ID doesn't exit")
                        Enter_ID1.Select()
                        Enter_ID1.Clear()

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
                bhandled = True


        End Select



        Return False

    End Function

    Private Sub Enter_ID1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Enter_ID1.KeyPress
        Static firstLetter As Char
        Static secondLetter As Char
        Static thirdLetter As Char

        If firstLetter = "-"c Or Enter_ID1.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
        If firstLetter = "-"c Or Enter_ID1.Text.Length = 1 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        secondLetter = e.KeyChar
        If firstLetter = "-"c Or Enter_ID1.Text.Length = 2 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        thirdLetter = e.KeyChar
    End Sub
End Class