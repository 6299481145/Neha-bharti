#include<iostream>
using namespace std;
 
int fibo(int n)
{
    if (n <= 1)
        return n;
    return fibo(n-1) + fibo(n-2);
}
int main()
{
    int n;

    cout<<"Enter nth place of number: ";
    cin>>n;

    cout<<"Nth Fibonacci number is "<<fibo(n)<< "."; 
    
    return 0;
}