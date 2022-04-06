Imports System.Data.SqlClient

Module SQLDatabaseModule
    Public patient_SqlDataReader As SqlDataReader
    Public patientHealthRecords_SqlDataReader As SqlDataReader
    Public healthSpecialist_SqlDataReader As SqlDataReader



    Public Function Patient_Table(patientSqlCommand As String) As DataTable
        Dim patientDataTable As New DataTable
        Try
            Using patientConnection As New SqlConnection(My.Settings.Patient)
                If patientConnection.State = ConnectionState.Closed Then
                    patientConnection.Open()
                End If
                Using patientCommand As New SqlCommand(patientSqlCommand, patientConnection)
                    patient_SqlDataReader = patientCommand.ExecuteReader
                    patientDataTable.Load(patient_SqlDataReader)
                End Using
                patientConnection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return patientDataTable
    End Function


    Public Function PatientHealthRecords_Table(patientHealthRecordsSqlCommand As String) As DataTable
        Dim patientHealthRecordsDataTable As New DataTable
        Try
            Using patientHealthRecordsConnection As New SqlConnection(My.Settings.Patient_Health_Records)
                If patientHealthRecordsConnection.State = ConnectionState.Closed Then
                    patientHealthRecordsConnection.Open()
                End If
                Using patientHealthRecordsCommand As New SqlCommand(patientHealthRecordsSqlCommand, patientHealthRecordsConnection)
                    patientHealthRecords_SqlDataReader = patientHealthRecordsCommand.ExecuteReader
                    patientHealthRecordsDataTable.Load(patientHealthRecords_SqlDataReader)
                End Using
                patientHealthRecordsConnection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return patientHealthRecordsDataTable
    End Function


    Public Function HealthSpecialist_Table(healthSpecialistSqlCommand As String) As DataTable
        Dim healthSpecialistDataTable As New DataTable
        Try
            Using healthSpecialistConnection As New SqlConnection(My.Settings.Health_Specialist)
                If healthSpecialistConnection.State = ConnectionState.Closed Then
                    healthSpecialistConnection.Open()
                End If
                Using healthSpecialistCommand As New SqlCommand(healthSpecialistSqlCommand, healthSpecialistConnection)
                    healthSpecialist_SqlDataReader = healthSpecialistCommand.ExecuteReader
                    healthSpecialistDataTable.Load(healthSpecialist_SqlDataReader)
                End Using
                healthSpecialistConnection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return healthSpecialistDataTable
    End Function

    Public Sub getLabelText(_patientSqlCommand As String, EveryLabel As Label)
        Try
            Dim txt As String
            Using _patientConnection As New SqlConnection(My.Settings.Patient)
                If _patientConnection.State = ConnectionState.Closed Then
                    _patientConnection.Open()
                End If
                Using _patientCommand As New SqlCommand(_patientSqlCommand, _patientConnection)

                    txt = IIf(IsDBNull(_patientCommand.ExecuteScalar), "", _patientCommand.ExecuteScalar)


                    EveryLabel.Text = txt


                End Using

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub getTextBoxText(_patientSqlCommand1 As String, EveryTextBox As TextBox)
        Try
            Dim txt1 As String
            Using _patientConnection1 As New SqlConnection(My.Settings.Patient)
                If _patientConnection1.State = ConnectionState.Closed Then
                    _patientConnection1.Open()
                End If
                Using _patientCommand1 As New SqlCommand(_patientSqlCommand1, _patientConnection1)

                    txt1 = IIf(IsDBNull(_patientCommand1.ExecuteScalar), "", _patientCommand1.ExecuteScalar)


                    EveryTextBox.Text = txt1


                End Using

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub getComboBoxText(_patientSqlCommand5 As String, EveryCombo As ComboBox)
        Try
            Dim txt5 As String
            Using _patientConnection5 As New SqlConnection(My.Settings.Patient)
                If _patientConnection5.State = ConnectionState.Closed Then
                    _patientConnection5.Open()
                End If
                Using _patientCommand5 As New SqlCommand(_patientSqlCommand5, _patientConnection5)

                    txt5 = IIf(IsDBNull(_patientCommand5.ExecuteScalar), "", _patientCommand5.ExecuteScalar)


                    EveryCombo.Text = txt5

                    If EveryCombo.Text = "Male" Then
                        EveryCombo.SelectedIndex = 0
                    ElseIf EveryCombo.Text = "Female" Then
                        EveryCombo.SelectedIndex = 1
                    End If


                End Using

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub getDateTimePickerText(_patientSqlCommand3 As String, EveryDateTimePicker As DateTimePicker)
        Try
            Dim txt3 As String
            Using _patientConnection3 As New SqlConnection(My.Settings.Patient)
                If _patientConnection3.State = ConnectionState.Closed Then
                    _patientConnection3.Open()
                End If
                Using _patientCommand3 As New SqlCommand(_patientSqlCommand3, _patientConnection3)

                    txt3 = IIf(IsDBNull(_patientCommand3.ExecuteScalar), "", _patientCommand3.ExecuteScalar)


                    EveryDateTimePicker.Value = txt3


                End Using

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
