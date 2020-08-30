Imports System

Module Factorial
    Sub Main(args As String())
        Dim n, i, f As Integer

        f = 1

        Console.WriteLine("Please enter a number:")
        n = Console.ReadLine()

        For i = n To 1 Step -1
            f = f * i
        Next
        Console.WriteLine("The factorial of " & n & " is " & f & ".")
    End Sub
End Module
