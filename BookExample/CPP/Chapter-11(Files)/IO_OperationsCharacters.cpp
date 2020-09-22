//Program 11.4 I/O Operations on characters

#include<iostream>
#include<fstream>
#include<string.h>

using namespace std;

int main()
{
	char string[80];
	cout<<"Enter a string:";
	cin>>string;
	
	int len=strlen(string);
	
	fstream file;          //input and output stream
	cout<<endl<<"Opening the 'TEXT' file storing the string in it."<<endl<<endl;
	
	file.open("TEXT", ios::in |  ios::out );
	
	for(int i=0;i<len;i++)
	  file.put(string[i]);    // put a character to file
	  
	  file.seekg(0);        // go to the start
	  
	  char ch;
	  cout<<"Reading the file contents:";
	  while(file)
	  {
	  	file.get(ch);      // get a character from file
	  	cout<<ch;         // display it on screen
	  }
	  return 0;
}
