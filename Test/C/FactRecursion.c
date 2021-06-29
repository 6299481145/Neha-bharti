//Factorial program using recursion 

#include<stdio.h>

factorial(int n)
{
    int fact;
    if(n==1)
        return 1;
    else
    fact= n*factorial(n-1);
    return(fact);
       
}
int main()
{
   int n;
  
   printf("Enter a number: ");
   scanf("%d",&n);

   printf("Factorial of %d is %d.", n, factorial(n));
   return 0;
}