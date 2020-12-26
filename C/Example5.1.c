/*
	Example 5.1
*/

#include<stdio.h>
#include<string.h>

struct node
{
	int bed_no;					//4 bytes
	char patient[10];			//10 bytes
							    	
	struct node *next;		    //8 bytes (pointer)
	//pointer/link to the next node
};

int main()
{
	struct node n1, *n2;
	
	n2->bed_no = 1;
	strcpy(n2->patient, "Kirk");
	
	printf("%-5d%s\n", n2->bed_no, (*n2).patient);
	
	
	return 0;
}
