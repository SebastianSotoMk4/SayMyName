'Sebastian Soto
'RCET0265
'Fall 2021
'Say My Name
'https://github.com/SebastianSotoMk4/SayMyName.git
Option Strict On
Option Explicit On
Module SayMyName
    Sub Main()
        'Create variable
        Dim userName As String
        'Ask a question with console
        Console.WriteLine("Oh hello , I did'nt see you there. What is your name?")
        'set variable to the users input
        userName = Console.ReadLine()
        'Reply to user with phrase and name
        If userName = "Sebastian" Then
            Console.WriteLine("Hello creator")
        ElseIf userName = "Emily" Then
            Console.WriteLine("Emily who?")
        ElseIf userName = "Joe" Then
            Console.WriteLine("Joe Sup")
        End If

        'Console.WriteLine("Hello, " & userName & " Have a good day")
        'ReadLine to view reply
        Console.ReadLine()
    End Sub
End Module
