import java.util.Scanner;
 class Timefun{

   public static void main(String[] args){
      int day, month, year;
      Scanner sc = new Scanner(System.in);
      System.out.print("Enter day: ");
      day = sc.nextInt();
      System.out.print("Enter month: ");
      month = sc.nextInt();
      System.out.print("Enter year: ");
      year = sc.nextInt();
      
      System.out.println(day + "/" + month + "/" +year);
      
   }
   
}
