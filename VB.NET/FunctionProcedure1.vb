'Program to add two integers using sub-procedure (Cat3)

Module Cat3
	Sub Main()
		Dim c As Integer
		c = Add()
		Console.WriteLine("The sum is " & c & ".")
	End Sub

	Function Add()
		Dim x, y, z As Integer
		Console.Write("Please enter a number: ")
		x = Console.ReadLine()
		Console.Write("Please enter another number: ")
		y = Console.ReadLine()
		z = x + y
		Return z
	End Function
End Module