Public Class Doctor_Nurse
    Dim specialistSelect As String
    Dim specialistDataTable As DataTable
    Dim specialistInsertString As String

    Private Sub TextBoxSpecialist_ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSpecialist_ID.KeyPress
        Static firstLetter As Char
        Static secondLetter As Char
        Static thirdLetter As Char

        If firstLetter = "-"c Or TextBoxSpecialist_ID.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
        If firstLetter = "-"c Or TextBoxSpecialist_ID.Text.Length = 1 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        secondLetter = e.KeyChar
        If firstLetter = "-"c Or TextBoxSpecialist_ID.Text.Length = 2 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        thirdLetter = e.KeyChar
    End Sub

    Private Sub TextBoxSpecialistSurname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSpecialistLastname.KeyPress
        Static firstLetter As Char
        If firstLetter = "-"c Or TextBoxSpecialistLastname.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
    End Sub

    Private Sub TextBoxSpecialistFirstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSpecialistFirstname.KeyPress
        Static firstLetter As Char
        If firstLetter = "-"c Or TextBoxSpecialistFirstname.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
    End Sub

    Private Sub TextBoxSpecialistOthername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSpecialistOthername.KeyPress
        Static firstLetter As Char
        If firstLetter = "-"c Or TextBoxSpecialistOthername.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
    End Sub

    Private Sub ComboBoxSpecialistSex_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxSpecialistSex.KeyPress
        Static firstLetter As Char
        If firstLetter = "-"c Or ComboBoxSpecialistSex.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
    End Sub

    Private Sub Doctor_Nurse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxSpecialist_ID.Select()
    End Sub

    Private Sub TextBoxSpecialist_ID_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxSpecialist_ID.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxSpecialistFirstname.Select()
        End If
    End Sub

    Private Sub TextBoxSpecialistSurname_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxSpecialistLastname.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxSpecialistOthername.Select()
        End If
    End Sub

    Private Sub TextBoxSpecialistFirstname_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxSpecialistFirstname.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBoxSpecialistLastname.Select()
        End If
    End Sub

    Private Sub TextBoxSpecialistOthername_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxSpecialistOthername.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBoxSpecialistSex.Select()
        End If
    End Sub

    Private Sub ComboBoxSpecialistSex_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBoxSpecialistSex.KeyDown
        If e.KeyCode = Keys.Enter Then
            specialistSavebtn.Select()
        End If
    End Sub

    Private Sub specialistSavebtn_Paint(sender As Object, e As PaintEventArgs) Handles specialistSavebtn.Paint
        Home.buttonBorderRadius(sender, 30)
    End Sub
    Private Sub AllTxt2()
        If TextBoxSpecialist_ID.Text = Nothing And TextBoxSpecialistFirstname.Text = Nothing And TextBoxSpecialistLastname.Text = Nothing And ComboBoxSpecialistSex.Text = Nothing And ComboBoxSpecialistSex.SelectedIndex = -1 Then
            MessageBox.Show("Kindly fill in provided spaces")
            TextBoxSpecialist_ID.Select()
        Else
            SpecialistIdTxt()

        End If



    End Sub
    Private Sub SpecialistIdTxt()
        If TextBoxSpecialist_ID.Text = Nothing Then
            MessageBox.Show("Enter Doctor/Nurse ID")
            TextBoxSpecialist_ID.Select()
        Else
            SpecialistFirstnameTxt()
        End If
    End Sub

    Private Sub SpecialistLastnameTxt()
        If TextBoxSpecialistLastname.Text = Nothing Then
            MessageBox.Show("Enter Lastname")
            TextBoxSpecialistLastname.Select()
        Else
            SpecialistOthernameTxt()
        End If
    End Sub
    Private Sub InspectAndSave()
        specialistSelect = "select * From Health_Specialist Where Specialist_ID = '" & TextBoxSpecialist_ID.Text & "' "
        HealthSpecialist_Table(specialistSelect)



        specialistDataTable = HealthSpecialist_Table(specialistSelect)

        If specialistDataTable.Rows.Count Then

            MessageBox.Show("Doctor/Nurse ID already exist", "error", MessageBoxButtons.OK)
            TextBoxSpecialist_ID.Select()
            TextBoxSpecialist_ID.Clear()



        Else
            InsertIntoSpecialist()
            clear2()
            MessageBox.Show("Successfully Added")

        End If
    End Sub

    Private Sub InsertIntoSpecialist()

        If ComboBoxSpecialistSex.SelectedIndex = 0 Then
            labelInvisible1.Text = "Male"
        ElseIf ComboBoxSpecialistSex.SelectedIndex = 1 Then
            labelInvisible1.Text = "Female"

        End If

        If TextBoxSpecialistOthername.Text = "" Then
            TextBoxSpecialistOthername.Text = "-------"
        End If
        specialistInsertString = "INSERT INTO Health_Specialist
               (Specialist_ID,Firstname,Lastname,Othername,Sex)
                VALUES('" & TextBoxSpecialist_ID.Text & "','" & TextBoxSpecialistFirstname.Text & "','" & TextBoxSpecialistLastname.Text & "','" & TextBoxSpecialistOthername.Text & "','" & labelInvisible1.Text & "')"
        HealthSpecialist_Table(specialistInsertString)
    End Sub

    Private Sub clear2()
        TextBoxSpecialist_ID.Clear()
        TextBoxSpecialistLastname.Clear()
        TextBoxSpecialistFirstname.Clear()
        TextBoxSpecialistOthername.Clear()
        ComboBoxSpecialistSex.Text = ""
        ComboBoxSpecialistSex.SelectedIndex = -1
    End Sub
    Private Sub SpecialistFirstnameTxt()
        If TextBoxSpecialistFirstname.Text = Nothing Then
            MessageBox.Show("Enter Firstname")
            TextBoxSpecialistFirstname.Select()
        Else
            SpecialistLastnameTxt()

        End If
    End Sub
    Private Sub SpecialistOthernameTxt()
        If TextBoxSpecialistOthername.Text = Nothing Then

            TextBoxSpecialistOthername.Text = "---------"
            SecialistSexTxt()
        Else
            SecialistSexTxt()
        End If
    End Sub

    Private Sub SecialistSexTxt()
        If ComboBoxSpecialistSex.SelectedIndex = -1 Then
            If ComboBoxSpecialistSex.Text.ToUpper = "MALE" Then
                ComboBoxSpecialistSex.SelectedIndex = 0
                InspectAndSave()

            ElseIf ComboBoxSpecialistSex.Text.ToUpper = "FEMALE" Then
                ComboBoxSpecialistSex.SelectedIndex = 1
                InspectAndSave()



            Else
                MessageBox.Show("Select Patient's Sex")
                ComboBoxSpecialistSex.Select()

            End If

        Else
            InspectAndSave()


        End If
    End Sub

    Private Sub specialistSavebtn_Click(sender As Object, e As EventArgs) Handles specialistSavebtn.Click
        Try
            AllTxt2()

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
End Class