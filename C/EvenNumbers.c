#include<stdio.h>
main()
{
	int counter;
	printf("Even numbers between 1 to 100");
	
	for(counter=1;counter>=100;counter++)
	{
		if(counter%2==0)
		{
			printf("%d,counter");
		}
		
	}
	return 0;
}
