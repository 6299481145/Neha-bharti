#include<iostream>

using namespace std;

int factorial(int);

int main()
{
	int no,fact;
	
	cout<<"Please enter a number:";
	cin>>no;
	
	fact = factorial(no);
	
	cout<<"The factorial of "<<no<<" is "<< fact<<"."<<endl;
	
	return 0;
}

int factorial(int n)
{
	int f=1;
	for(int i=1; i<=n; i++ )
	{
		f= f * i;
	}
	return f;
}
