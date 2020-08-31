#include<stdio.h>

int main()
{
	int counter;
	printf("Even numbers between 1 to 100 are:\n");
	
	for(counter=1;counter<=100;counter++)
	{
//	counter=2;	
		if(counter%2==0)
//	while(counter<=100)
		{
			printf("%d,",counter);
		}
       // counter= counter+2;
 	}
	return 0;
}
