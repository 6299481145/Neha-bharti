//Program 11.3 Reading from Two Files Simultaneously
//Reads the files created in program 11.2

#include<iostream>
#include<fstream>
#include<stdlib.h>          //for exit() function

using namespace std;
int main()
{
	const int SIZE =80;
	char line [SIZE];
	
	ifstream fin1, fin2;
	fin1.open("country");
	fin2.open("capital");
	
	for(int i=1; i<=10; i++)
	{
	   cout << "Exit from country\n";
	   exit(1);	
	}
	fin1.getline(line,SIZE);
	cout << "capital of " <<line;
	
	if(fin2.eof() != 0)
	{
		cout << "Exit from capital\n";
		exit(1);
	}
	fin2.getline(line,SIZE);
	cout << line << "\n";
	return 0;
}

