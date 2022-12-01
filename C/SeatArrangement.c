#include <stdio.h>      
  
#include <stdlib.h>  
int main()  
{     
    int i, n , student;  
    
    printf (" How many student present in classroom: ");  
    scanf("%d",&student);
    for (i = 1; i <= student; i++)  
    {  
        n = rand() % 100 + 1; // use rand() function to get the random number  
        printf (" %d ", n ,"\n");  

	}
  
}