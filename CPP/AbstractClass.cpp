#include<iostream>
using namespace std;
#define PI 3.14
class shape
{
    public:
        //const float PI = 3.14;     //Error in java
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
     int l, b;
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
    int b, h ;
  public:
   void input()
   {
      cout<<"\nEnter base: ";
      cin>>b;

      cout<<"Enter height: ";
      cin>>h;
   }
   float area()
   {
      return  (b * h)/2;
   }
 };

 int main()
{
   shape *C = new Circle();
   C->input();
   cout<<"The area of circle is "<<C->area()<<endl;

   shape *R = new Rectangle();
   R->input();
   cout<<"The area of rectangle is "<<R->area()<<endl;

   shape *T = new Triangle();
   T->input();
   cout<<"The area of triangle is "<<T->area()<<endl;
}