#include<iostream>

using namespace std;
int main()   
{
	int yr; 
	cout<<"Please enter a year:";
	cin>>yr;
	
	if(yr%400==0)
	{
	 cout<<"leap Year";
	}
	else
	{
	 cout<<"Common Year";
	}
	return 0;
}
