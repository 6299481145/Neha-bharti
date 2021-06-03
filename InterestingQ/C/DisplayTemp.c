#include<stdio.h>

int main()
{
    int cityDay[4][4];
    int i, j, max, min, m, n;
    m=n=1;
    printf("\n");
    for(i=0; i<4; i++)
    {
        for(j=0; j<4; j++)
        scanf("%d",&cityDay[i][j]);
    }
    max=cityDay[0][0];
    for(i=0; i<4; i++)
    {
        for(j=0; j<4; j++)
        {
            if(max<cityDay[i][j])
            {
                max=cityDay[i][j];
                m=j+1;
                n=i+1;
            }
        }
    }
    printf("\nThe highest temprature %d in City no %d on the day %d", max,m,n);
    min=cityDay[0][0];
    m=n=1;
    for(i=0; i<4; i++)
    {
        for(j=0; j<4; j++)
        {
            if(min>cityDay[i][j])
            {
                min=cityDay[i][j];
                m=j+1;
                n=i+1;
            }
        }
    }
    printf("\nThe lowest temprature %d in city no %d on the day %d", min,m,n);
    return 0;
}
