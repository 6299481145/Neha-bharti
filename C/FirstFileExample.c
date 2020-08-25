#include<stdio.h>

int main()
{
	char c;
	FILE *fp;  //fp is pointer to structure popularly known as file pointer
	fp=fopen ("FirstFile","w");
	
	printf("please type some text below:\n");
	while(c=getchar() != EOF)
	{
		putc(c,fp);   //file
		//putchar(c)  //console
	}
	printf("Entered information successfully saved in the file: FirstFile\n");
	fclose(fp);
}
