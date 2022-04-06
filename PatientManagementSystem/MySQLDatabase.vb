Imports MySql.Data.MySqlClient

Module MySQLDatabase
    Public patient_MySqlDataReader As MySqlDataReader
    Public patientHealthRecords_MySqlDataReader As MySqlDataReader
    Public healthSpecialist_MySqlDataReader As MySqlDataReader


    Dim myConnectionString As String


    Public Function ConnectionString() As String
        Dim con As String
        con = "server=127.0.0.1;" _
                    & "uid=root;" _
                    & "pwd=04Prophnectar;" _
                    & "database=db"
        Return con

    End Function

    Public Function SQLPatient_TableMySql(patientMySqlCommand As String) As DataTable
        Dim patientDataTable As New DataTable
        myConnectionString = ConnectionString()

        Try
            Using patientConnection As New MySqlConnection(myConnectionString)
                If patientConnection.State = ConnectionState.Closed Then
                    patientConnection.Open()
                End If
                Using patientCommand As New MySqlCommand(patientMySqlCommand, patientConnection)
                    patient_MySqlDataReader = patientCommand.ExecuteReader
                    patientDataTable.Load(patient_MySqlDataReader)
                End Using
                patientConnection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return patientDataTable
    End Function

    Public Function PatientHealthRecords_TableMySql(patientHealthRecordsMySqlCommand As String) As DataTable
        Dim patientHealthRecordsDataTable As New DataTable
        myConnectionString = ConnectionString()

        Try
            Using patientHealthRecordsConnection As New MySqlConnection(myConnectionString)
                If patientHealthRecordsConnection.State = ConnectionState.Closed Then
                    patientHealthRecordsConnection.Open()
                End If
                Using patientHealthRecordsCommand As New MySqlCommand(patientHealthRecordsMySqlCommand, patientHealthRecordsConnection)
                    patientHealthRecords_MySqlDataReader = patientHealthRecordsCommand.ExecuteReader
                    patientHealthRecordsDataTable.Load(patientHealthRecords_MySqlDataReader)
                End Using
                patientHealthRecordsConnection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return patientHealthRecordsDataTable
    End Function


    Public Function HealthSpecialist_TableMySql(healthSpecialistMySqlCommand As String) As DataTable
        Dim healthSpecialistDataTable As New DataTable
        myConnectionString = ConnectionString()

        Try
            Using healthSpecialistConnection As New MySqlConnection(myConnectionString)
                If healthSpecialistConnection.State = ConnectionState.Closed Then
                    healthSpecialistConnection.Open()
                End If
                Using healthSpecialistCommand As New MySqlCommand(healthSpecialistMySqlCommand, healthSpecialistConnection)
                    healthSpecialist_MySqlDataReader = healthSpecialistCommand.ExecuteReader
                    healthSpecialistDataTable.Load(healthSpecialist_MySqlDataReader)
                End Using
                healthSpecialistConnection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return healthSpecialistDataTable
    End Function

    Public Sub getLabelTextMySql(_patientSqlCommand As String, EveryLabel As Label)
        myConnectionString = ConnectionString()
        Try
            Dim txt As String
            Using _patientConnection As New MySqlConnection(myConnectionString)
                If _patientConnection.State = ConnectionState.Closed Then
                    _patientConnection.Open()
                End If
                Using _patientCommand As New MySqlCommand(_patientSqlCommand, _patientConnection)

                    txt = IIf(IsDBNull(_patientCommand.ExecuteScalar), "", _patientCommand.ExecuteScalar)


                    EveryLabel.Text = txt


                End Using

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub getTextBoxTextMySql(_patientSqlCommand1 As String, EveryTextBox As TextBox)
        myConnectionString = ConnectionString()
        Try
            Dim txt1 As String
            Using _patientConnection1 As New MySqlConnection(myConnectionString)
                If _patientConnection1.State = ConnectionState.Closed Then
                    _patientConnection1.Open()
                End If
                Using _patientCommand1 As New MySqlCommand(_patientSqlCommand1, _patientConnection1)

                    txt1 = IIf(IsDBNull(_patientCommand1.ExecuteScalar), "", _patientCommand1.ExecuteScalar)


                    EveryTextBox.Text = txt1


                End Using

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub getComboBoxTextMySql(_patientSqlCommand5 As String, EveryCombo As ComboBox)
        myConnectionString = ConnectionString()
        Try
            Dim txt5 As String
            Using _patientConnection5 As New MySqlConnection(myConnectionString)
                If _patientConnection5.State = ConnectionState.Closed Then
                    _patientConnection5.Open()
                End If
                Using _patientCommand5 As New MySqlCommand(_patientSqlCommand5, _patientConnection5)

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

    Public Sub getDateTimePickerTextMySql(_patientSqlCommand3 As String, EveryDateTimePicker As DateTimePicker)
        myConnectionString = ConnectionString()
        Try
            Dim txt3 As String
            Using _patientConnection3 As New MySqlConnection(myConnectionString)
                If _patientConnection3.State = ConnectionState.Closed Then
                    _patientConnection3.Open()
                End If
                Using _patientCommand3 As New MySqlCommand(_patientSqlCommand3, _patientConnection3)

                    txt3 = IIf(IsDBNull(_patientCommand3.ExecuteScalar), "", _patientCommand3.ExecuteScalar)


                    EveryDateTimePicker.Value = txt3


                End Using

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Module
