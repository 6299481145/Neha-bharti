/*
 Algorithm 4.1': TRAVERSING A LINEAR ARRAY
*/
# include<stdio.h>

int main()
{
	int lb=0, ub=4,k;
	int la[10]={45,3,85,96,105};
	k=lb;
	
	for (k=lb;k<=ub;k++)
	{
		printf("%d\n",la[k]);
		
	}
	la[14]=67;
	printf("%d\n",la[14]);
	return 0;
}
