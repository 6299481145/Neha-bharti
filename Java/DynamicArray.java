import java.util.*;
public class DynamicArray{

   public static void main (String[] args){
    int n, arr[];
    Scanner sc = new Scanner(System.in);
    System.out.print("Enter the size of array: ");
    n= sc.nextInt();
    arr=new int[n];

    System.out.printf("Enter %d values below:\n",n);

    for(int i=0; i<n; i++)
    {
        arr[i]=sc.nextInt();
    }
    System.out.println(" The elements of the array are: ");

    for(int i=0; i<n; i++)
    {
        System.out.println(arr[i]);
    }

    System.out.println("The sorted array is: ");
    Arrays.sort(arr);

    for(int i=0; i<n; i++)
    {
        System.out.println(arr[i]);
    }
    sc.close();
   } 
}