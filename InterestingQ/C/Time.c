#include<stdio.h>

struct time 
{
    int hour;
    int minute;
    int second;
};
main()
{
    struct time t;
    printf("Enter hour: ");
    scanf("%d", t.hour);
    printf("Enter minute: ");
    scanf("%d", t.minute);
    printf("Enter second: ");
    scanf("%d", t.second);
    printf("The time is %d:%d:%d", t.hour);
    return 0;
}