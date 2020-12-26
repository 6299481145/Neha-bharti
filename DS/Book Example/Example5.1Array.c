/*
	Example 5.1 Array
*/

#include<stdio.h>

void print_string(char str[][10]);

int main()
{
	char patient[12][10] = {"Kirk","Dean","Maxwell","Adams","Lane","Green","Samuels","Fields","Nelson"};
	print_string(patient);
	
	return 0;
}

void print_string(char str[][10])
{
	int i;
	for(i=0;i<12;i++)
	{
		printf("%-5d%s\n", i+1, str[i]);
	}
}

void sort(char str[][10])
{

}
