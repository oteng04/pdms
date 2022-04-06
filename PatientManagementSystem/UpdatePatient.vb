Public Class UpdatePatient
    Dim patientSelect1 As String
    Dim patientRecordSelect1 As String
    Dim patientDelete As String
    Dim patientRecordDelete As String
    Dim patientDataTable As DataTable
    Dim patientRecordDataTable As DataTable
    Dim selectAllRecords As String
    Dim patientSelect As String
    Dim patientUpdate As String
    Private Sub update_Updatebtn2_Paint(sender As Object, e As PaintEventArgs) Handles update_Updatebtn2.Paint
        Home.buttonBorderRadius(sender, 30)
    End Sub

    Private Sub update_DeleteBtn2_Paint(sender As Object, e As PaintEventArgs) Handles update_DeleteBtn2.Paint
        Home.buttonBorderRadius(sender, 30)
    End Sub

    Private Sub UpdatePatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TODO: This line of code loads data into the 'PatientTableDataSet.Patient' table. You can move, or remove it, as needed.


    End Sub



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

    Private Sub update_DeleteBtn2_Click(sender As Object, e As EventArgs) Handles update_DeleteBtn2.Click
        Try

            Dim dialogResult5 As DialogResult
            dialogResult5 = MessageBox.Show("Are you sure you would like to delete this record", "", MessageBoxButtons.YesNo)

            If dialogResult5 = DialogResult.Yes Then
                If TextBoxPatientID_UpdateMain.Text = Nothing Then
                    MessageBox.Show("Enter Patient ID")
                Else

                    patientSelect1 = "select * From Patient Where Patient_ID = '" & TextBoxPatientID_UpdateMain.Text & "' "
                    Patient_Table(patientSelect1)
                    patientDataTable = Patient_Table(patientSelect1)

                    patientRecordSelect1 = "select * From Patient_Health_Records Where Patient_ID = '" & TextBoxPatientID_UpdateMain.Text & "' AND Specialist_ID = '" & Home.LabelSpecialistId.Text & "' "
                    PatientHealthRecords_Table(patientRecordSelect1)
                    patientRecordDataTable = PatientHealthRecords_Table(patientRecordSelect1)



                    If patientDataTable.Rows.Count Then
                        If patientRecordDataTable.Rows.Count Then
                            patientRecordDelete = "DELETE 
                                     FROM Patient_Health_Records 
                                     WHERE Patient_ID = '" & TextBoxPatientID_UpdateMain.Text & "' "
                            PatientHealthRecords_Table(patientRecordDelete)

                        End If


                        selectAllRecords = "SELECT Patient_ID AS 'PATIENT ID' ,Date AS 'DATE',Time AS 'TIME',Body_Temperature AS 'BODY TEMP',Systolic AS 'BLOOD PRESSURE (Systolic)',Diastolic AS 'BLOOD PRESSURE (Diastolic)' ,Pulse AS 'PULSE' ,Weight AS 'WEIGHT'
                 
                          FROM  Patient_Health_Records
                           WHERE Specialist_ID = '" & Home.LabelSpecialistId.Text & "'ORDER BY Record_ID  DESC"

                        PatientHealthRecords_Table(selectAllRecords)
                        Home.AllData.DataSource = PatientHealthRecords_Table(selectAllRecords)

                        patientDelete = "DELETE 
                                     FROM Patient 
                                     WHERE Patient_ID = '" & TextBoxPatientID_UpdateMain.Text & "' "
                        Patient_Table(patientDelete)

                        Me.Hide()
                        If Home.AllData.RowCount = 0 Then
                            Home.GroupBoxNoData.Visible = True
                        Else
                            Home.GroupBoxNoData.Visible = False
                        End If




                    Else
                        MessageBox.Show("Patient ID doesn't exit")
                        TextBoxPatientID_UpdateMain.Select()
                        TextBoxPatientID_UpdateMain.Text = "ID"

                    End If
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TextBoxPatientID_UpdateMain_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            TextBoxFirstname_updateMain.Select()
        End If
    End Sub

    Private Sub TextBoxSurname_updateMain_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxFirstname_updateMain.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxLastname_updateMain.Select()
        End If
    End Sub

    Private Sub TextBoxFirstname_updateMain_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxLastname_updateMain.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxOthername_updateMain.Select()
        End If
    End Sub

    Private Sub TextBoxOthername_updateMain_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxOthername_updateMain.KeyDown
        If e.KeyCode = Keys.Enter Then
            DateTimePickerDOB_updateMain.Select()
        End If
    End Sub

    Private Sub DateTimePickerDOB_updateMain_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePickerDOB_updateMain.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBoxPatientSex_updateMain.Select()
        End If
    End Sub

    Private Sub ComboBoxPatientSex_updateMain_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBoxPatientSex_updateMain.KeyDown
        If e.KeyCode = Keys.Enter Then
            update_Updatebtn2.Select()
        End If
    End Sub



    Private Sub update_Updatebtn2_Click(sender As Object, e As EventArgs) Handles update_Updatebtn2.Click
        AllTxt()
    End Sub
    Private Sub AllTxt()
        If TextBoxPatientID_UpdateMain.Text = Nothing And TextBoxFirstname_updateMain.Text = Nothing And TextBoxLastname_updateMain.Text = Nothing Then
            MessageBox.Show("Kindly fill in provided spaces")
            TextBoxPatientID_UpdateMain.Select()
        Else
            PatientIdTxt()

        End If



    End Sub

    Private Sub PatientIdTxt()
        If TextBoxPatientID_UpdateMain.Text = Nothing Then
            MessageBox.Show("Enter Patient's ID")
            TextBoxPatientID_UpdateMain.Select()
        Else
            PatientFirstnameTxt()
        End If

    End Sub

    Private Sub PatientFirstnameTxt()
        If TextBoxFirstname_updateMain.Text = Nothing Then
            MessageBox.Show("Enter Patient's Firstname")
            TextBoxFirstname_updateMain.Select()
        Else
            PatientLastnameTxt()
        End If
    End Sub

    Private Sub PatientLastnameTxt()
        If TextBoxLastname_updateMain.Text = Nothing Then
            MessageBox.Show("Enter Patient's Lastname")
            TextBoxLastname_updateMain.Select()
        Else
            PatientOthernameTxt()

        End If

    End Sub



    Private Sub PatientOthernameTxt()
        If TextBoxOthername_updateMain.Text = Nothing Then

            TextBoxOthername_updateMain.Text = "---------"
            PatientSexTxt()
        Else
            PatientSexTxt()
        End If


    End Sub
    Private Sub UpdatingPatient()
        Try


            patientUpdate = "UPDATE Patient SET Firstname = '" & TextBoxFirstname_updateMain.Text & "', Lastname = '" & TextBoxLastname_updateMain.Text & "', 
                     Othername = '" & TextBoxOthername_updateMain.Text & "', Date_Of_Birth =  '" & DateTimePickerDOB_updateMain.Value.Date.Date & "' , Sex = '" & ComboBoxPatientSex_updateMain.Text & "'
                    WHERE Patient_ID = '" & TextBoxPatientID_UpdateMain.Text & "'"

            Patient_Table(patientUpdate)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PatientDOBTxt()
        UpdatingPatient()

        MessageBox.Show("Successfully Updated")

        Me.Close()


    End Sub

    Private Sub PatientSexTxt()
        If ComboBoxPatientSex_updateMain.SelectedIndex = -1 Then
            If ComboBoxPatientSex_updateMain.Text.ToUpper = "MALE" Then
                ComboBoxPatientSex_updateMain.SelectedIndex = 0
                PatientDOBTxt()

            ElseIf ComboBoxPatientSex_updateMain.Text.ToUpper = "FEMALE" Then
                ComboBoxPatientSex_updateMain.SelectedIndex = 1
                PatientDOBTxt()



            Else
                MessageBox.Show("Select Patient's Sex")
                ComboBoxPatientSex_updateMain.Select()

            End If

        Else
            PatientDOBTxt()


        End If


    End Sub

    Private Sub TextBoxFirstname_updateMain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxFirstname_updateMain.KeyPress
        Dim firstLetter As Char


        If firstLetter = "-"c Or TextBoxFirstname_updateMain.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar



    End Sub

    Private Sub TextBoxLastname_updateMain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxLastname_updateMain.KeyPress
        Dim firstLetter As Char


        If firstLetter = "-"c Or TextBoxLastname_updateMain.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
    End Sub

    Private Sub TextBoxOthername_updateMain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxOthername_updateMain.KeyPress
        Dim firstLetter As Char
        If firstLetter = "-"c Or TextBoxOthername_updateMain.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
    End Sub
End Class