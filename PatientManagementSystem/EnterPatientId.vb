Public Class EnterPatientId
    Private Sub AddRecordSavebtn_Paint(sender As Object, e As PaintEventArgs) Handles EnterPatientIDokbtn.Paint
        Home.buttonBorderRadius(sender, 20)

    End Sub

    Private Sub EnterPatientIDokbtn_Click(sender As Object, e As EventArgs) Handles EnterPatientIDokbtn.Click
        If TextBoxPatID.Text = Nothing Then
            MessageBox.Show("Enter Patient ID")
        Else
            Dim patientSelect1 As String
            Dim patientDataTable As DataTable
            patientSelect1 = "select * From Patient Where Patient_ID = '" & TextBoxPatID.Text & "' "
            Patient_Table(patientSelect1)
            patientDataTable = Patient_Table(patientSelect1)

            If patientDataTable.Rows.Count Then

                AddNewPatientRecord.TextBoxPatIDtxt.Text = TextBoxPatID.Text
                AddNewPatientRecord.Show()
                Me.Close()



            Else
                MessageBox.Show("Patient ID doesn't exit")
                TextBoxPatID.Select()
                TextBoxPatID.Clear()

            End If
        End If



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

            Case Keys.Enter


                If TextBoxPatID.Text = Nothing Then
                    MessageBox.Show("Enter Patient ID")
                Else
                    Dim patientSelect1 As String
                    Dim patientDataTable As DataTable
                    patientSelect1 = "select * From Patient Where Patient_ID = '" & TextBoxPatID.Text & "' "
                    Patient_Table(patientSelect1)
                    patientDataTable = Patient_Table(patientSelect1)

                    If patientDataTable.Rows.Count Then

                        AddNewPatientRecord.TextBoxPatIDtxt.Text = TextBoxPatID.Text
                        AddNewPatientRecord.Show()
                        Me.Close()



                    Else
                        MessageBox.Show("Patient ID doesn't exit")
                        TextBoxPatID.Select()
                        TextBoxPatID.Clear()

                    End If
                End If


                bhandled = True


        End Select



        Return False

    End Function

    Private Sub TextBoxPatID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPatID.KeyPress
        Static firstLetter As Char
        Static secondLetter As Char
        Static thirdLetter As Char

        If firstLetter = "-"c Or TextBoxPatID.Text.Length = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        firstLetter = e.KeyChar
        If firstLetter = "-"c Or TextBoxPatID.Text.Length = 1 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        secondLetter = e.KeyChar
        If firstLetter = "-"c Or TextBoxPatID.Text.Length = 2 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
        thirdLetter = e.KeyChar
    End Sub
End Class