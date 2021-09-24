Imports System
Module Addition
    sub Main()

        Dim a, b, c As Integer

        console.write("please enter a number: ")
        a = console.ReadLine()

        console.write("please enter another number: ")
        b = console.ReadLine()

        c = a + b

        MessageBox.show("The sum of " & a & " and " & b & " is " & c & ".")
    End sub
End Module    
    