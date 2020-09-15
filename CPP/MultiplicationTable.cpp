/*Program to accept a number and display its multiplication table upto 10*/

#include<iostream>

using namespace std;

int main()
{
	int n,i;
	
	cout<<"Please enter a number:";
	cin>>n;
	
	for(i=1;i<=10;i++)
	{
		cout<<n;
		cout<<" * ";
		cout.width(2);
		cout<<i;
		cout<<" = ";
		cout.width(2);
		cout<<n*i;
		cout<<endl;
	}
	return 0;
}
