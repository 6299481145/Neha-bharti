#include<stdio.h>
#include<stdlib.h>

int main()
{
	char filename[100],c ;
	FILE *fp1,*fp2;
	
	printf("Please enter the filename to open for reading\n");
	scanf("%s",filename);
	
//	open one file for reading
     
	fp1=fopen(filename,"r");
	 
	if(fp1==NULL)  
//	{
//	 printf("cannot open file %s\n",filename);
//	 exit(0);	
//	}
	
	printf("Please enter the filename to open for writing\n");
	scanf("%s",filename);
	
	//	open one file for writing
     
	fp2=fopen(filename,"w");
	 
	if(fp2==NULL)  
//	{
//	 printf("cannot open file %s\n",filename);
//	 exit(0);	
//	}
	
	//Read contents from file
	
	c=fgetc(fp1);
	
	while(c!=EOF)
	{
		fputc(c,fp2);
		c=fgetc(fp1);
	}
	
	printf("\ncontents copied to %s",filename);
	
	fclose(fp1);
	fclose(fp2);
	
	return 0;
	
}
