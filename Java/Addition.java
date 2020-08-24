//Program to add two integers

import java.lang.*;
import java.util.Scanner;

public class Addition {
	
	public static void main(String[] args) {
		int a,b,c;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Please enter first number:");
		a = sc.nextInt();
		
		System.out.print("Please enter second number:");
		b = sc.nextInt();
		
		c = a + b;
		
		System.out.println("The sum is "  + c + "." );
	}
	
}