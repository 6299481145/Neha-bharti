//Q1.WAP to accept a string and find the number of 'a' in it.
#include<iostream>

using namespace std;
int main()
{
	int c=0;
	string str;
	cout<<"Enter your name: ";
	getline(cin,str);
	
	cout<<str<<endl;
	
	for(int i=0;i<=str.size();i++)
	{
		if(str[i]=='a')
		{
			c++;
		}
	}
	cout<<"Total number of a in your name is: ";
	cout<<c;
	return 0;
}
