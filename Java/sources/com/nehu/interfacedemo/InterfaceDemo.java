import java.util.Scanner;

interface Shape {
    float PI = 3.14F;

    void input();

    float area();
}

class Circle implements Shape {
    private float rad;
    public float test = 32.0F;

    public void input() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter radius: ");
        rad = sc.nextFloat();
        //sc.close();
    }

    public float area() {
        return PI * rad * rad;
    }
}

class Rectangle implements Shape {
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

class Triangle implements Shape {
    float a, b, c, s;

    public void input() {
        Scanner sc = new Scanner(System.in);
        System.out.print("\nEnter the value of a: ");
        a = sc.nextFloat();
        System.out.print("Enter the value of b: ");
        b = sc.nextFloat();
        System.out.print("Enter the value of c: ");
        c = sc.nextFloat();
        sc.close();
    }

    public float area() {
        s = (a + b + c)/2;
        return (float) Math.sqrt(s * ((s-a) * (s-b) * (s-c)));
    }
}

class InterfaceDemo {
    public static void main(String[] args) {
        Shape s = new Circle();
        s.input();
        System.out.println("The area of circle is " + s.area());

        s = new Rectangle();
        s.input();
        System.out.println("The area of Rectangle is " + s.area());

        s = new Triangle();
        s.input();
        System.out.printf("The area of triangle is %f ", s.area());
    }
}