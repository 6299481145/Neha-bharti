//Q5. Write a function to swap/interchange two numbers.

#include<iostream>
#include<string.h>

using namespace std;

void swap(int a, int b)
{
	a=a+b;
	b=a-b;
	a=a-b;
	
	cout<<"After the swaping"<<endl;
	cout<<"a="<<a<<"and"<<"b="<<b;
}
int main()
{
	
    int a=5,b=10;
    cout<<"Before swaping"<<endl;
	cout<<"a="<<a<<"and"<<"b="<<b<<endl;
	
	swap(a,b);
	return 0;
}
