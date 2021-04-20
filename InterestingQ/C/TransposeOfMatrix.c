#include<stdio.h>

main()
{
	int arr[3][3],i,j;
	
	printf("Enter a 3 x 3 matrix:\n");
	for(i=0;i<3;i++)
	{
		for(j=0;j<3;j++)
		{
			
			scanf("%d",&arr[i][j]);
		}
	}
	printf("Transpose of matrix is:\n");
	
	for(i=0;i<3;i++)
	{
		for(j=0;j<3;j++)
		{
			printf("%d ",arr[j][i]);
		}
		printf("\n");
	}
	return 0;
}
