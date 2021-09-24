#include<stdio.h>

int main()
{
  char str[30], i;
  
  printf("Enter the string:");
scanf("%[^\n]", str);
  
  for(i=0; str[i]!='\0'; i++)
  {
    if(str[i] >= 'a' && str[i] <= 'z')
	{
      str[i]= str[i]-32;
	}  
  }
  printf("\nString in lower case: %s", str);
   
  return 0;
  
}

