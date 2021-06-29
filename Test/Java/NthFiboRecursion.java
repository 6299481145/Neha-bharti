import java.lang.*;           //importing all the classes from lang package
import java.util.Scanner;

class NthFiboRecursion{
    static int fibo(int n)
    {
    if (n <= 1)
       return n;
    return fibo(n-1) + fibo(n-2);
    }
      
    public static void main (String args[])
    {
        int n;
	
	    Scanner sc = new Scanner(System.in);
	
	    System.out.print(" Enter nth place of number: ");
	    n = sc.nextInt();

        System.out.print("Nth Fibonacci number is " + fibo(n) + ".");
    }
    
}    