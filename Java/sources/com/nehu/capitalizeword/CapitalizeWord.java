package com.nehu.capitalizeword;

import java.util.Scanner;

public class CapitalizeWord {

  public static void main(String[] args) {
    String sentence = "neha bharti is a geneious girl.";
    String upper_case_sentence = "";
    Scanner scanner = new Scanner(sentence);
    while (scanner.hasNext()) {
      String word = scanner.next();
      upper_case_sentence +=
        Character.toUpperCase(word.charAt(0)) + word.substring(1) + " ";
    }
    System.out.println(upper_case_sentence);
  }
}
