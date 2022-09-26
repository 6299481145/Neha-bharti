package com.nehu.menubase.dspro;

import java.util.Scanner;

public class MainMenu {

    Scanner sc = new Scanner(System.in);
    int mainmenu_input;
    int submenu_input;
    boolean quit;

   // Array array = new Array(100);
   // LinkedList ll = new LinkedList();
    //Audio ad = new Audio();
    boolean press = false;

    public int print_mainmenu() {
        ad.mainmenu_audio();

        System.out.println(Color.ANSI_PURPLE + "\n**** WELCOME TO DATA STRUCTURE PROGRAM ****" + Color.ANSI_RESET);

        System.out.println(Color.ANSI_CYAN +
                "\nMAIN MENU\n 1. Array\n 2. Linked List\n 3. Stack\n 4. Queue\n 5. Tree\n 6. Graph\n 0 to Exit to MAIN MENU\n"
                + Color.ANSI_RESET);
        System.out.print(Color.ANSI_GREEN + "Enter your choice: " + Color.ANSI_RESET);
        mainmenu_input = sc.nextInt();
        press = true;
        if (press) {
            ad.stop();
        }
        return mainmenu_input;
    }

    public void main_menu() {
        print_mainmenu();
        switch (mainmenu_input) {
            case 0:
                quit = true;
                break;
            case 1:
               // array_submenu();

                break;
            case 2:
                //linkedlist_submenu();
                break;
            case 3:
                System.out.println("\nWork on construction...");
                // stack_submenu();
                break;
            case 4:
                System.out.println("\nWork on construction...");
                // queue_submenu();
                break;
            case 5:
                System.out.println("\nWork on construction...");
                // tree_submenu();
                break;
            case 6:
                System.out.println("\nWork on construction...");
                // graph_submenu();
                break;
            default:
                System.out.println(Color.ANSI_RED + "\nohhhh!! wrong input!!" +Color.ANSI_RESET);
        }
    }

    public int print_submenu() {
        ad.submenu_audio();
        System.out.println(Color.ANSI_PURPLE + "\n******** SUB MENU ********" + Color.ANSI_RESET);
        System.out.println(Color.ANSI_CYAN +
                "\n 1. Add Item\n 2. Modify Item\n 3. Delete Item\n 4. Display Item\n 0 to Exit to SUB MENU\n"
                + Color.ANSI_RESET);
        System.out.print(Color.ANSI_GREEN + "Enter your choice: " +Color.ANSI_RESET);
        submenu_input = sc.nextInt();
        if (press) {
            ad.stop();
        }
        return submenu_input;
    }

    // public void array_submenu() {
    //     while (!quit) {
    //         print_submenu();
    //         switch (submenu_input) {
    //             case 0:
    //                 main_menu();
    //                 break;
    //             case 1:
    //                 array.add_item();
    //                 break;
    //             case 2:
    //                 array.modify_item();
    //                 break;
    //             case 3:
    //                 array.delete_item();
    //                 break;
    //             case 4:
    //                 array.display_array();
    //                 break;
    //             default:
    //                 System.out.println(Color.ANSI_RED + "\nohhhh!! wrong input!!" + Color.ANSI_RESET);
    //         }

    //     }
    // }

    // public void linkedlist_submenu() {
    //     while (!quit) {
    //         print_submenu();
    //         switch (submenu_input) {
    //             case 0:
    //                 main_menu();
    //                 break;
    //             case 1:
    //                 ll.add_list();
    //                 break;
    //             case 2:
    //                 ll.modify_list();
    //                 break;
    //             case 3:
    //                 ll.delete_list();
    //                 break;
    //             case 4:
    //                 ll.print_list();
    //                 break;
    //             default:
    //                 System.out.println(Color.ANSI_RED + "\nohhhh!! wrong input!!" +Color.ANSI_RESET);
    //         }

    //     }
    // }

    public static void main(String[] args) {
        MainMenu mm = new MainMenu();
        mm.main_menu();
    }
}