//Program to find wheather a string is a palindrome or not//

#include<stdio.h>
#include<string.h>
int main()
{
	char str[30],rev[30];
	
	printf("Please enter a string:");
	scanf("%s",str);
	
	strcpy(rev,str);
	strrev(rev);
	
	if(strcmpi(str,rev)==0)
	{
		Printf("%s is Palindrome",str);
	}
	else
	{
		printf("%s is not a palindrome",str);
	}
	return 0;
}
