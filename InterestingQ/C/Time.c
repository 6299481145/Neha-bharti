#include<stdio.h>

struct Time 
{
    int hour;
    int minute;
    int second;
};
main()
{
    struct Time t;
    /*printf("Enter hour: ");
    scanf("%d", t.hour);
    printf("Enter minute: ");
    scanf("%d", t.minute);
    printf("Enter second: ");
    scanf("%d", t.second);
    */
    t.hour=12;
    t.minute=30;
    t.second=23;

    printf("The time is %d:%d:%d", t.hour,t.minute,t.second);
    return 0;
}