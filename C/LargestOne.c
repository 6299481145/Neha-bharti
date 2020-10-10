/* Program to accept 5 intergers and display the largest one */

#include<stdio.h>

int main()
{
   int integers [5]={25,100,7,67,152};
   int largest=integers[0] ,i;
   ;
   
   for(i=1;i<5;i++)
   {
   	if(integers[i]>largest)
   	    largest=integers[i];
   }
   printf("The largest of ");
   
   for(i=0;i<5;i++)
   {
   	printf("%d,", integers[i]);
   }
   printf("is:%d",largest);
   return 0;
}
