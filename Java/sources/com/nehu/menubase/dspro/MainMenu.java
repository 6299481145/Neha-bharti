package com.nehu.menubase.dspro;

import java.util.Scanner;

public class MainMenu {

  Scanner sc = new Scanner(System.in);
  int mainmenu_input;
  int submenu_input;
  boolean quit;

  Array array = new Array(100);
  LinkedList ll = new LinkedList();
  Audio ad = new Audio();
  boolean press = false;

  public int print_mainmenu() {
    ad.mainmenu_audio();

    System.out.println(
      Color.ANSI_PURPLE +
      "\n**** WELCOME TO DATA STRUCTURE PROGRAM ****" +
      Color.ANSI_RESET
    );

    System.out.println(
      Color.ANSI_CYAN +
      "\nMAIN MENU\n 1. Array\n 2. Linked List\n 3. Stack\n 4. Queue\n 5. Tree\n 6. Graph\n 0 to Exit to MAIN MENU\n" +
      Color.ANSI_RESET
    );
    System.out.print(
      Color.ANSI_GREEN + "Enter your choice: " + Color.ANSI_RESET
    );
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
        sub_menu();
        break;
      case 2:
        sub_menu();
        break;
      case 3:
        //sub_menu();
        System.out.println(
          Color.ANSI_RED + "\nWork on construction..." + Color.ANSI_RESET
        );
        break;
      case 4:
        //sub_menu();
        System.out.println(
          Color.ANSI_RED + "\nWork on construction..." + Color.ANSI_RESET
        );
      case 5:
        // sub_menu();
        System.out.println(
          Color.ANSI_RED + "\nWork on construction..." + Color.ANSI_RESET
        );
        break;
      case 6:
        //sub_menu();
        System.out.println(
          Color.ANSI_RED + "\nWork on construction..." + Color.ANSI_RESET
        );
        break;
      default:
        System.out.println(
          Color.ANSI_RED + "\nohhhh!! wrong input!!" + Color.ANSI_RESET
        );
    }
  }

  public int print_submenu() {
    ad.submenu_audio();
    System.out.println(
      Color.ANSI_PURPLE + "\n******** SUB MENU ********" + Color.ANSI_RESET
    );
    System.out.println(
      Color.ANSI_CYAN +
      "\n 1. Add Item\n 2. Modify Item\n 3. Delete Item\n 4. Display Item\n 0 to Exit to SUB MENU\n" +
      Color.ANSI_RESET
    );
    System.out.print(
      Color.ANSI_GREEN + "Enter your choice: " + Color.ANSI_RESET
    );
    submenu_input = sc.nextInt();
    if (press) {
      ad.stop();
    }
    return submenu_input;
  }

  public void sub_menu() {
    while (!quit) {
      print_submenu();
      switch (submenu_input) {
        case 0:
          main_menu();
          break;
        case 1:
          if (mainmenu_input == 1) {
            array.add_item();
          }
          if (mainmenu_input == 2) {
            ll.add_list();
          }
          if (mainmenu_input == 3) {
            System.out.println(
              Color.ANSI_RED + "\nWork on construction..." + Color.ANSI_RESET
            );
          }
          break;
        case 2:
          if (mainmenu_input == 1) {
            array.modify_item();
          }
          if (mainmenu_input == 2) {
            ll.modify_list();
          }
          if (mainmenu_input == 3) {
            System.out.println(
              Color.ANSI_RED + "\nWork on construction..." + Color.ANSI_RESET
            );
          }
          break;
        case 3:
          if (mainmenu_input == 1) {
            array.delete_item();
          }
          if (mainmenu_input == 2) {
            ll.delete_list();
          }
          if (mainmenu_input == 3) {
            System.out.println(
              Color.ANSI_RED + "\nWork on construction..." + Color.ANSI_RESET
            );
          }
          break;
        case 4:
          if (mainmenu_input == 1) {
            array.display_array();
          }
          if (mainmenu_input == 2) {
            ll.print_list();
          }
          if (mainmenu_input == 3) {
            System.out.println(
              Color.ANSI_RED + "\nWork on construction..." + Color.ANSI_RESET
            );
          }
          break;
        default:
          System.out.println(
            Color.ANSI_RED + "\nohhhh!! wrong input!!" + Color.ANSI_RESET
          );
      }
    }
  }

  public static void main(String[] args) {
    MainMenu mm = new MainMenu();
    mm.main_menu();
  }
}
