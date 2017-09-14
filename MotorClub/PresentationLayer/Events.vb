Public Class frmEvents
    Private Access As New DataLayer.DbAControl


    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception) 'reporting errors
            Return False
        Else
            Return True
        End If
    End Function



    Private Sub Events_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RefreshGrid()

    End Sub

    Public Sub RefreshGrid()
        Access.ExecQuery("SELECT * FROM Event ORDER BY Title ASC")

        'report and abort errors
        If NoErrors(True) = False Then Exit Sub

        ' FILL DATAGRID
        dgvEvents.DataSource = Access.DBDT

        'clear combobox

        cbxEventTitle.Items.Clear()

        ' FILL COMBOBOX
        For Each R As DataRow In Access.DBDT.Rows
            cbxEventTitle.Items.Add(R("Title"))
        Next
        ' DISPLAY FIRS NAME FOUND
        If Access.RecordCount > 0 Then cbxEventTitle.SelectedIndex = 0

    End Sub



    Private Sub SearchEvent(Name As String)
        ' ADD PARAMETERS & RUN QUERY
        Access.AddParam("@Title", "%" & Name & "%")
        Access.ExecQuery("SELECT Title, Date, Registration_fee, Location, Laps " & _
                         "FROM Event " & _
                         "WHERE Title LIKE @Title")


        ' REPORT & ABORT ON ERRORS
        If NoErrors(True) = False Then Exit Sub

        ' FILL DATAGRIDVIEW
        dgvEvents.DataSource = Access.DBDT
    End Sub

    Private Sub DeleteEvent()
        If MsgBox("sure you want to delete the seleted Event? ", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.No Then Exit Sub

        'delete selected Event 
        Access.AddParam("@Title", txtDelEvent.Text)
        Access.ExecQuery("DELETE FROM Event WHERE Title=@Title")

        ' REPORT & ABORT ON ERRORS
        If NoErrors(True) = False Then Exit Sub

        'Refresh datagridview
        txtDelEvent.Clear()
        msiDeleteEvent.Enabled = False

        RefreshGrid()

    End Sub

    Private Sub SelecetedEvent(Title As String)
        'query event name 
        Access.AddParam("@Title", Title)
        Access.ExecQuery("SELECT TOP 1 Title FROM Event WHERE Title=@Title ")

        ' REPORT & ABORT ON ERRORS if no records where found 
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        ' retrive first row found 
        Dim R As DataRow = Access.DBDT.Rows(0)

        'populate the textbox with data
        txtDelEvent.Text = R("Title").ToString

        'enable Delete
        msiDeleteEvent.Enabled = True

    End Sub

    Private Sub Events_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchEvent(txtFind.Text)
    End Sub

    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        Me.Close()
        AddEvent.Show()
    End Sub

    Private Sub cbxEventTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEventTitle.SelectedIndexChanged
        If Not String.IsNullOrEmpty(cbxEventTitle.Text) Then SelecetedEvent(cbxEventTitle.Text)
    End Sub

    Private Sub dgvEvents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEvents.CellClick
        'prevante out of range Index selection error 
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        'Select Event  from Column 1 of row clicked 
        SelecetedEvent(dgvEvents.Item(0, e.RowIndex).Value)

    End Sub

    Private Sub msiDeleteEvent_Click(sender As Object, e As EventArgs)
        DeleteEvent()
    End Sub

    Private Sub msiDeleteEvent_Click_1(sender As Object, e As EventArgs) Handles msiDeleteEvent.Click
        DeleteEvent()
    End Sub

    Private Sub EditEventToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEventToolStripMenuItem.Click
        Me.Close()
        frmEditEvents.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()
    End Sub
End Class