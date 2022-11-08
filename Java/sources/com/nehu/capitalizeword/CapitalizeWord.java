package com.nehu.capitalizeword;

import java.util.Scanner;

public class CapitalizeWord {

  public static void main(String[] args) {
    // String sentence = "neha bharti is a geneious girl.";
    String sentence = "";
    Scanner scanner = new Scanner("neha bharti is a geneious girl.");
    while (scanner.hasNext()) {
      String word = scanner.next();
      sentence +=
        Character.toUpperCase(word.charAt(0)) + word.substring(1) + " ";
    }
    System.out.println(sentence);
  }
}
