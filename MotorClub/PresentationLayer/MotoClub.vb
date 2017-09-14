'class Name     : main form class
'Student number : 37016814
'Module         : ICT3611 
'Description    : the first landing form of the motor club project where user clicks on a button so select what he wants to do





Public Class MotoClub



    Private Sub MotoClub_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.Alt AndAlso (e.KeyCode = Keys.D)) Then
            ' When Alt + D is pressed, the Click event for the Driver
            ' button is raised.
            e.Handled = True
            btnDrivers_Click()
        End If


        If (e.Alt AndAlso (e.KeyCode = Keys.E)) Then
            ' When Alt + E is pressed, the Click event for Events
            ' button is raised.
            e.Handled = True
            btnEvents_Click()


        End If

        If (e.Alt AndAlso (e.KeyCode = Keys.R)) Then
            ' When Alt + R is pressed, the Click event for Race Results
            ' button is raised.
            e.Handled = True
            btnRaces_Click()


        End If

        If (e.Alt AndAlso (e.KeyCode = Keys.X)) Then
            ' When Alt + P is pressed, the Click event for the print
            ' button is raised.
            e.Handled = True
            btnExit_Click()


        End If


    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEvents_Click(sender As Object, e As EventArgs) Handles btnEvents.Click
        frmEvents.Show()

    End Sub

    Private Sub btnDrivers_Click(sender As Object, e As EventArgs) Handles btnDrivers.Click
        frmDrivers.Show()
    End Sub

    Private Sub btnRaces_Click(sender As Object, e As EventArgs) Handles btnRaces.Click
        FrmRaceResults.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnDrivers_Click()
        Throw New NotImplementedException
    End Sub

    Private Sub btnEvents_Click()
        Throw New NotImplementedException
    End Sub

    Private Sub btnRaces_Click()
        Throw New NotImplementedException
    End Sub

    Private Sub btnExit_Click()
        Throw New NotImplementedException
    End Sub

End Class
