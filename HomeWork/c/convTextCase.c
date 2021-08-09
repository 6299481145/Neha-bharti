/* C program to Convert lowercase to Uppercase and vice-versa using For Loop*/

#include <stdio.h>
#include <string.h>
 
int main()
{
  	char Str[20];
  	int i;
 
  	printf("\n Please Enter a String in lowercase or Uppercase:  ");
  	gets(Str);
  	
  	for (i = 0; Str[i]!='\0'; i++)
  	{

        if(Str[i] >= 65 && Str[i] <= 90)
  		{
  			Str[i] = Str[i] +32;
		}
        else  
  		if(Str[i] >= 97 && Str[i] <= 122)
  		{
  			Str[i] = Str[i] -32;
		}
        
  	}

  	printf("\n The given String convert in Upper Case or lowercase = %s", Str);
  	
  	return 0;
}