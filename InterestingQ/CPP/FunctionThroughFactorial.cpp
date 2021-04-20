//Q6.Write a function to find the factorial of a number.
#include<iostream>
#include<string.h>
using namespace std;

int factorial(int n)
{
	cout<<"Given no. is "<<n<<endl;
	
	int fact=1;
	for(int i=1;i<=n;i++)
	{
		fact=i*fact;
	}
	return fact;
}
int main()
{
	int fact;
	fact=factorial(5);
	cout<<"The factorial is "<<fact;
	return 0;
}
