/*
	ANSI C - Exercise- 8 Array Question  8.3
	
*/

#include<stdio.h>
#include<stdlib.h>
#include ArrayUtility.c

void count_vote(int count[]);

int main()
{
	int count[6] = {0,0,0,0,0,0};
	count_vote(count);
	return 0;
}

void count_vote(int count[])
{
	int code;
	printf("List of candidates:\n");
	printf("1. Neha Bharti\n");
	printf("2. Aman Kumar\n");
	printf("3. Prince Kumar\n");
	printf("4. Md. Waseem\n");
	printf("5. Banty Kumar\n");
	printf("6. Spoilt\n");
	printf("7. Display Count\n");
	printf("8. Exit\n");
	
	printf("Enter candidate code: ");
	scanf("%d", &code);
	
	switch(code)
	{
		case 1:
			count[0]++;
			count_vote(count);
			break;
		case 2:
			count[1]++;
			count_vote(count);
			break;
		case 3:
			count[2]++;
			count_vote(count);
			break;
		case 4:
			count[3]++;
			count_vote(count);
			break;
		case 5:
			count[4]++;
			count_vote(count);
			break;
		case 6:
			count[5]++;
			count_vote(count);
			break;
		case 7:
			PrintArray(count,6);
			count_vote(count);
		case 8:
			exit(0);
			break;
		default:
			printf("Invalid option! please retry...\n");
			count_vote(count);
	}
}
