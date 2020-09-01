#include<stdio.h>

main()
{
	int counter;
	
	printf("Even numbers between 1 To 100 are:\n");
	
	counter=2;
	
	while(counter<=100)
	{
		printf("%d,",counter);
		
		counter=counter+2;
	}

		return 0;
}
