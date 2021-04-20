#include<stdio.h>

int main()
{
	int a,b,c;
	
	int *p=&a, *q=&b, *r=&c;
	
	printf("Please enter two number below : \n");
	scanf("%d%d",p,q);
	
	*r = *p+*q;
	
	printf("The sum is %d.\n",*r);
	
	return 0;
}