#include<iostream>

using namespace std;

int main()
{
    int n,i,f;

    cout<<"Enter a number: ";
    cin>>n;

    for(i=1;i<=n;i++)
    {
        f=f*i;
    }

    cout<<"The factorial is "<<f<<".";
    return 0;
}