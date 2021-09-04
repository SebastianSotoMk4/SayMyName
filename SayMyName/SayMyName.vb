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
        Console.WriteLine("Hello, " & userName & " Have a good one")
        Console.ReadLine()
    End Sub
End Module
