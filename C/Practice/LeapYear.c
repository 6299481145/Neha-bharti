#include<stdio.h>

int main()
{
    int n;

    printf("Enter a number: ");
    scanf("%d", &n);

    if(n%4==0  && n% 400==0 || n%100!=0)
    {
        printf("Leap year");
    }
    else
    {
        printf("Normal year");
    }
    return 0;
}
