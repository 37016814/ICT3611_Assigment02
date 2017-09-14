
'class Name     : MembersGenerator
'Student number : 37016814
'Module         : ICT3611 
'Description    : use randomm number class to Generate membersNumber

Imports System.Data.OleDb

Public Class MemberGenerator

   
Public Function getRandomNumber()

    'initialize random number generator
    Dim rn As New Random
    Return rn.Next(0, 999)
End Function




End Class
