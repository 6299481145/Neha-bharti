/* C program to Convert lowercase to Uppercase and vice-versa using For Loop*/

#include <stdio.h>
#include <string.h>
 
int main()
{
  	char Str1[100];
  	int i;
 
  	printf("\n Please Enter a String in lowercase or Uppercase:  ");
  	gets(Str1);
  	
  	for (i = 0; Str1[i]!='\0'; i++)
  	{

        if(Str1[i] >= 65 && Str1[i] <= 90)
  		{
  			Str1[i] = Str1[i] +32;
		}
        else  
  		if(Str1[i] >= 97 && Str1[i] <= 122)
  		{
  			Str1[i] = Str1[i] -32;
		}
        
  	}

  	printf("\n The given String convert in Upper Case or lowercase = %s", Str1);
  	
  	return 0;
}