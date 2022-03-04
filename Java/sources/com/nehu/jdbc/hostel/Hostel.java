package com.nehu.jdbc.hostel;
import java.util.Scanner;

public class Hostel{
    static void mainMenu() {
        int ch;
        Scanner scan = new Scanner(System.in);
        while (true) {
            System.out.println("MAIN MENU");
            System.out.println("1. New Room");
            System.out.print("Enter choice (0 to exit): ");
            ch = scan.nextInt();
            switch (ch) {
                case 0:
                    System.exit(0);
                    break;
                case 1:
                    new Room(). newRoom();
                    break;
                default:
                    System.out.println("\nInvalid Option\n");
            }
        }
    }

    public static void main(String[] args) {
        mainMenu();
    }
    
}