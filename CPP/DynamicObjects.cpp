#include<iostream>

using namespace std;

class A
{
   private:
        int a;

   public:
        A()
        {
            a=10;
        } 
    void displayA()
    {
         cout<<"a="<<a<<endl;
    }        

};

int main()
{
    //A obA;              //statically or compile time
    A *obA= new A();     //Dynamically or run time using pointer to object

    obA->displayA();

    return 0;
}
