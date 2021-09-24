#include<iostream>
#include<string>
using namespace std;

void reverse(string str)
{
    cout<<"Reverse character is ";

    for(int i=str.length()-1; i>=0; i--)
    {
        cout<<str[i];
    }
}
int main()
{
    char name[20];
    char *p = name;

    cout<<"Enter your character: ";
   // getline(cin, name);
   cin>>*p;

    reverse(name);
    return 0;
}