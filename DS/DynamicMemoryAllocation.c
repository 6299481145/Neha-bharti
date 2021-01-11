#include<stdio.h>
#include<stdlib.h>

int main()
{
	int *p, *table;
	int size;
	
	printf("Enter table Size: ");
	scanf("%d", &size);
	
	if((table = (int*)malloc(size *sizeof(int)))== NULL)  //void pointer
	{
		printf("No space available \n");
		exit(1);
	}
	printf("Enter %d integers below: \n", size);
	
	for(p = table; p < table + size; p++)
	    scanf("%d",p);
	    
	printf("The entered integers are: \n");
	for(p=table; p<table+size;p++)
	
	printf("%d\n",*p);
	
	return 0;    
	
}
