#include<stdio.h>

int main()
{
    char str[30],i;
    printf("Enter a Strig: ");
    scanf("%s",str);

    for(i=0; str[i]!='\0'; i++)
    {
        if(str[i] >= 'A' && str[i] <= 'Z')
        {
            str[i] = str[i] + 32;
        }
    }
    printf("\nString in Upper Case: %s", str);

    return 0;
}