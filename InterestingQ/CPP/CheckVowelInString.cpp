//Q2.WAP to accept a string and find the number of vowels in it
#include<iostream>
#include<string.h>
using namespace std;
int main()
{
	int c=0;
	
	string str;
	cout<<"Enter your name:"<<endl;
	getline(cin,str);
//	cout<<str<<endl;
	
	for(int i=0;i<=str.size();i++)
	{
		if(str[i]=='a'||str[i]=='e'||str[i]=='i'||str[i]=='o'||str[i]=='u')
		{
			c++;
		}
	}
	cout<<"Total no. of vowel"<<endl;
	cout<< "In this string: ";
	cout<<c;
	return 0;
}
