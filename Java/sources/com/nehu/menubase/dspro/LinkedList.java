package com.nehu.menubase.dspro;

import java.util.Scanner;

public class LinkedList {

  Scanner sc = new Scanner(System.in);
  Node head;

  class Node {

    int data;
    Node next;

    Node(int data) {
      this.data = data;
      this.next = null;
    }
  }

  public void add_list() {
    System.out.print(
      Color.ANSI_YELLOW + "\nEnter your data: " + Color.ANSI_RESET
    );
    int data = sc.nextInt();
    Node newNode = new Node(data);

    if (head == null) {
      head = newNode;
      return;
    }
    Node CurrNode = head;
    while (CurrNode.next != null) {
      CurrNode = CurrNode.next;
    }
    CurrNode.next = newNode;
  }

  public void print_list() {
    if (head == null) {
      System.out.println(
        Color.ANSI_RED + "\nlist is empty..." + Color.ANSI_RESET
      );
      return;
    }
    Node CurrNode = head;
    while (CurrNode != null) {
      System.out.print(Color.ANSI_BLUE + CurrNode.data + " ->");
      CurrNode = CurrNode.next;
    }
    System.out.println("NULL" + Color.ANSI_RESET);
  }

  public void modify_list() {
    if (head == null) {
      System.out.print(
        Color.ANSI_RED + "\nlist is empty..." + Color.ANSI_RESET
      );
      return;
    }

    System.out.print(
      Color.ANSI_YELLOW + "\nEnter List index to be modify: " + Color.ANSI_RESET
    );
    int index = sc.nextInt();
    System.out.print(
      Color.ANSI_YELLOW + "\nEnter data to be modify: " + Color.ANSI_RESET
    );
    int data = sc.nextInt();
    Node ptr = new Node(data);

    Node p = head;
    int i = 0;
    try {
      while (i != index - 1) {
        p = p.next;
        i++;
      }
      ptr.data = data;
      ptr.next = p.next;
      p.next = ptr;
    } catch (NullPointerException e) {
      System.out.println(
        Color.ANSI_RED +
        "\nIndex out of bond try again later... " +
        Color.ANSI_RESET
      );
    }
  }

  public void delete_list() {
    if (head == null) {
      System.out.print(
        Color.ANSI_RED + "\nlist is empty..." + Color.ANSI_RESET
      );
      return;
    }
    System.out.print(
      Color.ANSI_YELLOW + "\nEnter your deleted data: " + Color.ANSI_RESET
    );
    int value = sc.nextInt();
    Node p = head;
    Node q = head.next;
    while (q.data != value && q.next != null) {
      p = p.next;
      q = q.next;
    }
    if (q.data == value) {
      p.next = q.next;
    }
  }
}
