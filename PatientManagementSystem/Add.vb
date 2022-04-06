Public Class Add
    Private Sub NewPatientRecord_Paint(sender As Object, e As PaintEventArgs) Handles NewPatientRecord.Paint

        Home.buttonBorderRadius(sender, 30)
    End Sub

    Private Sub NewPatient_Paint(sender As Object, e As PaintEventArgs) Handles NewPatient.Paint
        Home.buttonBorderRadius(sender, 30)

    End Sub

    Private Sub NewPatient_Click(sender As Object, e As EventArgs) Handles NewPatient.Click
        Me.Close()
        AddNewPatient.Show()
    End Sub

    Private Sub NewPatientRecord_Click(sender As Object, e As EventArgs) Handles NewPatientRecord.Click
        Me.Close()
        EnterPatientId.Show()
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
            Case Keys.Enter
                If NewPatient.Focused Then
                    Me.Close()
                    AddNewPatient.Show()
                    bhandled = True
                ElseIf NewPatientRecord.Focused Then
                    Me.Close()
                    EnterPatientId.Show()
                    bhandled = True

                End If


            Case Keys.Up
                If NewPatient.Focused Then
                    NewPatientRecord.Focus()
                    bhandled = True
                ElseIf NewPatientRecord.Focused Then
                    NewPatient.Focus()
                    bhandled = True

                End If


            Case Keys.Down
                If NewPatient.Focused Then
                    NewPatientRecord.Focus()
                    bhandled = True

                ElseIf NewPatientRecord.Focused Then
                    NewPatient.Focus()
                    bhandled = True

                End If


        End Select



        Return True

        End Function

    Private Sub Add_Load1(sender As Object, e As EventArgs) Handles MyBase.Load
        NewPatientRecord.Select()
    End Sub
End Class