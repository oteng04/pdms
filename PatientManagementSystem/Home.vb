Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class Home
    Dim selectAllRecords As String
    Dim patientFirstname As String
    Dim patientLastname As String
    Dim patientOthername As String
    Dim patientDOB4Age As String
    Dim patientSex As String
    Dim patientContact As String

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Dim bhandled As Boolean = False



        Select Case keyData



            Case Keys.Right
                If Addbtn.Focused Then
                    Searchbtn.Focus()
                    bhandled = True
                ElseIf Searchbtn.Focused Then
                    Updatebtn.Focus()
                    bhandled = True


                ElseIf Updatebtn.Focused Then
                    ButtonChart.Focus()
                    bhandled = True

                ElseIf ButtonChart.Focused Then
                    ButtonAllRecords.Focus()
                    bhandled = True

                ElseIf ButtonAllRecords.Focused Then
                    Addbtn.Focus()
                    bhandled = True
                Else

                    Addbtn.Focus()
                    bhandled = True



                End If



            Case Keys.Left

                If Addbtn.Focused Then
                    ButtonAllRecords.Focus()
                    bhandled = True
                ElseIf Searchbtn.Focused Then
                    Addbtn.Focus()
                    bhandled = True

                ElseIf Updatebtn.Focused Then
                    Searchbtn.Focus()
                    bhandled = True

                ElseIf ButtonChart.Focused Then
                    Updatebtn.Focus()
                    bhandled = True

                ElseIf ButtonAllRecords.Focused Then
                    ButtonChart.Focus()
                    bhandled = True
                Else

                    Addbtn.Focus()
                    bhandled = True



                End If






            Case Keys.Escape
                For Each form As Form In Application.OpenForms
                    form.WindowState = FormWindowState.Minimized
                Next form
                bhandled = True

            Case Keys.Home
                Dim Msg1 As String
                Msg1 = MessageBox.Show("Are you sure you would like to exit?", "", MessageBoxButtons.YesNo)
                If Msg1 = DialogResult.Yes Then
                    Application.Exit()
                End If


        End Select



        Return False

    End Function

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub SplitContainer2_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer2.SplitterMoved

    End Sub

    Private Sub DateTimeGb_Enter(sender As Object, e As EventArgs) Handles DateTimeGb.Enter

    End Sub

    Private Sub GroupBox3_Paint(sender As Object, e As PaintEventArgs)


    End Sub
    Public Sub buttonBorderRadius(ByRef buttonObj As Object, ByVal borderRadiusINT As Integer)
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        'TOP LEFT CORNER
        p.AddArc(New Rectangle(0, 0, borderRadiusINT, borderRadiusINT), 180, 90)
        p.AddLine(40, 0, buttonObj.Width - borderRadiusINT, 0)
        'TOP RIGHT CORNER
        p.AddArc(New Rectangle(buttonObj.Width - borderRadiusINT, 0, borderRadiusINT, borderRadiusINT), -90, 90)
        p.AddLine(buttonObj.Width, 40, buttonObj.Width, buttonObj.Height - borderRadiusINT)
        'BOTTOM RIGHT CORNER
        p.AddArc(New Rectangle(buttonObj.Width - borderRadiusINT, buttonObj.Height - borderRadiusINT, borderRadiusINT, borderRadiusINT), 0, 90)
        p.AddLine(buttonObj.Width - borderRadiusINT, buttonObj.Height, borderRadiusINT, buttonObj.Height)
        'BOTTOM LEFT CORNER
        p.AddArc(New Rectangle(0, buttonObj.Height - borderRadiusINT, borderRadiusINT, borderRadiusINT), 90, 90)
        p.CloseFigure()

        p.AddArc(0, 0, ClientSize.Height, ClientSize.Height, 90, 180)
        p.AddLine(p.GetLastPoint, New Point(ClientSize.Width - p.GetLastPoint.X * 2, 0))
        p.AddArc(New RectangleF(p.GetLastPoint, New Size(ClientSize.Height, ClientSize.Height)), 270, 180)
        p.CloseFigure()
        buttonObj.Region = New Region(p)





    End Sub






    Private Sub Searchbtn_Paint(sender As Object, e As PaintEventArgs) Handles Searchbtn.Paint
        buttonBorderRadius(sender, 30)



    End Sub


    Private Sub Updatebtn_Paint(sender As Object, e As PaintEventArgs) Handles Updatebtn.Paint
        buttonBorderRadius(sender, 30)

    End Sub

    Private Sub Addbtn_Paint(sender As Object, e As PaintEventArgs) Handles Addbtn.Paint
        buttonBorderRadius(sender, 30)


    End Sub

    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Dim Msg As String
            Msg = MessageBox.Show("Are you sure you would like to exit?", "", MessageBoxButtons.YesNo)
            If Msg = DialogResult.Yes Then
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click

        Search.Show()

    End Sub

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        Add.Show()
    End Sub

    Private Sub SplitContainer2_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer2.Panel1.Paint

    End Sub

    Private Sub AllData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AllData.CellContentClick

    End Sub

    Private Sub Updatebtn_Click(sender As Object, e As EventArgs) Handles Updatebtn.Click
        _Update.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub




    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatientTableDataSet.Patient' table. You can move, or remove it, as needed.
        Addbtn.Focus()
        selectAllRecords = "SELECT Patient_ID AS 'PATIENT ID' ,Date AS 'DATE',Time AS 'TIME',Body_Temperature AS 'BODY TEMP',Systolic AS 'BLOOD PRESSURE (Systolic)',Diastolic AS 'BLOOD PRESSURE (Diastolic)' ,Pulse AS 'PULSE' ,Weight AS 'WEIGHT'
                 
                  FROM  Patient_Health_Records 
 
                        WHERE Specialist_ID = '" & LabelSpecialistId.Text & "' ORDER BY Record_ID  DESC"



        PatientHealthRecords_Table(selectAllRecords)
        AllData.DataSource = PatientHealthRecords_Table(selectAllRecords)
        If AllData.RowCount = 0 Then
            GroupBoxNoData.Visible = True
        Else
            GroupBoxNoData.Visible = False
        End If





    End Sub
    Private Sub Patient_IDLabel1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub AllData_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles AllData.RowEnter
        'Datelbl.Text = AllData.SelectedRows(0).Cells(1).Value.ToString





    End Sub

    Private Sub ButtonAllRecords_Paint(sender As Object, e As PaintEventArgs) Handles ButtonAllRecords.Paint
        buttonBorderRadius(sender, 30)
    End Sub

    Private Sub ButtonAllRecords_Click(sender As Object, e As EventArgs) Handles ButtonAllRecords.Click
        GroupBoxChart.Visible = False
        selectAllRecords = "SELECT Patient_ID AS 'PATIENT ID' ,Date AS 'DATE',Time AS 'TIME',Body_Temperature AS 'BODY TEMP',Systolic AS 'BLOOD PRESSURE (Systolic)',Diastolic AS 'BLOOD PRESSURE (Diastolic)' ,Pulse AS 'PULSE' ,Weight AS 'WEIGHT'
                 
                  FROM  Patient_Health_Records 
                   WHERE Specialist_ID = '" & LabelSpecialistId.Text & "'ORDER BY Record_ID  DESC"

        PatientHealthRecords_Table(selectAllRecords)
        AllData.DataSource = PatientHealthRecords_Table(selectAllRecords)
        If AllData.RowCount = 0 Then
            GroupBoxNoData.Visible = True
        Else
            GroupBoxNoData.Visible = False
        End If
    End Sub

    Private Sub selectFromPatient()






        patientFirstname = "select Firstname From Patient Where Patient_ID = '" & PatientIDlbl.Text & "' "
        Patient_Table(patientFirstname)
        getLabelText(patientFirstname, Firstnamelbl)

        patientLastname = "select Lastname From Patient Where Patient_ID = '" & PatientIDlbl.Text & "' "
        Patient_Table(patientLastname)
        getLabelText(patientLastname, Lastnamelbl)


        patientOthername = "select Othername From Patient Where Patient_ID = '" & PatientIDlbl.Text & "' "
        Patient_Table(patientOthername)
        getLabelText(patientOthername, Othernamelbl)

        patientSex = "select Sex From Patient Where Patient_ID = '" & PatientIDlbl.Text & "' "
        Patient_Table(patientSex)
        getLabelText(patientSex, Genderlbl)


        patientDOB4Age = "select Date_Of_Birth From Patient Where Patient_ID = '" & PatientIDlbl.Text & "' "
        Patient_Table(patientDOB4Age)
        getDateTimePickerText(patientDOB4Age, DateTimeker1)

        Dim year As Integer = DateDiff(DateInterval.Year, DateTimeker1.Value, Now)
        Dim month As Integer = DateDiff(DateInterval.Month, DateTimeker1.Value, Now) Mod 12
        Dim day As Integer = DateDiff(DateInterval.Day, DateTimeker1.Value, Now) Mod 30 - 10
        If year > 0 Then
            If year = 1 Then
                Agelbl.Text = year & " year"
            Else
                Agelbl.Text = year & " years"

            End If

        ElseIf year = 0 Then
            If month = 1 Then
                Agelbl.Text = month & " month"
            ElseIf month > 1
                Agelbl.Text = month & " months"
            ElseIf month = 0 And year = 0 Then
                If day = 1 Then
                    Agelbl.Text = day & " day"
                ElseIf day > 1 Then
                    Agelbl.Text = day & " days"


                ElseIf day = 0 And year = 0 And month = 0
                    Agelbl.Text = "----"

                Else
                    Agelbl.Text = "----"
                End If
            End If

        End If


    End Sub

    Private Sub AllData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AllData.CellClick
        Dim i As Integer
        i = AllData.CurrentRow.Index
        PatientIDlbl.Text = AllData.Item(0, i).Value
        selectFromPatient()
        Dateker1.Value = AllData.Item(1, i).Value
        Datelbl.Text = Dateker1.Value.ToLongDateString
        Timelbl.Text = AllData.Item(2, i).Value.ToString

        Temperaturelbl.Text = AllData.Item(3, i).Value.ToString + " °C"
        BloodPressureHlbl.Text = AllData.Item(4, i).Value.ToString + "/" + AllData.Item(5, i).Value.ToString + " mmHg"
        Pulselbl.Text = AllData.Item(6, i).Value.ToString + " BPM"
        weightlbl.Text = AllData.Item(7, i).Value.ToString + " Kg"
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ButtonChart_Paint(sender As Object, e As PaintEventArgs) Handles ButtonChart.Paint
        buttonBorderRadius(sender, 30)
    End Sub

    Private Sub ButtonChart_Click(sender As Object, e As EventArgs) Handles ButtonChart.Click
        GroupBoxChart.Visible = True
    End Sub

    Private Sub GroupBoxChart_Enter(sender As Object, e As EventArgs) Handles GroupBoxChart.Enter

    End Sub
End Class
