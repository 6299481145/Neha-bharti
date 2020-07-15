//Write a c Program to determine wheather the input character is an alphabet ,a digit or  a special character.//

#include<stdio.h>
int main()
{
	char ch;
	printf("Please enter any character:");
	scanf("%c",&ch);
	
	if((ch>='a'&&ch<='z')||(ch>='A'&& ch<='Z'))
	{
		Printf("\n %c is an alphabet",ch);
    }
    else if(ch>='0'&& ch<='9')
    {
    	Printf("\n %c is a digit",ch);
	}
    else
    Printf("\n %c is a special character,ch");
    return 0;
}
