#include<iostream>

using namespace std;
int fibo(int n)
{
   int a=0, b=1, c;
   for(int i=1; i<n; i++)
   {
     c = a+b;
     a = b;
     b = c;
   }
   return a;
}

int main()
{
   int n;

   cout<<"Enter nth place of number: ";
   cin>>n;

   cout<<"Nth fibonacci number is "<<fibo(n)<<".";

   return 0;
}