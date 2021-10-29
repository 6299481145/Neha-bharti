#include<iostream>
using namespace std;

int main()
{
    long n,bit,bn=0;

    cout<<"Enter a number: ";
    cin>>n;
    while(n!=0)
    {
        bit=n%2;
        //n=n/2;
        bn=bn*10+bit;
        n=n/2;
    }
    cout<<bn <<endl;

    return 0;
}