
'class Name     : FrmDeleteMember
'Student number : 37016814
'Module         : ICT3611 
'Description    : Delete members from the database 



Public Class FrmDeleteMember
    Private Access As New DataLayer.DbAControl

    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception) 'reporting errors
            Return False
        Else
            Return True
        End If
    End Function


    Private Sub DeleteDriver_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DeleteDriver_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RefreshGrid()
    End Sub

    Public Sub RefreshGrid()

        'run query by reading from the Views
        Access.ExecQuery("SELECT * FROM Drivers ORDER BY MemberNumber ASC")

        'report and abort errors
        If NoErrors(True) = False Then Exit Sub

        ' FILL DATAGRID
        dgvMembers.DataSource = Access.DBDT

        'clear combobox

        cbxMemberNumber.Items.Clear()

        ' FILL COMBOBOX
        For Each R As DataRow In Access.DBDT.Rows
            cbxMemberNumber.Items.Add(R("MemberNumber"))
        Next
        ' DISPLAY FIRS NAME FOUND
        If Access.RecordCount > 0 Then cbxMemberNumber.SelectedIndex = 0

    End Sub


    Private Sub SearchMember(MemNum As String)
        'this part will search the database for MemberNumber
        ' ADD PARAMETERS & RUN QUERY
        Access.AddParam("@MemberNumber", "%" & MemNum & "%")
        Access.ExecQuery("SELECT MemberNumber, First_Name, Last_Name, Birth_date, Gender, Registration_Year, Outstanding_fee, Title, Position " & _
                         "FROM Drivers " & _
                         "WHERE MemberNumber LIKE @MemberNumber")
        ' REPORT & ABORT ON ERRORS
        If NoErrors(True) = False Then Exit Sub


        ' FILL DATAGRIDVIEW
        dgvMembers.DataSource = Access.DBDT

    End Sub

    Private Sub DeleteMember()
        If MsgBox("sure you want to delete the seleted Driver? ", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.No Then Exit Sub

        'delete selected Driver
        Access.AddParam("@MemberNumber", txtDeleteMember.Text)
        Access.ExecQuery("DELETE FROM Drivers WHERE MemberNumber=@MemberNumber")

        ' REPORT & ABORT ON ERRORS
        If NoErrors(True) = False Then Exit Sub

        'Refresh datagridview
        txtDeleteMember.Clear()
        msiDeleteMember.Enabled = False
        RefreshGrid()

    End Sub

    Private Sub SelectedMember(MemberNumber As String)
        'query event name 
        Access.AddParam("@MemberNumber", MemberNumber)
        Access.ExecQuery("SELECT TOP 1 MemberNumber FROM Drivers WHERE MemberNumber=@MemberNumber ")

        ' REPORT & ABORT ON ERRORS if no records where found 
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        ' retrive first row found 
        Dim R As DataRow = Access.DBDT.Rows(0)

        'populate the textbox with data
        txtDeleteMember.Text = R("MemberNumber").ToString

        'enable Delete
        msiDeleteMember.Enabled = True

    End Sub





    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchMember(txtFind.Text)
    End Sub

    Private Sub dgvMembers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMembers.CellClick
        'prevante out of Index range  selection error 
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        'Select Driver MemeberNumber  from Column 1 of row clicked 
        SelectedMember(dgvMembers.Item(0, e.RowIndex).Value)
    End Sub

    Private Sub dgvMembers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMembers.CellContentClick

    End Sub

    Private Sub msUserAction_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub cbxMemberNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMemberNumber.SelectedIndexChanged
        If Not String.IsNullOrEmpty(cbxMemberNumber.Text) Then SelectedMember(cbxMemberNumber.Text)
    End Sub

    Private Sub msiDeleteMember_Click(sender As Object, e As EventArgs) Handles msiDeleteMember.Click
        DeleteMember()
    End Sub

    Private Sub msiExit_Click(sender As Object, e As EventArgs) Handles msiExit.Click
        Me.Close()
        frmDrivers.RefreshGrid()
    End Sub

    Private Sub msiAddMember_Click(sender As Object, e As EventArgs) Handles msiAddMember.Click
        Me.Close()
        frmAddDriver.Show()
    End Sub

    Private Sub msiEditMember_Click(sender As Object, e As EventArgs) Handles msiEditMember.Click
        Me.Close()
        frmUpdateMembers.Show()
    End Sub
End Class