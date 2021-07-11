import java.util.Scanner;
public class AddFun
{
   public static void main(String[] args)
   {
      int a, b, c;
      Scanner sc = new Scanner(System.in);
      System.out.print("First number: ");
      a = sc.nextInt();
      System.out.print("Second number: ");
      b = sc.nextInt();
      c= addTwo(a, b);
      System.out.print("The Sum is " + c + ".");
      //sc.close();
   }
   public static int addTwo(int a, int b)
   {
      int c = a + b;
      return c;
   }
}
