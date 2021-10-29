#include<iostream>
using namespace std;

int main()
{
    int marks ;

    cout<<"Enter marks: ";
    cin>>marks;

    if(marks>=60)
    {
        cout<<"Ist Division";
    }
    else if (marks>=50)
    {
        cout<<"2nd Division";
    }
    else if(marks>=40)
    {
        cout<<"3rd Division";
    }
    else
    {
        cout<<"Fail";
    }
    return 0;

}