#include<iostream>

using namespace std;
int main()
{
   
   int a,b,c;

   int *p=&a, *q=&b, *r=&c;
   cout<<"Please enter two number below :"<<endl;
   cin>>p>>q;

   

   *r = *p+*q;

   cout<<"The sum is ",*r;
}
