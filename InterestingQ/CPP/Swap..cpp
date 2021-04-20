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
	cout<<"a="<<a<<"and"<<"b="<<endl;
	
	swap(a,b);
	
}
