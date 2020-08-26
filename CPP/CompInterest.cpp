#include<iostream>
#include<cmath>

using namespace std;

int main()
{
	float p,r,i,t,ci,a;
	
	cout<<"Please enter Principal:";
	cin>>p;
	cout<<"Please enter Rate:";
	cin>>r;
	cout<<"Please enter Time";
	cin>>t;
	
	i=1+(r/100);
	
	ci=1;
	for(a=1;a<=t;a++)
	ci=ci*i
	
//	ci=p*ci-p;
	
	cout<<"compound interest is"<<ci;
	cout<<"\n"
	return 0;
}
