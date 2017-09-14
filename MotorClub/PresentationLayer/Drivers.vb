Public Class frmDrivers


    

    Private Sub Drivers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Access As New DataLayer.DbAControl


    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception) 'reporting errors
            Return False
        Else
            Return True
        End If
    End Function


    Private Sub Drivers_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        RefreshGrid()

    End Sub

    Public Sub RefreshGrid()

        'run query by reading from the Views
        Access.ExecQuery("SELECT * FROM [DriverInfo]")

        'report and abort errors
        If NoErrors(True) = False Then Exit Sub

        ' FILL DATAGRID
        dgvDriverData.DataSource = Access.DBDT

        'clear combobox

        cbxDrivers.Items.Clear()

        ' FILL COMBOBOX
        For Each R As DataRow In Access.DBDT.Rows
            cbxDrivers.Items.Add(R("MemberNumber"))
        Next
        ' DISPLAY FIRS NAME FOUND
        If Access.RecordCount > 0 Then cbxDrivers.SelectedIndex = 0

    End Sub



    Private Sub SearchDriver(Name As String)
        'this part will search the database for driver name 
        ' ADD PARAMETERS & RUN QUERY
        Access.AddParam("@First_Name", "%" & Name & "%")
        Access.ExecQuery("SELECT * FROM [DriverInfo]" & _
                         "WHERE First_Name LIKE @First_Name")

        ' REPORT & ABORT ON ERRORS
        If NoErrors(True) = False Then Exit Sub


        ' FILL DATAGRIDVIEW
        dgvDriverData.DataSource = Access.DBDT

    End Sub


    Private Sub DeleteDriver()
        If MsgBox("sure you want to delete the seleted Driver? ", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.No Then Exit Sub

        'delete selected Driver
        Access.AddParam("@MemberNumber", txtDelDriver.Text)
        Access.ExecQuery("DELETE FROM [DriverInfo] WHERE MemberNumber=@MemberNumber")

        ' REPORT & ABORT ON ERRORS
        If NoErrors(True) = False Then Exit Sub

        'Refresh datagridview
        txtDelDriver.Clear()
        msiDeleteDriver.Enabled = False
        RefreshGrid()

    End Sub

    Private Sub SelecetedDriver(MemberNumber As String)
        'query event name 
        Access.AddParam("@MemberNumber", MemberNumber)
        Access.ExecQuery("SELECT TOP 1 MemberNumber FROM [DriverInfo] WHERE MemberNumber=@MemberNumber ")

        ' REPORT & ABORT ON ERRORS if no records where found 
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        ' retrive first row found 
        Dim R As DataRow = Access.DBDT.Rows(0)

        'populate the textbox with data
        txtDelDriver.Text = R("MemberNumber").ToString

        'enable Delete
        msiDeleteDriver.Enabled = True

    End Sub





    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchDriver(txtFindDriver.Text)
    End Sub

    Private Sub AddDriverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles msiAddDriver.Click 
        Me.Close()
        frmAddDriver.Show()

    End Sub

    Private Sub cbxDrivers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDrivers.SelectedIndexChanged
        If Not String.IsNullOrEmpty(cbxDrivers.Text) Then SelecetedDriver(cbxDrivers.Text)

    End Sub

    Private Sub dgvDriverData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDriverData.CellClick
        'prevante out of Index range  selection error 
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        'Select Driver MemeberNumber  from Column 1 of row clicked 
        SelecetedDriver(dgvDriverData.Item(0, e.RowIndex).Value)
    End Sub

    Private Sub msiDeleteDriver_Click(sender As Object, e As EventArgs) Handles msiDeleteDriver.Click
        DeleteDriver()
    End Sub

    Private Sub msiAllMembers_Click(sender As Object, e As EventArgs) Handles msiAllMembers.Click
        Me.Close()
        FrmDeleteMember.Show()
    End Sub

    Private Sub msiEditMember_Click(sender As Object, e As EventArgs) Handles msiEditMember.Click
        Me.Close()
        frmUpdateMembers.Show()
    End Sub

    Private Sub msiFile_Click(sender As Object, e As EventArgs) Handles msiFile.Click

    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Motor Racing club application developed by Student number 37016814 for ICT3611", MsgBoxStyle.Information, "About Menu Strip")
    End Sub
End Class