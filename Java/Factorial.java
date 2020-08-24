//program to find factorial of a given number using function

import java.lang.*;         //importing all the classes from lang package
import java.util.Scanner;  //importing only Scanner class from util package

public class Factorial {
    public static void main (String[] args){
	    int n;
	
	    Scanner sc = new Scanner(System.in);
	
	    System.out.print("Please enter a number:");
	    n = sc.nextInt();
	
	    int f = factorial(n);
	
	    System.out.println("The factorial of  " + n + " is " + f + ".");
	
	}
	
    static int factorial (int n){
		int fact = 1;
		
		for(int i=n; i>1; i--)
		{
			fact = fact * i;
		}
            return fact;
	}
}	