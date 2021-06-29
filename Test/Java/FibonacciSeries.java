import java.lang.*;           //importing all the classes from lang package
import java.util.Scanner;

public class FibonacciSeries {
    public static void main (String[] args){
	    int n,i,a=0, b=1,c;
	
	    Scanner sc = new Scanner(System.in);
	
	    System.out.print("Enter the number of elements: ");
	    n = sc.nextInt();

        System.out.print("Fibonacci Series: ");
        System.out.print( a + " " +b );
     

        for(i=2;i<n;i++) //loop starts from 2 because 0 and 1 are already printed
      {
        c = a + b;
        a=b;
        b=c;
        System.out.print(" " + c + " " );
      }
    
  }
}
