
#include<stdio.h>
int fibo(int n)
{
   int a=0, b=1, c,i;
   for( i=1; i<n; i++)
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

   printf("Enter nth place of number: ");
   scanf("%d", &n);

   printf("Nth fibonacci number is %d.", fibo(n));

   return 0;
}