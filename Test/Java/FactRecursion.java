//program to find factorial of a given number using recursion.

import java.lang.*;         //importing all the classes from lang package
import java.util.Scanner;   //importing only Scanner class from util package

class FactRecursion{
 static int factorial(int n)
{
    int fact;
    if(n==1)
        return 1;
    else
    fact= n*factorial(n-1);
    return(fact);
       
}
  public static void main(String[] args)
  {
      int n;

      Scanner sc = new Scanner(System.in);

      System.out.print("Enter a number: ");
      n = sc.nextInt();

      System.out.println("Factorial of " + n + " is " + factorial(n) + "." );
  }
}