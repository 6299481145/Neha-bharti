//import java.lang.*;           //importing all the classes from lang package
//import java.util.Scanner;


public class FibonacciRecursion{
static int Fibonacci(int n){
    
        if(n<=1)
        {
             return n;
        } 
        
        int fn = Fibonacci(n-1)+Fibonacci(n-2);
        return fn;
} 

 public static void main(String[] args){
   // int n;

    //Scanner sc = new Scanner(System.in);
	
	   // System.out.print("Enter the number of elements: ");
	    //n = sc.nextInt();

        for (int i = 1; i <= 5; i++)
            System.out.print(Fibonacci(i) + " ");
    // Fibonacci(n);
     //return 0;
 }
 
}