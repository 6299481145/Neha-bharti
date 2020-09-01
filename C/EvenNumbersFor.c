#include<stdio.h>

int main()
{
	int counter;
	printf("Even numbers between 1 to 100 are:\n");
	
	for(counter=1;counter<=100;counter++)
	{
	
		if(counter%2==0)	
	
		{
			printf("%d,",counter);
		}
 
 	}
	return 0;
}
