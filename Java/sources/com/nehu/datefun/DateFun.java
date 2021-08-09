package com.nehu.datefun;
import java.util.Scanner;

public class DateFun{

static void show(int d, int m, int y){
   System.out.println(d+ "-" + m + "-" +y);
}

public static void main(String[] args){
    int d, m, y;
    Scanner sc = new Scanner(System.in);

    System.out.print("Enter day: ");
    d = sc.nextInt();
    
    System.out.print("Enter month: ");
    m = sc.nextInt();

    System.out.print("Enter year: ");
    y = sc.nextInt();

    show(d,m,y);

}

}