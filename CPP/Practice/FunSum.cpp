#include<iostream>

using namespace std;

int Add();

int main()
{
    Add();
    return 0;
}

int Add()
{
    int a,b,c;

    cout<<"Enter first number: ";
    cin>>a;

    cout<<"Enter second number: ";
    cin>>b;

    c=a+b;

    cout<<"sum is "<<c;
}
