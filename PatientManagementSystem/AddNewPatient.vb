Imports System.Text.RegularExpressions

Public Class AddNewPatient

    Public patientInsertString As String
    Public patientSelectAll As String
    Public patientSelect As String
    Public patientDataTable As DataTable


    Private Sub SplitContainer2_Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub AddSavebtn_Paint(sender As Object, e As PaintEventArgs) Handles AddSavebtn.Paint
        Home.buttonBorderRadius(sender, 30)

    End Sub





    Public Sub InsertIntoPatient()
        If ComboBoxPatientSex.SelectedIndex = 0 Then
            labelInvisible.Text = "Male"
        ElseIf ComboBoxPatientSex.SelectedIndex = 1 Then
            labelInvisible.Text = "Female"

        End If

        If TextBoxPatientOthername.Text = "" Then
            TextBoxPatientOthername.Text = "-------"
        End If


        patientInsertString = "INSERT INTO PATIENT
               (Patient_ID,Firstname,Lastname,Othername,Date_Of_Birth,Sex)
                VALUES('" & TextBoxPatient_ID.Text & "','" & TextBoxPatientFirstname.Text & "','" & TextBoxPatientLastname.Text & "','" & TextBoxPatientOthername.Text & "','" & DateTimePickerPatientDOB.Value.Date.Date & "','" & labelInvisible.Text & "')"
        Patient_Table(patientInsertString)



    End Sub


    Private Sub AllTxt()
        If TextBoxPatient_ID.Text = Nothing And TextBoxPatientFirstname.Text = Nothing And TextBoxPatientLastname.Text = Nothing Then
            MessageBox.Show("Kindly fill in provided spaces")
            TextBoxPatient_ID.Select()
        Else
            PatientIdTxt()

        End If



    End Sub

    Private Sub PatientIdTxt()
        If TextBoxPatient_ID.Text = Nothing Then
            MessageBox.Show("Enter Patient's ID")
            TextBoxPatient_ID.Select()
        Else
            PatientFirstnameTxt()
        End If

    End Sub

    Private Sub PatientFirstnameTxt()
        If TextBoxPatientFirstname.Text = Nothing Then
            MessageBox.Show("Enter Patient's Firstname")
            TextBoxPatientFirstname.Select()
        Else
            PatientLastnameTxt()
        End If
    End Sub

    Private Sub PatientLastnameTxt()
        If TextBoxPatientLastname.Text = Nothing Then
            MessageBox.Show("Enter Patient's Lastname")
            TextBoxPatientLastname.Select()
        Else
            PatientOthernameTxt()

        End If

    End Sub



    Private Sub PatientOthernameTxt()
        If TextBoxPatientOthername.Text = Nothing Then

            TextBoxPatientOthername.Text = "---------"
            PatientSexTxt()
        Else
            PatientSexTxt()
        End If


    End Sub

    Private Sub PatientDOBTxt()
        If DateTimePickerPatientDOB.Value.ToString = DateTimePickerInvisible.Value.ToString Then
            Dim dialogResult As DialogResult
            dialogResult = MessageBox.Show("Date of Birth equals today's date? [" & DateTimePickerPatientDOB.Value.ToLongDateString & "]", "", MessageBoxButtons.YesNo)

            If dialogResult = DialogResult.No Then

                DateTimePickerPatientDOB.Select()


            ElseIf dialogResult = DialogResult.Yes Then
                patientSelect = "select * From Patient Where Patient_ID = '" & TextBoxPatient_ID.Text & "' "
                Patient_Table(patientSelect)



                patientDataTable = Patient_Table(patientSelect)

                If patientDataTable.Rows.Count Then

                    MessageBox.Show("Patient ID already exist", "error", MessageBoxButtons.OK)
                    TextBoxPatient_ID.Select()
                    TextBoxPatient_ID.Clear()



                Else
                    InsertIntoPatient()
                    clear()
                    MessageBox.Show("Successfully Added")
                    Dim dialogResult6 As DialogResult
                    dialogResult6 = MessageBox.Show("Add another record?", "", MessageBoxButtons.YesNo)
                    If dialogResult6 = DialogResult.No Then
                        Me.Close()

                    Else
                        TextBoxPatient_ID.Select()
                    End If

                End If


            End If
        Else
            InsertIntoPatient()
            clear()
            MessageBox.Show("Successfully Added")
            Dim dialogResult6 As DialogResult
            dialogResult6 = MessageBox.Show("Add another record?", "", MessageBoxButtons.YesNo)
            If dialogResult6 = DialogResult.No Then
                Me.Close()

            Else
                TextBoxPatient_ID.Select()
            End If

        End If


    End Sub

    Private Sub PatientSexTxt()
        If ComboBoxPatientSex.SelectedIndex = -1 Then
            If ComboBoxPatientSex.Text.ToUpper = "MALE" Then
                ComboBoxPatientSex.SelectedIndex = 0
                PatientDOBTxt()

            ElseIf ComboBoxPatientSex.Text.ToUpper = "FEMALE" Then
                ComboBoxPatientSex.SelectedIndex = 1
                PatientDOBTxt()



            Else
                MessageBox.Show("Select Patient's Sex")
                ComboBoxPatientSex.Select()

            End If

        Else
            PatientDOBTxt()


        End If


    End Sub

    Private Sub clear()
        TextBoxPatient_ID.Clear()
        TextBoxPatientLastname.Clear()
        TextBoxPatientOthername.Clear()
        TextBoxPatientFirstname.Clear()
        DateTimePickerPatientDOB.Value = DateTimePickerInvisible.Value
        ComboBoxPatientSex.Text = ""
        ComboBoxPatientSex.SelectedIndex = -1

    End Sub


    Private Sub AddSavebtn_Click(sender As Object, e As EventArgs) Handles AddSavebtn.Click
        Try
            AllTxt()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DateTimePickerPatientDOB_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerPatientDOB.ValueChanged

    End Sub

    Private Sub TextBoxPatient_ID_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPatient_ID.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxPatientFirstname.Select()
        End If




    End Sub

    Private Sub TextBoxPatientSurname_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPatientLastname.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxPatientOthername.Select()
        End If


    End Sub

    Private Sub TextBoxPatientFirstname_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPatientFirstname.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxPatientLastname.Select()
        End If


    End Sub

    Private Sub TextBoxPatientOthername_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPatientOthername.KeyDown
        If e.KeyCode = Keys.Enter Then
            DateTimePickerPatientDOB.Select()
        End If


    End Sub

    Private Sub DateTimePickerPatientDOB_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePickerPatientDOB.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBoxPatientSex.Select()
        End If


    End Sub

    Private Sub ComboBoxPatientSex_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBoxPatientSex.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddSavebtn.Select()
        End If


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub AddNewPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub



    Private Sub TextBoxPatientSurname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPatientLastname.KeyPress
        Static firstLetter As Char
        If firstLetter = "-"c Or TextBoxPatientLastname.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar

    End Sub

    Private Sub TextBoxPatientSurname_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPatientLastname.TextChanged


    End Sub

    Private Sub TextBoxPatientFirstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPatientFirstname.KeyPress
        Static firstLetter As Char
        If firstLetter = "-"c Or TextBoxPatientFirstname.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
    End Sub

    Private Sub TextBoxPatientOthername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPatientOthername.KeyPress
        Static firstLetter As Char
        If firstLetter = "-"c Or TextBoxPatientOthername.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
    End Sub

    Private Sub ComboBoxPatientSex_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxPatientSex.KeyPress
        Static firstLetter As Char
        If firstLetter = "-"c Or ComboBoxPatientSex.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
    End Sub

    Private Sub TextBoxPatient_ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPatient_ID.KeyPress
        Static firstLetter As Char
        Static secondLetter As Char
        Static thirdLetter As Char

        If firstLetter = "-"c Or TextBoxPatient_ID.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
        If firstLetter = "-"c Or TextBoxPatient_ID.Text.Length = 1 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        secondLetter = e.KeyChar
        If firstLetter = "-"c Or TextBoxPatient_ID.Text.Length = 2 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        thirdLetter = e.KeyChar
    End Sub

    Private Sub TextBoxPatientContact_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AddSavebtn_KeyDown(sender As Object, e As KeyEventArgs) Handles AddSavebtn.KeyDown


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

End Class