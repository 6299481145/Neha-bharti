#include<iostream>
#include<cmath>
using namespace std;
//#define PI 3.14
class shape
{
    public:
        const float PI = 3.14;     //Error in java
        virtual void input() = 0;   //pure virtual function
        virtual float area() = 0;

};

class Circle : public shape
{
    float rad;
   public:
       void input()
       {
            cout<<"Enter radius: ";
            cin>>rad;
       }
       float area()
       {
           return PI * rad * rad;
       }
 };

 class Rectangle : public shape
 {
    float l, b;
   public:  
     void input()
     {
        cout<<"\nEnter length: ";
        cin>>l;

        cout<<"Enter breath: ";
        cin>>b;
     }
     float area()
     {
         return l * b;
     }

 };

 class Triangle : public shape
 {
    float a, b, c, s ;
  public:
   void input()
   {
      cout<<"\nEnter the value of a: ";
      cin>>a;

      cout<<"Enter the value of b: ";
      cin>>b;

      cout<<"The the value of c: ";
      cin>>c;
   }
   float area()
   {
      s = (a+b+c)/2;
      return sqrt(s*(s-a) * (s-b) * (s-c));
   }
 };

 int main()
{
   shape *s = new Circle();
   s->input();
   cout<<"The area of circle is "<<s->area()<<endl;

   s = new Rectangle();
   s->input();
   cout<<"The area of rectangle is "<<s->area()<<endl;

   s = new Triangle();
   s->input();
   cout<<"The area of triangle is "<<s->area()<<endl;
}