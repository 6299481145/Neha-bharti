#include<iostream>

using namespace std;
int main()
{
	int p,r,t,si;
	
	cout<<"Please enter principal:";
	cin>>p;
	
	cout<<"Please enter rate:";
	cin>>r;
	
	cout<<"Please enter time:";
	cin>>t;
	
	si=(p*r*t)/100;
	
	cout<<"The Simple Interest="<<si;
	return 0;
}
