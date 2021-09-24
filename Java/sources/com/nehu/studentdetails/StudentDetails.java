package com.nehu.studentdetails;
import java.util.Scanner;
public class StudentDetails{
    public static void main(String[] args){
        int rollno, contactno;
        String name, gender,email;
       
        Scanner sc= new Scanner(System.in);
        System.out.print("Enter roll no: ");
        rollno=sc.nextInt();
        System.out.print("Enter name: ");
        name= sc.next();
        System.out.print("Enter gender: ");
        gender= sc.next();
        System.out.print("Enter contact no: ");
        contactno=sc.nextInt();
        System.out.print("Enter email: ");
        email= sc.next();

        System.out.println("Roll No: " +rollno);
        System.out.println("Name: " +name);
        System.out.println("Gender: " +gender);
        System.out.println("Contact No: " +contact);
        System.out.println("email: " +email);
        sc.close();