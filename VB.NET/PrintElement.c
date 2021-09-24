 #include<stdio.h>
 
 int main()
 {
   int n[5],i;
   
   printf("Enter the five elements: \n");
   
   
   for(i=0; i<5; i++)
   {
     scanf("%d",&n[i]);
   }
   printf("\n");
   
    printf("The entered  elements are: \n");
   
   for(i=0;i<5; i++)
   {
     printf("%d", n[i]);
	 printf("\n");
   }
   
    return 0;
 }