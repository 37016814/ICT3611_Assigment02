'class Name     : addDriver 
'Student number : 37016814
'Module         : ICT3611 
'Description    : this part of the project Add Driver to the database 


Public Class frmAddDriver

    Private Access As New DataLayer.DbAControl
    Private Member As New BusinessLayer.MemberGenerator


    Private Sub AddDriver_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        generateMemberNumber()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub DateTimePicker_ValueChanged(sender As Object, e As EventArgs) _
     Handles dtpBirthdate.ValueChanged, dtpRagDate.ValueChanged
        Me.Text = dtpBirthdate.Value.ToString
        Me.Text = dtpRagDate.Value.ToString
        generateMemberNumber()
        txtMemNumber.Text = generateMemberNumber()
    End Sub


    Private Sub textbox_Validate(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged, txtLastName.TextChanged, txtMemNumber.TextChanged, txtOutstandingFee.TextChanged, cbxGender.TextChanged
        If Not String.IsNullOrWhiteSpace(txtFirstName.Text) AndAlso Not String.IsNullOrWhiteSpace(txtLastName.Text) Then btnSave.Enabled = True

    End Sub

    Private Sub AddDriver()
        'Add Parameters

        Access.AddParam("@MemNumber", txtMemNumber.Text)
        Access.AddParam("@FirstName", txtFirstName.Text)
        Access.AddParam("@LastName", txtLastName.Text)
        Access.AddParam("@Date", dtpBirthdate.Value.ToShortDateString)
        Access.AddParam("@Gender", cbxGender.Text)
        Access.AddParam("@RegYear", dtpRagDate.Value.ToShortDateString)
        Access.AddParam("@Outstanding", txtOutstandingFee.Text)


        ' insert command 

        Access.ExecQuery("INSERT INTO Drivers (MemberNumber,First_Name,Last_Name, [Birth_Date],Gender,Registration_Year,Outstanding_fee) " & _
                          "VALUES (@MemNumber,@FirstName,@LastName,@Date,@Gender,@RegYear,@Outstanding); ")

        'REPORT & Abort on Errors

        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        'if sucesseful 
        MsgBox(" Driver added to the Database Successfully.")
        frmDrivers.RefreshGrid()
        Me.Close()



    End Sub

    Private Function generateMemberNumber() As String
        Dim Rn = Member.getRandomNumber()
        Dim regYear As String = dtpRagDate.Value.ToString("yy")
        Dim dob As String = dtpBirthdate.Value.ToString("yyyyMMdd")


        Dim uniqueID As String = CStr(regYear & dob & Rn)
        Dim r, sum As Integer
        While uniqueID <> 0
            r = uniqueID Mod 10
            sum += r
            uniqueID \= 10
        End While


        Dim checkDigit As Decimal = 0
        Dim reminder As Decimal = 0

        reminder = sum Mod 10
        If reminder = 0 Then
            checkDigit = 0
        Else
            checkDigit = 10 - reminder
        End If

        'Return: <last two digits of registration  year> & <date of birth> & <Random number> <checkDigit>
        Return regYear & dob & Rn & checkDigit

    End Function



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        AddDriver()
        FrmDeleteMember.Show()
        FrmDeleteMember.RefreshGrid()
        frmDrivers.RefreshGrid()
    End Sub





End Class