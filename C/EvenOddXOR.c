#include<stdio.h>

int main()
{
    int n;

    printf("Enter a number: ");
    scanf("%d",&n);

    if ((n^1)==(n+1))
    {
       printf("%d is even.\n",n);
    }
    else
    {
      printf("%d is odd.\n",n);  
    }
    return 0;
    
}
