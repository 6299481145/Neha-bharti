#include<stdio.h>

int main()
{
    int a,b,i,GCD;

    printf("Please enter two integer values \n");
    scanf("%d %d", &a, &b);

    for(i=1;i<a && i<=b; i++)
    {
        if(a%i==0 && b%i==0)
        GCD =i;
    }

    printf("GCD of %d and %d is %d", a,b, GCD);
    return 0;
}
