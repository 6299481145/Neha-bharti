#include<iostream>

using namespace std;

 int factorial(int n)
{
    int fact;
    if(n==1)
        return 1;
    else
    fact= n*factorial(n-1);
    return(fact);
       
}
int main()
{
    int n;

    cout<<"Enter a number: ";
    cin>>n;

    cout<<"factorial of "<<n<< " is " <<factorial(n)<<".";
    return 0;
}