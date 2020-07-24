'Program to add two integers
Imports System


Module Sum
    Sub Main(args As String())
        Dim a, b, c As Integer
        Console.Write("Please enter a number:")
        a = Console.ReadLine()

        Console.Write("Please enter another number:")
        b = Console.ReadLine()

        c = a + b

        Console.WriteLine("The sum is{0}.", c)
        Console.WriteLine("Program over .... press enter to exit....")
        Console.ReadKey()
    End Sub
End Module
