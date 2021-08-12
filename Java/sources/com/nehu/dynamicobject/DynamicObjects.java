package com.nehu.dynamicobject;

class A
{
    private int a;

    public A(){
      a=10;
    }
    void displayA(){
        System.out.println("a="+a);
    }
}
class DynamicObjects{
   public static void main(String[] args) {
     // A obA;             //Statically or compile time
      A obA= new A();     //Dynamically or run time using pointer to object

      obA.displayA();
   }
}