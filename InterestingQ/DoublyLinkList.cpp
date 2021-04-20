#include<iostream>
#include<stdlib.h>
using namespace std;

struct node
{
	int data;
	struct node *prev;
	struct node *next;

};

void traversal(struct node* ptr)
{
	while(ptr!=NULL)
    {
    	cout<<ptr->data<<endl;
    	ptr=ptr->next;
	}
}

int main ()
{
	struct node *n1;
	n1=(struct node*)malloc(sizeof(struct node));
	
	struct node *n2;
	n2=(struct node*)malloc(sizeof(struct node));
	
	struct node *n3;
	n3=(struct node*)malloc(sizeof(struct node));
	
	n1->data=3;
	n1->next=n2;
	n1->prev=NULL;
	
	n2->data=7;
	n2->next=n3;
	n2->prev=NULL;
	
	n3->data=9;
	n3->next=NULL;
	n3->prev=NULL;
	traversal(n1);
	return 0;
}
	


