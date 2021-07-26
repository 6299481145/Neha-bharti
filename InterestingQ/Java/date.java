import java.util.Scanner;

public class date {
    public static void main(String[] arg) {
        int day, month, year;
        Scanner m = new Scanner(System.in);
        System.out.print("enter the day");
        day = m.nextInt();
        System.out.print("enter the month");
        month = m.nextInt();
        System.out.print("enter the year");
        year = m.nextInt();
        System.out.println(day + "/" + month + "/" + year);
    }
}