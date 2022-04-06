Public Class Search
    Private Sub Okbtn_Paint(sender As Object, e As PaintEventArgs) Handles Okbtn.Paint
        Home.buttonBorderRadius(sender, 25)

    End Sub

    Private Sub Cancelbtn_Paint(sender As Object, e As PaintEventArgs)
        Home.buttonBorderRadius(sender, 25)

    End Sub

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButtonPatientID.Focus()
        RadioButtonPatientID.Select()
    End Sub

    Private Sub RadioButtonPatientID_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPatientID.CheckedChanged
        If RadioButtonPatientID.Checked = True Then
            RadioButtonDate.Checked = False
            RadioButtonSex.Checked = False

        End If
    End Sub






    Private Sub RadioButtonDate_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDate.CheckedChanged
        If RadioButtonDate.Checked = True Then
            RadioButtonSex.Checked = False
            RadioButtonPatientID.Checked = False

        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Dim bhandled As Boolean = False



        Select Case keyData
            Case Keys.Escape
                Me.Close()


                bhandled = True

            Case Keys.Down
                If RadioButtonPatientID.Focused And RadioButtonPatientID.Checked Then
                    RadioButtonPatientID.Checked = False
                    RadioButtonSex.Checked = False
                    RadioButtonDate.Select()
                    RadioButtonDate.Focus()

                    bhandled = True
                ElseIf RadioButtonDate.Focused And RadioButtonDate.Checked Then
                    RadioButtonPatientID.Checked = False
                    RadioButtonDate.Checked = False
                    RadioButtonSex.Select()
                    RadioButtonSex.Focus()
                    bhandled = True
                ElseIf RadioButtonSex.Focused And RadioButtonSex.Checked Then
                    RadioButtonPatientID.Checked = False
                    RadioButtonDate.Checked = False

                    Okbtn.Select()
                    Okbtn.Focus()
                    bhandled = True

                ElseIf Okbtn.Focused
                    RadioButtonSex.Checked = False
                    RadioButtonDate.Checked = False
                    RadioButtonPatientID.Select()
                    RadioButtonPatientID.Focus()
                    bhandled = True

                End If
            Case Keys.Home
                Me.Hide()
                Dim Msg1 As String
                Msg1 = MessageBox.Show("Are you sure you would like to exit?", "", MessageBoxButtons.YesNo)
                If Msg1 = DialogResult.Yes Then
                    Application.Exit()
                End If

            Case Keys.Up
                If RadioButtonPatientID.Focused And RadioButtonPatientID.Checked Then
                    RadioButtonPatientID.Checked = True
                    RadioButtonDate.Checked = False
                    RadioButtonSex.Checked = False
                    Okbtn.Select()
                    Okbtn.Focus()

                    bhandled = True
                ElseIf RadioButtonDate.Focused And RadioButtonDate.Checked Then
                    RadioButtonDate.Checked = False
                    RadioButtonSex.Checked = False
                    RadioButtonPatientID.Select()
                    RadioButtonPatientID.Focus()
                    bhandled = True

                ElseIf RadioButtonSex.Focused And RadioButtonSex.Checked Then
                    RadioButtonSex.Checked = False
                    RadioButtonPatientID.Checked = False
                    RadioButtonDate.Select()
                    RadioButtonDate.Focus()
                    bhandled = True
                ElseIf Okbtn.Focused
                    RadioButtonDate.Checked = False
                    RadioButtonPatientID.Checked = False
                    RadioButtonSex.Select()
                    RadioButtonSex.Focus()
                    bhandled = True

                End If



            Case Keys.Enter
                If RadioButtonPatientID.Focused And RadioButtonPatientID.Checked Then
                    Me.Hide()
                    SearchPatientID.Show()

                    bhandled = True
                ElseIf RadioButtonDate.Focused And RadioButtonDate.Checked Then

                    Me.Hide()
                    SearchDate.Show()
                ElseIf RadioButtonSex.Focused And RadioButtonSex.Checked Then

                    Me.Hide()
                    SearchBySex.Show()
                ElseIf Okbtn.Focused

                    If RadioButtonPatientID.Checked = True Then
                        Me.Hide()
                        SearchPatientID.Show()

                    ElseIf RadioButtonDate.Checked = True Then
                        Me.Hide()
                        SearchDate.Show()

                    ElseIf RadioButtonSex.Checked = True Then
                        Me.Hide()
                        SearchBySex.Show()


                    Else
                        MessageBox.Show("Select one")
                    End If


                End If








        End Select



        Return True

    End Function




    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs)
        Me.Close()


    End Sub

    Private Sub Okbtn_Click(sender As Object, e As EventArgs) Handles Okbtn.Click
        If RadioButtonPatientID.Checked = True Then
            Me.Hide()
            SearchPatientID.Show()

        ElseIf RadioButtonDate.Checked = True Then
            Me.Hide()
            SearchDate.Show()

        ElseIf RadioButtonSex.Checked = True Then
            Me.Hide()
            SearchBySex.Show()


        Else
            MessageBox.Show("Select one")
        End If

    End Sub

    Private Sub RadioButtonSex_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSex.CheckedChanged
        If RadioButtonSex.Checked = True Then
            RadioButtonDate.Checked = False
            RadioButtonPatientID.Checked = False

        End If
    End Sub
End Class