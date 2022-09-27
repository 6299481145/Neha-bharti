package com.nehu.menubase.dspro;

import java.util.Scanner;

public class Array {

  int total_size;
  int used_size;
  int[] array;
  Color c = new Color();
  Scanner sc = new Scanner(System.in);

  Array(int t_size) {
    total_size = t_size;
    array = new int[t_size];
  }

  void set_size() {
    System.out.print(
      Color.ANSI_YELLOW + "\nEnter the size of Array: " + Color.ANSI_RESET
    );
    used_size = sc.nextInt();
  }

  void add_item() {
    set_size();
    System.out.print(
      Color.ANSI_YELLOW + "\nEnter your element: " + Color.ANSI_RESET
    );

    for (int i = 0; i < used_size; i++) {
      array[i] = sc.nextInt();
    }

    System.out.println(
      Color.ANSI_BLUE + "\nAdd element successfully!!" + Color.ANSI_RESET
    );
  }

  void display_array() {
    System.out.println(
      Color.ANSI_BLUE + "\nYour array is \n" + Color.ANSI_RESET
    );
    for (int i = 0; i < used_size; i++) {
      System.out.print(array[i] + " ");
    }
    System.out.println("\n");
  }

  int modify_item() {
    if (used_size >= total_size) {
      return -1;
    }
    System.out.print(
      Color.ANSI_YELLOW +
      "\nEnter array index to be modify: " +
      Color.ANSI_RESET
    );
    int index = sc.nextInt();

    System.out.print(
      Color.ANSI_YELLOW + "\nEnter element to be modify: " + Color.ANSI_RESET
    );
    int element = sc.nextInt();

    for (int i = used_size - 1; i >= index; i--) {
      array[i + 1] = array[i];
    }
    array[index] = element;
    used_size += 1;

    System.out.println(
      Color.ANSI_BLUE + "\nModify element successfully!!" + Color.ANSI_RESET
    );
    return 1;
  }

  public void delete_item() {
    System.out.print(
      Color.ANSI_YELLOW + "\nEnter the index to be delete: " + Color.ANSI_RESET
    );
    int index = sc.nextInt();

    for (int i = index; i < used_size; i++) {
      array[i] = array[i + 1];
    }

    used_size -= 1;
    System.out.println(
      Color.ANSI_BLUE + "\nDelete element successfully!!" + Color.ANSI_RESET
    );
  }
}
