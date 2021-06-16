#include<stdio.h>
int  main()
{
    int i,j=0,a=0,b=0;
    int a1[3]={27,28,30};
	int b1[3]={99,16,8};
	
	for( i=0;i<3;i++)
	{
		 if(a1[i]<b1[j]){
		 	b++;}
		 	else if(a1[i]>b1[j]){
		 		a++;}
		 	else{
		 		a+=0;
		 		b+=0;}
		 		j++;
                 
    }	
    printf("%d %d",a,b);
    return 0;

}