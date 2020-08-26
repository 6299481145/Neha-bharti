#include <iostream>
using namespace std;
int main()
{
	char c;
	FILE *fp;
	fp= fopen("FirstFile","w");
	
	cout<<"Please enter type some text below:"<<endl;
	
	while(c=getchar() !=EOF)
	{
		putc(c,fp);  //file
		//putchar(c)  //console
	}
	cout<<"Entered information successfully saved in the file:FirstFile<<endl";
	fclose(fp);
}
