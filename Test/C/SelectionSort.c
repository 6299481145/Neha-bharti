#include<stdio.h>

int main()
{
   int i, j, x, y, n[20];

   printf("How many numbers you are going to enter?: ");
   scanf("%d",&x);

   printf("Enter %d elements: ", x);
   // Loop to get the elements stored in array
   for(i=0;i<x;i++)
      scanf("%d",&n[i]);
 
   // Logic of selection sort algorithm
   for(i=0;i<x;i++){
      for(j=i+1;j<x;j++){
         if(n[i]>n[j]){
            y=n[i];
            n[i]=n[j];
            n[j]=y;
         }
      }
   }

   printf("Sorted elements: ");
   for(i=0;i<x;i++)
      printf(" %d",n[i]);

   return 0;
}  
 