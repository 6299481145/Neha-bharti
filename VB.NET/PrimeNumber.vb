Rem Check wheather a number is prime or not
Module Prime
        sub main()
      
            Dim n as integer
			Dim c As integer=0
			
			console.write("Enetr a number: ")
			n= console.Readline()
			
			for i as integer = 1 to n
			
			    If (n mod i =0) Then 
                   c= c+1	
				End If   
		    Next i
			
			If (c = 2) then
			console.Writeline(n & " is a prime number.")
			Else
			console.writeline(n & " is not a prime number.")
			End If
		End Sub	
End Module			

