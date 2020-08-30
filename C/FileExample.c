#include<stdio.h>

int main()
{
	char str[50];
	FILE *fp;       // fp is pointer to structure properly known as file pointer
	
	//.........WRITING CONTENT TO A FILE
	fp= fopen("FirstFile","w");
	printf("Please type some text below:\n");
	scanf("%[^\n]",str);
	
	fprintf(fp,"%s",str);
	printf("Entered information successfully saved in the file: FirstFile\n");
	fclose(fp);
	
	
    //..........READING CONTENT FROM A FILE
	printf("To view the content of FirstFile press enter key....\n ");
	fflush(stdin);
	getchar();
	fp=fopen("FirstFile","r");
	printf("FirstFile contains the following text:\n ");
	fscanf(fp,"%[^\n]",str);
	printf("%s\n",str);
	fclose(fp);
	
}
