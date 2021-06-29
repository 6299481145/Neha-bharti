#include<iostream>
using namespace std;
int Fibonacci(int n)
{
   static int a=0,b=1,c;

    if(n>0)
    {
        c = a + b;
        a = b;
        b = c;
        cout<<c<<" ";
        return Fibonacci(n-1);
    }
}
int main()
{
    int n;

    cout<<"Enter the number of elements: ";
    cin>>n;

    cout<<"Fibonacci Series: ";    
    cout<< 0 <<" "<< 1 <<" "; 
    
    Fibonacci(n-2);
    
    return 0;

}