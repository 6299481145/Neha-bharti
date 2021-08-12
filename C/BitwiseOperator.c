#include<stdio.h>
int main()
{
    char a=65;
    char b= 65;
    char c= 7;
    char d= 3;
    printf("Result obtained after right shift on a: %d\n", a>>1);
    printf("Result obtained after left shift on b: %d\n", b<<1);
    printf("Result of c | d is %d\n", c| d);
    printf("Result of c & d is %d\n", c& d);
    printf("Result of c ^ d is %d\n", c^ d);
    printf("Result of ~c  is %d\n", ~c);

    return 0;
}
