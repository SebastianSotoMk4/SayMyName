'Sebastian Soto
'RCET0265
'Fall 2021
'Say My Name
'https://github.com/SebastianSotoMk4/SayMyName.git
Option Strict On
Option Explicit On
Module SayMyName
    Sub Main()
        Dim userName As String 
        Dim variable As Boolean

        Console.WriteLine("Oh hello , I did'nt see you there. What is your name?") 'Ask a question with console
        userName = Console.ReadLine() 'set variable to the users input

        If userName = "Sebastian" Or userName = "sebastian" Then 'If the name is recognized 
            Console.WriteLine("Hey there, freshman!")            'then a message will be displayed
            variable = True
        ElseIf userName = "Emily" Or userName = "emily" Then     'Also names can be entered uppper or lowercase.
            Console.WriteLine("Put that cookie down!")
            variable = True
        ElseIf userName = "Joe" Or userName = "joe" Then
            Console.WriteLine("...This call may be recorded for training purposes.")
            variable = True
        End If
        If variable = False Then                                'If an unrecognized name is entered
            Console.WriteLine("Name not reconized.")            'a message will be displayed.
        End If
        'ReadLine to view reply
        Console.ReadLine()
    End Sub
End Module
