#include<stdio.h>
#include<stdlib.h>

typedef struct tree
{
int number;
struct tree* left;
struct tree* right;

}node;

node* create_node(int no);
void display (node* r);

int main()
{
	node* root= create_node(10);
	root-> left= create_node(20);
	root-> right= create_node(30);
	display (root);
	return 0;
}
node* create_node(int no)
{
	node* n= (node*) malloc(sizeof (node));
	n->number =no;
	n->left=NULL;
	n->right=NULL;
	return n;
}
void display(node*r)
{
	printf("%d\n",r->number);
	printf("/  \\ \n");
	printf("%d\t %d\n", r->left->number, r->right->number);
}
