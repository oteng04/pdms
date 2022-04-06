Public Class _Update
    Private Sub updatePatientBtn_Paint(sender As Object, e As PaintEventArgs) Handles updatePatientBtn.Paint
        Home.buttonBorderRadius(sender, 30)
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
                If updatePatientBtn.Focused Then
                    Me.Close()
                    EnterPatientID_Update1.Show()
                    bhandled = True
                ElseIf updatePatientRecordBtn.Focused Then
                    Me.Close()
                    EnterPatientID_Update2.Show()
                    bhandled = True

                End If


            Case Keys.Up
                If updatePatientBtn.Focused Then
                    updatePatientRecordBtn.Focus()
                    bhandled = True
                ElseIf updatePatientRecordBtn.Focused Then
                    updatePatientBtn.Focus()
                    bhandled = True

                End If


            Case Keys.Down
                If updatePatientBtn.Focused Then
                    updatePatientRecordBtn.Focus()
                    bhandled = True

                ElseIf updatePatientRecordBtn.Focused Then
                    updatePatientBtn.Focus()
                    bhandled = True

                End If



        End Select



        Return True

    End Function


    Private Sub updatePatientRecordBtn_Paint(sender As Object, e As PaintEventArgs) Handles updatePatientRecordBtn.Paint
        Home.buttonBorderRadius(sender, 30)
    End Sub

    Private Sub updatePatientRecordBtn_Click(sender As Object, e As EventArgs) Handles updatePatientRecordBtn.Click
        Me.Close()
        EnterPatientID_Update2.Show()
    End Sub

    Private Sub updatePatientBtn_Click(sender As Object, e As EventArgs) Handles updatePatientBtn.Click
        Me.Close()
        EnterPatientID_Update1.Show()
    End Sub

    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Private Sub _Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updatePatientRecordBtn.Select()
    End Sub
End Class