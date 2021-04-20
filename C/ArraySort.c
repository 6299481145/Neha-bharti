#include<stdio.h>

int main()
{
	int age[]={12,13,9,5,14};
	int i,j,t;
	for(i=0;i<4;i++)
	{
		for(j=i+1;j<5;j++)
		{
			if(age[i]>age[j])
			{
			
			   t=age[i];
			   age[i]=age[j];
			   age[j]=t;
		    }
	   }
    }
printf("The sorted array is: \n");
for(i=0;i<5;i++)
{
	printf("%d\n",age[i]);
}
  return 0;
};
