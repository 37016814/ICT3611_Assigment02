'class Name     : AddEvent class
'Student number : 37016814
'Module         : ICT3611 
'Description    : add the Event to the Database



Public Class AddEvent

    Private Access As New DataLayer.DbAControl


    Private Sub AddEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Textbox_Validate(sender As Object, e As EventArgs) Handles txtTitle.TextChanged, txtRegfee.TextChanged, txtLocation.TextChanged, txtLaps.TextChanged
        If Not String.IsNullOrWhiteSpace(txtTitle.Text) AndAlso Not String.IsNullOrWhiteSpace(txtRegfee.Text) Then btnAdd.Enabled = True

    End Sub

    ' add New Event to the database

    Private Sub AddEvent()
        'add parameters

        Access.AddParam("@Title", txtTitle.Text)
        Access.AddParam("@Date", dtpEventDate.Value.ToShortDateString)
        Access.AddParam("@Registration_fee", txtRegfee.Text)
        Access.AddParam("@Location", txtLocation.Text)
        Access.AddParam("@Laps", txtLaps.Text)


        ' insert command 

        Access.ExecQuery("INSERT INTO Event (Title,[Date],Registration_fee,Location,Laps) " & _
        "VALUES (@Title,@Date,@Registration_fee,@Location,@Laps); ")


        'REPORT & Abort on Errors

        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        'if sucesseful 
        MsgBox("Event Added to the Database Successfully.")

        frmEvents.RefreshGrid()
        Me.Close()

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddEvent()
        frmEvents.Show()
    End Sub
End Class