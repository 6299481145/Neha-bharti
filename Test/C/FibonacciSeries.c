#include<stdio.h>

int main()
{
    int n,i,a=0,b=1,c;

    printf("Enter the number of elements: ");
    scanf("%d",&n);
     
     printf("Fibonacci Series: "); 
     printf("%d %d",a,b);   

    for(i=2;i<n;i++) 
    {
        c = a + b;
        a=b;
        b=c;
        printf(" %d ",c);
    }
    return 0;
}



