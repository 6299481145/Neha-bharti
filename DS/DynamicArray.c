#include<stdio.h>
#include<stdlib.h>
int main()
{
    int n, *arr,i;
    printf("Enter the size of array: ");
    scanf("%d",&n);
    arr=malloc(n * sizeof(int));
    printf("\nEnter %d elements below:\n",n);
    for( i=0; i<n; i++)
    {
        scanf("%d",&arr[i]);
    }
    
    printf("\nThe array elements are as follows:\n");
    for( i=0;i<n; i++)
     {
        printf("%d\n", arr[i]);
    }
    int on = n;
    printf("Enter new size for the array: ");
    scanf("%d", &n);

    //free(arr);

    arr = realloc(arr, n * sizeof(n));


    for( i=on; i<n; i++)
    {
        scanf("%d", &arr[i]);
    }

    printf("\nThe array elements are as follows:\n");
    for( i=on; i<n; i++)
    {
        printf("%d\n", arr[i]);
    }

    printf("\nThe array elements are as follows:\n");
    for( i=0; i<n; i++)
    {
        printf("%d\n", arr[i]);
    }

    return 0;

}
