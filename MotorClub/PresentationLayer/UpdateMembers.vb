'class Name     : DatabaseConnector
'Student number : 37016814
'Module         : ICT3611 
'Description    : handles motor club Update drivers database 


Public Class frmUpdateMembers

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

    Private Sub GetMembers()

        Access.ExecQuery("SELECT * FROM Drivers")

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
        txtMemberNumber.Text = r("MemberNumber").ToString
        txtFirstName.Text = r("First_Name").ToString
        txtLastName.Text = r("Last_Name").ToString
        dtpBirthdate.Text = r("Birth_date").ToString
        cbxGender.Text = r("Gender").ToString
        dtpRegDate.Text = r("Registration_Year").ToString
        txtOutstandingFee.Text = r("Outstanding_fee").ToString


    End Sub


    Private Sub NextRecord(Addval As Integer)
        CurrentRecord += Addval ' advance to position by addval
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0 'loop to first record 
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1

        'update edit form
        GetRecord()

    End Sub

    Private Sub UpdateRecords()

        'fail if no membership number is available
        If String.IsNullOrEmpty(txtMemberNumber.Text) Then Exit Sub

        'add parameters

        Access.AddParam("@FirstName", txtFirstName.Text)
        Access.AddParam("@LastName", txtLastName.Text)
        Access.AddParam("@Birthdate", dtpBirthdate.Value.ToShortDateString)
        Access.AddParam("@Gender", cbxGender.Text)
        Access.AddParam("@RegYear", dtpRegDate.Value.ToShortDateString)
        Access.AddParam("@Outstanding", txtOutstandingFee.Text)
        Access.AddParam("@MemberNumber", txtMemberNumber.Text)

        'execute query 
        Access.ExecQuery("UPDATE Drivers " &
                         "SET First_Name=@FirstName,Last_Name=@LastName,[Birth_date]=@Birthdate,Gender=@Gender,Registration_Year=@RegYear,Outstanding_Fee=@Outstanding " & _
                         "WHERE MemberNumber=@MemberNumber")

        If NoErrors(True) = False Then Exit Sub

        'if sucesseful 
        MsgBox(" Members Database  record Updated  Successfully.")
        Me.Refresh()


        'refresh the form 
        GetMembers()


    End Sub


    Private Sub UpdateMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpdateMembers_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        GetMembers()
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
    End Sub

    Private Sub txtMemberNumber_TextChanged(sender As Object, e As EventArgs) Handles txtMemberNumber.TextChanged

    End Sub
End Class