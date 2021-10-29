#include<stdio.h>

int main()
{
    int n, temp, r, sum=0;

    printf("Enter a number: ");
    scanf("%d", &n);

    temp=n;

    while(n>0)
    {
      r=n%10;
      sum=sum+(r*r*r*r);
      n=n/10;
     //printf("Sum=%d", sum);
   }

   if(temp==sum)
   {
     printf("Armstrong number");
   }
   else
   {
     printf("Not armstrong number ");
   }
  return 0;

}