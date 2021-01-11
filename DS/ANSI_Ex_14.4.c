/*
	ANSI C - Exercise/Program - 14.4
*/

#include<stdio.h>
#include<stdlib.h>

//#define NULL 0	//already defined in stdio.h file

struct linked_list		//Self-referential structure
{
	int number;					//data part
	
	struct linked_list *next;	//link part
};

typedef struct linked_list node;	/*node type defined*/

int main()
{
	node *head;
	void create(node *p);		//declaration/prototype
	void print(node *p);
	int count(node *p);
	
	head = (node *)malloc(sizeof(node));
	create(head);
	
	printf("\n");
	
	printf("The items in the list are:\n");
	print(head);
	
	printf("\nNumber of items = %d\n", count(head));
	
	return 0;
}

void create(node *list)
{
	printf("Input a number\n");
	printf("(type -999 at end): ");
	scanf("%d", &list->number); /* create current node */
	
	if(list->number == -999)
	{
		list->next = NULL;
	}
	else /* create next node */
	{
		list->next = (node *)malloc(sizeof(node));
		create(list->next); /*Recursion Occurs*/
	}
}

//void print(node *list)
//{
//	if(list->next != NULL)
//	{
//		printf("%d-->", list->number); /* printf current item */
		
//		if(list->next->next == NULL)
//		{
//			printf("%d", list->next->number);
//		}
		
//		print(list->next);	/* move to next item */	//recursion
//	}
//}

void print(node *list)
{
	if(list->next != NULL)
	{
		printf("%d\n", list->number); /* printf current item */
		
		print(list->next);	/* move to next item */	//recursion
	}
}

int count(node *list)
{
	if(list->next == NULL)
		return(0);
	else
		return(1 + count(list->next));
}
