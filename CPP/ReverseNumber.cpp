#include<iostream>

using namespace std;
int main()
{
	int n,r=0;
	cout<<"Please enter number:";
	cin>>n;
	
	while(r!=0)
	{
     r=n% 10;
     n=r/10;
    }
	cout<<"The reverse is:"<<r;
	return 0;
}
