'Program to add two integers using sub-procedure (Cat2)

Module Cat2
	Sub Main()
		Dim a, b As Integer
		Console.Write("Please enter a number: ")
		a = Console.ReadLine()
		Console.Write("Please enter another number: ")
		b = Console.ReadLine()
		Add(a,b)
	End Sub

	Sub Add(ByVal x as Integer, ByVal y as Integer)
		Dim z As Integer
		z = x + y
		Console.WriteLine("The sum is " & z & ".")
	End Sub
End Module