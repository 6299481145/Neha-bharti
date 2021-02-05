'Program to add two integers using sub-procedure (Cat4)

Module Cat4
	Sub Main()
		Dim x, y, z As Integer
		Console.Write("Please enter a number: ")
		x = Console.ReadLine()
		Console.Write("Please enter another number: ")
		y = Console.ReadLine()
		z = Add(x,y)
		Console.WriteLine("The sum is " & z & ".")
	End Sub

	'int add(int a, int b)
	Function Add(ByVal a as Integer, ByVal b as Integer) as Integer
		Dim c as Integer
		c = a + b
		Return c
	End Function
End Module