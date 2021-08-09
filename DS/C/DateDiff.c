#include <stdio.h>

int main()
{
    int d1, m1, y1, d2, m2, y2, dd, mm, yy;

    printf("Enter the first date(yyyy/mm/dd): ");
    scanf("%d/%d/%d", &y1, &m1,&d1);

    printf("Enter the second date(yyyy/mm/dd): ");
    scanf("%d/%d/%d", &y2, &m2,&d2);

    if(d2<d1)
    {
        d2+=30;
        dd=d2-d1;
        m2--;
    }
    else
    {
        dd= d2-d1;
    }

    if(m2<m1)
    {
        m2+=12;
        mm=m2-m1;
        y2--;
    }
    else
    {
        mm=m2-m1;
    }
    yy= y2-y1;

    printf("The difference is %d years, %d months, %d days.\n", yy,mm,dd);
    return 0;
}