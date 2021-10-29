#include<iostream>

using namespace std;

int main()
{
    int n, rev=0, r, temp=0;

    //temp=n;
    cout<<"Enter a number: ";
    cin>>n;
     
    temp=n;
    
    while(n>0)
    {
        r=n%10;
        rev=rev*10+r;
        n=n/10;
    }

    if(temp==rev)
    {
        cout<<"Palindrom";
    }
    else
    {
        cout<<"Not Palindrom";
    }
    return 0;
}
