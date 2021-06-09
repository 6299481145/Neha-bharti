//Q7. Write a function to display multiplication table of a number.
#include<iostream>
using namespace std;

void multiplication (int n)
{
	int mul;
	for(int i=1;i<=10;i++)
	{
		mul=i*n;
		cout<<mul<<endl;
	}
}
int main()
{
	multiplication(6);
	return 0;
}
