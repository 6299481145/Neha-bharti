#include<iostream>
#include<cmath>

using namespace std;
int main()
{
 float p,r,t,ci;
 	
 cout<<"Please enter Principal:";
 cin>>p;
 
 cout<<"Please enter rate:"; 
 cin>>r;

 cout<<"Please enter time:";
 cin>>t;

 ci=pow(p*((1+r)/100 ),t);

 cout<<"The compound interest = " <<ci;

 return 0;
}
