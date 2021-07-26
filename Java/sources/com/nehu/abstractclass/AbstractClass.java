package com.nehu.abstractclass;
import java.util.Scanner;

//import java.lang.Math;
abstract class Shape {
   public final float PI = 3.14F; 
   public abstract void input();
   public abstract float area();
}

class Circle extends Shape {
    private float rad;

    public void input(){
       Scanner sc = new Scanner(System.in); 
       System.out.print("Enter radius: ");
       rad =sc.nextFloat();
      // sc.close();
    }
    public float area(){
        return PI * rad *rad;
    }
}

class Rectangle extends Shape {
    private int l,b;

    public void input(){
        Scanner sc = new Scanner(System.in);
        System.out.print("\nEnter length: ");
        l =sc.nextInt();

        System.out.print("Enter breath: ");
        b =sc.nextInt();
        //sc.close();
    }
    public float area(){
        return l * b;
    }
   
}

class Triangle extends Shape{
    private float a, b, c, s;

    public void input(){
        Scanner sc = new Scanner(System.in);
        System.out.print("\nEnter the value of a: ");
        a =sc.nextInt();

        System.out.print("Enter the value of b: ");
        b =sc.nextInt();

        System.out.print("Enter the value of c: ");
        c =sc.nextInt(); 
        sc.close();

    }
    public float area(){

        s =(a+b+c)/2;
        return (float)Math.sqrt(s* (s-a) * (s-b) * (s-c));
    }

} 

class AbstractClass{
public static void main(String [] args){
    Shape s = new Circle();
    s.input();
    System.out.println("The area of circle is " + s.area());

    s = new Rectangle();
    s.input();
    System.out.println("The area of rectangle is " + s.area());
    
    s = new Triangle();
    s.input();
    System.out.println("The area of rectangle is " + s.area());
  }
}

