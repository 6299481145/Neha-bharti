import java.lang.*;           //importing all the classes from lang package
import java.util.Scanner;

class NthFiboNum{
    static int Fibo(int n)
    {
        int a=0,b=1,c;

        for(int i=1;i<n;i++)
        {
            c = a + b;
            a=b;
            b=c;
        }
        return a;
    }  
    
    public static void main (String args[])
 {
    int n;

    Scanner sc = new Scanner(System.in);
	
	    System.out.print("Enter nth place of number : ");
	    n = sc.nextInt();

        System.out.println("Nth fibonacci number is " + Fibo(n)+ "." );
        
    }
 }