import java.lang.*;           //importing all the classes from lang package
import java.util.Scanner;

class Fibonacci{
   static int  Fibo(int n)
    {
        int a=0,b=1,c;
        if(n>0)
        {
            c = a + b;
            a=b;
            b=c;
            System.out.print(" " + c + " " );
            int fn=Fibo(n-1)+Fibo(n-2);
            return fn;
        }
        else
        {
            return 0;
        }
    }
  

    public class FiboRecursion{
    
    public  void main (String[] args)
   {
     //Fibonacci F = new Fibonacci();
     //F.Fibo();
     int n;

    Scanner sc = new Scanner(System.in);
	
	    System.out.print("Enter the number of elements: ");
	    n = sc.nextInt();

        //System.out.print("Fibonacci Series: ");
       // System.out.print( 0 + " " + 1  );
        for (int i = 1; i <= 10; i++)
            System.out.print(Fibo(i) + " ");
        //System.out.println();
        //F.Fibo(n-2);
  
    }
  }
}