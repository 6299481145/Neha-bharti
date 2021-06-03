#include<stdio.h>

void matrix(int a[3][3],int b[3][3],int c[3][3])
{
    int i,j;
    printf("Enter the first matrix");
    for(i=1; i<3; i++)
    {
        for(j=1; j<3; j++)
        {
            printf("%d\n",i,j);
            scanf("%d",&a[i][j]);
        }
    }
    printf("Enter the second matrix");
    for(i=1; i<3; i++)
    {
        for(j=1; j<3; j++)
        {
            printf("%d\n",i,j);
            scanf("%d",&b[i][j]);
        }
    }
    for(i=1; i<3; i++)
    {
        for(j=1; j<3; j++)
        {
            c[i][j]=a[i][j]+b[i][j];
        }
    }
    for(i=1; i<3; i++)
    {
        for(j=1; j<3; j++)
        {
            printf("%d\n",c[i][j]);
        }
    }

};
int main()
{
    int a[3][3],b[3][3],c[3][3];
    matrix(a,b,c);
    return 0;
}