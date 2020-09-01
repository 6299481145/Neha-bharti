#include<stdio.h>

main()
{
	int counter;
	
	printf("Even numbers between 1 To 100 are:\n");
	
	//Initialize counter with first even number 2, and increament it by 2 in every ireration
	counter=2;
	
	while(counter<=100)
	{
		printf("%d,",counter);
		//	Add 2 to current even number to get next even number
		counter=counter+2;
	}

		return 0;
}
