/*Program to accept a number and display its multipation table upto 10*/

#include<stdio.h>

int main()
{
	int n,i; 
	
	printf("Please enter a number:");
	scanf("%d",&n);
	
	for(i=1;i<=10;i++)
	{
		printf("%d * %d = %d\n", n, i, n*i);   
	}
	return 0;
}

