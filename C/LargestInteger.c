//Program to find largest integer using ternary operator

#include<stdio.h>

int main()
{
	int a=5,b=10,c=15,d=20, e=30,largest;
	
	largest=(a>b && a>c && a>d && a>e) ?
	                        a:
	                          ((b>c && c>d && d>e) ?
							               c:
										   (d>e? d:e));
	
	
	printf("Largest number among %d,%d,%d,%d and %d is %d.",a,b,c,d,e,largest);
	
	return 0;
										    
}
