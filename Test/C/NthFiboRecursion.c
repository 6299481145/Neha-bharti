#include<stdio.h>

int fibo(int n)
{
    if(n<=1)
    return n;
    return fibo(n-1) + fibo(n-2);
}
int main()
{
    int n;

    printf("Enter nth place of number: ");
    scanf("%d",&n);

    printf("Nth Fibonacci number is %d.",fibo(n)); 
    
    return 0;
}

