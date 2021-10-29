#include<iostream>

using namespace std;

int main()
{
    int M,P,C,T;

    cout<<"Enter Marks of Math:";
    cin>>M;

    cout<<"Enter Marks of physics:";
    cin>>P;

    cout<<"Enter Marks of chemistry:";
    cin>>C;
     T=M+P+C;
     //Marks=M+P;
    if(M>=60 && P>=50 && C>=40 || T>=200)
    {
        printf("Eligible");
    }
    else if(M+P>=150)
    {
        printf("Eligible");
    }
    else
    {
        printf("Not Eligible");
    }
    return 0;
}