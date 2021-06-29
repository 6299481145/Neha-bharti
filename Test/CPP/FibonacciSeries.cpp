#include<iostream>
using namespace std;
int main()
{
    int n,a=0,b=1,c;

    cout<<"Enter the number of elements: ";
    cin>>n;
     
     cout<<"Fibonacci Series: "; 
     cout<<a<<" "<<b<<" "; //printing 0 and 1   

    for(int i=2;i<n;i++) //loop starts from 2 because 0 and 1 are already printed
    {
        c = a + b;
        a=b;
        b=c;
        cout<<c<<" ";
    }
    return 0;
}