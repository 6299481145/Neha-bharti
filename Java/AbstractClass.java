import java.util.Scanner;
abstract class shape {
   public final float PI = 3.14F; 
   public abstract void input();
   public abstract float area();
}

class Circle extends shape {
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

class Rectangle extends shape {
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

class Triangle extends shape{
    private int b, h;

    public void input(){
        Scanner sc = new Scanner(System.in);
        System.out.print("\nEnter base: ");
        b =sc.nextInt();

        System.out.print("Enter height: ");
        h =sc.nextInt();
        //sc.close();

    }
    public float area(){
        return (b * h)/2;
    }

} 

class AbstractClass{
public static void main(String [] args){
    shape c = new Circle();
    c.input();
    System.out.println("The area of circle is " + c.area());

    shape R = new Rectangle();
    R.input();
    System.out.println("The area of rectangle is " + R.area());
    
    shape T = new Triangle();
    T.input();
    System.out.println("The area of rectangle is " + T.area());
  }
}

