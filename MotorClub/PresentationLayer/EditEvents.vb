
'class Name     : EditEvents
'Student number : 37016814
'Module         : ICT3611 
'Description    : handles the edit and update of the events database 





Public Class frmEditEvents

    Private Access As New DataLayer.DbAControl


    Private CurrentRecord As Integer = 0

    ' error reporting and checking 
    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception) 'reporting errors
            Return False
        Else
            Return True
        End If
    End Function


    Private Sub GetEvent()

        Access.ExecQuery("SELECT * FROM Event")

        'report and abort errors
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        ' Get first Record 
        GetRecord()

    End Sub

    Private Sub GetRecord()

        ' fail if record not found and position is out of range 
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        'return First User Found 
        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        'populate 
        txtEventTitle.Text = r("Title").ToString
        'txtTitle.Text = r("Title").ToString
        dtpEventDate.Text = r("Date").ToString
        txtRegfee.Text = r("Registration_fee").ToString
        txtLocation.Text = r("Location").ToString
        txtLaps.Text = r("Laps").ToString



    End Sub

    Private Sub NextRecord(Addval As Integer)
        CurrentRecord += Addval ' advance to position by addval
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0 'loop to first record 
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1

        'update edit form
        GetRecord()

    End Sub

    Private Sub UpdateRecords()

        'fail if no event Title  is available
        If String.IsNullOrEmpty(txtEventTitle.Text) Then Exit Sub

        'add parameters

        Access.AddParam("@EventDate", dtpEventDate.Value.ToShortDateString)
        Access.AddParam("@Regfee", txtRegfee.Text)
        Access.AddParam("@Location", txtLocation.Text)
        Access.AddParam("@Laps", txtLaps.Text)
        Access.AddParam("@Title", txtEventTitle.Text)
        'execute query 
        Access.ExecQuery("UPDATE Event " &
                         "SET [DATE]=@EventDate,Registration_fee=@Regfee,Location=@Location,Laps=@Laps " & _
                         "WHERE Title=@Title")

        If NoErrors(True) = False Then Exit Sub

        'if sucesseful 
        MsgBox(" Events Database  record Updated  Successfully.")
        Me.Refresh()


        'refresh the form 
        GetEvent()


    End Sub




    Private Sub frmEditEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmEditEvents_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        GetEvent()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        NextRecord(-1)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        NextRecord(+1)
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        CurrentRecord = 0
        GetRecord()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        UpdateRecords()
        frmEvents.RefreshGrid()
    End Sub
End Class