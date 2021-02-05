'Program to add two integers using sub-procedure (Cat1)

Module Cat1
	Sub Main()
		Add()
	End Sub

	Sub Add()
		Dim a, b, c As Integer
		Console.Write("Please enter a number: ")
		a = Console.ReadLine()
		Console.Write("Please enter another number: ")
		b = Console.ReadLine()
		c = a + b
		Console.WriteLine("The sum is " & c & ".")
	End Sub
End Module