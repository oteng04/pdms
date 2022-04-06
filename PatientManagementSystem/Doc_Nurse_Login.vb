Public Class Doc_Nurse_Login
    Private Sub EnterDoc_Nurse_IDokbtn_Paint(sender As Object, e As PaintEventArgs) Handles EnterDoc_Nurse_IDokbtn.Paint
        Home.buttonBorderRadius(sender, 20)
    End Sub

    Private Sub TextBoxDoc_Nurse_D_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxDoc_Nurse_D.KeyPress
        Static firstLetter As Char
        Static secondLetter As Char
        Static thirdLetter As Char

        If firstLetter = "-"c Or TextBoxDoc_Nurse_D.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
        If firstLetter = "-"c Or TextBoxDoc_Nurse_D.Text.Length = 1 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        secondLetter = e.KeyChar
        If firstLetter = "-"c Or TextBoxDoc_Nurse_D.Text.Length = 2 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        thirdLetter = e.KeyChar
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Dim bhandled As Boolean = False



        Select Case keyData
            Case Keys.Escape
                Me.Close()
                bhandled = True

            Case Keys.Home

                Me.Close()
                bhandled = True
            Case Keys.Enter

                If TextBoxDoc_Nurse_D.Text = Nothing Then
                    MessageBox.Show("Enter ID")
                Else
                    Dim DocSelect As String
                    Dim DocDataTable As DataTable
                    DocSelect = "select * From Health_Specialist Where Specialist_ID = '" & TextBoxDoc_Nurse_D.Text & "'  "
                    HealthSpecialist_Table(DocSelect)
                    DocDataTable = HealthSpecialist_Table(DocSelect)

                    If DocDataTable.Rows.Count Then

                        AddNewPatientRecord.LabelSpecialistId.Text = TextBoxDoc_Nurse_D.Text
                        Home.LabelSpecialistId.Text = TextBoxDoc_Nurse_D.Text
                        Home.Show()
                        Me.Hide()





                    Else
                        MessageBox.Show("ID doesn't exit")

                        TextBoxDoc_Nurse_D.Clear()
                        TextBoxDoc_Nurse_D.Select()

                    End If
                End If
                bhandled = True


        End Select



        Return False

    End Function

    Private Sub EnterDoc_Nurse_IDokbtn_Click(sender As Object, e As EventArgs) Handles EnterDoc_Nurse_IDokbtn.Click

        If TextBoxDoc_Nurse_D.Text = Nothing Then
            MessageBox.Show("Enter ID")
        Else
            Dim DocSelect As String
            Dim DocDataTable As DataTable
            DocSelect = "select * From Health_Specialist Where Specialist_ID = '" & TextBoxDoc_Nurse_D.Text & "'  "
            HealthSpecialist_Table(DocSelect)
            DocDataTable = HealthSpecialist_Table(DocSelect)

            If DocDataTable.Rows.Count Then

                AddNewPatientRecord.LabelSpecialistId.Text = TextBoxDoc_Nurse_D.Text
                Home.LabelSpecialistId.Text = TextBoxDoc_Nurse_D.Text
                Home.Show()
                Me.Hide()





            Else
                MessageBox.Show("ID doesn't exit")

                TextBoxDoc_Nurse_D.Clear()
                TextBoxDoc_Nurse_D.Select()

            End If
        End If
    End Sub
End Class