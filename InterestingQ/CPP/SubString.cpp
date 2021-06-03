//Q4.WAP to accept a string and display a substring from it.
#include<iostream>
#include<string.h>
using namespace std;
int main()
{
	string str=("Muzaffarpur");
	string str1;
	
	cout<<"Given string is: ";
	cout<<str<<endl;
	
	str1= str.substr(8,3);
	cout<<"And substring is "<<str1;
	return 0;
}
