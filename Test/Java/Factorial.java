//program to find factorial of a given number using for loop.

import java.lang.*;           //importing all the classes from lang package
import java.util.Scanner;     //importing only Scanner class from util package

public class Factorial {
    public static void main (String[] args){
	    int n, fact=1;
	
	    Scanner sc = new Scanner(System.in);
	
	    System.out.print("Enter a number: ");
	    n = sc.nextInt();

        for(int i=1;i<=n;i++){    
            fact=fact*i;    
        }  
        
        System.out.println("The factorial of  " + n + " is " + fact + ".");
	
	}
}
