
'class Name     : DatabaseConnector
'Student number : 37016814
'Module         : ICT3611 
'Description    : handles motor club reseults display edition and delete 



Public Class FrmRaceResults

    Private Access As New DataLayer.DbAControl

    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception) 'reporting errors
            Return False
        Else
            Return True
        End If
    End Function


    Private Sub RaceResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
        RefreshGrid()
        populateRace()
    End Sub

    Public Sub RefreshGrid()
        Access.ExecQuery("SELECT * FROM Drivers ORDER BY MemberNumber ASC")


        'report and abort errors
        If NoErrors(True) = False Then Exit Sub

        'clear combobox

        cbxDriver.Items.Clear()
        cbxRace.Items.Clear()

        ' FILL COMBOBOX
        For Each R As DataRow In Access.DBDT.Rows

            cbxDriver.Items.Add(R("MemberNumber"))

        Next
        ' DISPLAY FIRS NAME FOUND

        If Access.RecordCount > 0 Then cbxDriver.SelectedIndex = 0

    End Sub

    Public Sub populateRace()
        Access.ExecQuery("SELECT * FROM Event ORDER BY Title ASC")

        'report and abort errors
        If NoErrors(True) = False Then Exit Sub


        'clear combobox

        cbxRace.Items.Clear()

        ' FILL COMBOBOX
        For Each R As DataRow In Access.DBDT.Rows
            cbxRace.Items.Add(R("Title"))
        Next
        ' DISPLAY FIRS NAME FOUND
        If Access.RecordCount > 0 Then cbxRace.SelectedIndex = 0

    End Sub




    Private Sub AddResults()


        Access.AddParam("@Title", cbxRace.Text)
        Access.AddParam("@MemberNumber", cbxDriver.Text)
        Access.AddParam("@Position", txtPosition.Text)



        ' insert command 

        Access.ExecQuery("INSERT INTO RaceResults (Title,MemberNumber,[Position]) " & _
        "VALUES (@Title,@MemberNumbe,@Position); ")







        'REPORT & Abort on Errors

        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        'if sucesseful 
        MsgBox(" Driver RaceRecord Added to the Database Successfully.")

        dgvResults.Refresh()
        frmDrivers.RefreshGrid()
        Me.Refresh()

    End Sub

    Private Sub DeleteResults()
        If MsgBox("sure you want to delete the seleted Race Results? ", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.No Then Exit Sub

        'delete selected Results
        Access.AddParam("@MemberNumber", cbxDriver.Text)
        Access.ExecQuery("DELETE FROM RaceInfo WHERE MemberNumber=@MemberNumber")

        ' REPORT & ABORT ON ERRORS
        If NoErrors(True) = False Then Exit Sub

        'Refresh datagridview
        RefreshGrid()

    End Sub

    Private Sub SelecetedResults(MemberNumber As String)
        'query event name 
        Access.AddParam("@MemberNumber", MemberNumber)
        Access.ExecQuery("SELECT TOP 1 MemberNumber, Title  FROM  [RaceInfo] WHERE MemberNumber=@MemberNumber ")

        ' REPORT & ABORT ON ERRORS if no records where found 
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        ' retrive first row found 
        Dim R As DataRow = Access.DBDT.Rows(0)

        'populate the textbox with data
        cbxDriver.Text = R("MemberNumber").ToString
        cbxRace.Text = R("Title").ToString

        'enable Delete
        btnDelete.Enabled = True

    End Sub





    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        AddResults()
        load_data()
        dgvResults.Refresh()
        Me.Refresh()
    End Sub

    Private Sub FrmRaceResults_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Run Query 
        Access.ExecQuery("SELECT * FROM [RaceInfo] ORDER BY Title ASC")

        ' fill the Race Datagrid
        dgvResults.DataSource = Access.DBDT


    End Sub

    Private Sub load_data()

        'Run Query 
        Access.ExecQuery("SELECT * FROM RaceResults ORDER BY Title ASC")

        ' fill the Race Datagrid
        dgvResults.DataSource = Access.DBDT


    End Sub







    Private Sub dgvResults_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResults.CellClick

        'prevante out of Index range  selection error 
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        'Select results  from Column 2 of row clicked 
        SelecetedResults(dgvResults.Item(1, e.RowIndex).Value)

    End Sub

    Private Sub dgvResults_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResults.CellContentClick

    End Sub

    Private Sub cbxDriver_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDriver.SelectedIndexChanged

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteResults()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class