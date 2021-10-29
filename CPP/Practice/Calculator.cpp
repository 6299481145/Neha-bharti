#include<iostream>

using namespace std;

int main()
{
    int ch;
    float a, b,c;

    cout<<"Enter first number: "; 
    cin>>a;

    cout<<"Enter second number: ";
    cin>>b;
    
    cout<<"1. Addition"<<endl;
    cout<<"2. Subtraction"<<endl;
    cout<<"3. Multiplication"<<endl;
    cout<<"4. Division"<<endl;

    cout<<"Enter your choice: ";
    cin>>ch;

    switch(ch)
    {
        case 1:
            c=a+b;
            cout<<c<<endl;
            break;
        case 2:
            c=a-b;
            cout<<c<<endl;
            break;
        case 3:
            c=a*b;
            cout<<c<<endl;
            break;
        case 4:
            c=a/b;
            cout<<c<<endl;
            break;  
         exit(0);
                     

    }
}