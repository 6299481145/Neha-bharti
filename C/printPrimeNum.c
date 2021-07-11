/* C Program to Print Prime Numbers between 1 to 100 using For Loop */
 
#include <stdio.h>
 
int main()
{
  int i, n, count; 
  
  printf(" Prime Number from 1 to 1000 are: \n"); 
  for(n= 1; n <= 1000; n++)
  {
    count = 0;
    for (i = 2; i <= n/2; i++)
    {
  	if(n%i == 0)
  	{
     	  count++;
  	      break;
	}
    }
    if(count == 0 && n != 1 )
    {
	printf(" %d ", n);
    }  
  }
  return 0;
}