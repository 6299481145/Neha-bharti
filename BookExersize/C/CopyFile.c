//13.1  Program to copy the contents of one file into another

#include<stdio.h>
#include<stdlib.h>

int main()
{
	char c, first_file[20],another_file[20];
	FILE *first,*another;
	
	printf("Please enter name of file to copy:\n");
	gets(first_file);
	
	first=fopen(first_file,"r");
	
	if(first==NULL)
	{
		Printf("Press enter key to exit...\n");
		exit(EXIT_FAILURE);
	}
	Printf("Please enter name of another file\n");
	gets(another_file);
	
	another=fopen(another_file,"w");
	if(another==NULL)
	{
		fclose(first);
		
		printf("Press enter key to exit...\n");
		exit(0);
	}
	while((c=fgetc(first)) !=EOF)
	fputc(c,another);
	
	printf("File copied successfully.\n");
	
	fclose(first);
	fclose(another);
	
	return 0;
}

