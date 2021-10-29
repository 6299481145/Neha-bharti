#include<iostream>

using namespace std;

int main()
{
    int n, rev=0,r;

    cout<<"Enter a number: ";
    cin>>n;

    while(n>0)
    {
        r=n%10;
        rev=rev*10+r;
        n=n/10;
    }

    printf("Reverse is %d",rev);
    return 0;
}