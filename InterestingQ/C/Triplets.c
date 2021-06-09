#include<stdio.h>

int main()
{
   int a=0, b=0;
   int A[]={5,6,7};
   int B[]={3,6,10};
   
   if(A[0]>B[0])
   {
      a=a+1;
   }
   else   if(A[0]==B[0])  
   {
   
   }
    else   if(A[0]<B[0])   
    {
      b=b+1;
    }
    
   if(A[1]>B[1])
   {
      a=a+1;
   }
   else   if(A[1]==B[1])  
   {
   
   }
    else   if(A[1]<B[1])   
    {
      b=b+1;
    }
    
    if(A[2]>B[2])
   {
      a=a+1;
   }
   else   if(A[2]==B[2])  
   {
   
   }
    else   if(A[2]<B[2])   
    {
      b=b+1;
    }
    
    printf("%d %d",a,b);  
    printf("\n");
   return 0;
}
