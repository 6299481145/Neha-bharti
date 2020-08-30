Imports System.IO

Module FirstFile
    Sub Main(args As String())
        Dim str As String
        Dim SW As New StreamWriter("FirstFile.txt") 'sw is reference to object of streamwriter class 

        '...........WRITING  CONTENT TO A FILE
        Console.WriteLine("Please type some text below:")
        str = Console.ReadLine()
        SW.WriteLine(str)
        Console.WriteLine("Entered information successfully saved in the file:FirstFile")
        SW.Close()


        '...........READING CONTENT FROM A FILE 
        Console.WriteLine("To view the content of FirstFile press enter key.....")
        Console.ReadKey()
        Dim sr As New StreamReader("FirstFile.txt")
        Console.WriteLine("FirstFile contents the following text:")
        str = sr.ReadLine()
        Console.WriteLine(str)
        sr.Close()
    End Sub
End Module
