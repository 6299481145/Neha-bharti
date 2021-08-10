//Program for checking power of two using function
#include <stdio.h>

//function prototype for checking power of two
int PowerofTwo(int n);

int main()
{
   int n;

   printf("Enter the number: ");
   scanf("%d", &n);

   if (PowerofTwo(n) == 1)
   {
      printf("%d is a power of 2.", n);
   }
   else
   {
      printf("%d is not a power of 2.", n);
   }
   return 0;
}

//function body
int PowerofTwo(int x)
{
   //checks whether a number is zero or not
   if (x == 0)
      return 0;

   //true till x is not equal to 1
   while( x != 1)
   {
      //checks whether a number is divisible by 2
      if(x % 2 != 0)
         return 0;
         x /= 2;
   }
   return 1;
}