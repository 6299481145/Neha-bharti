//Program 11.9 Command-Line Arguments

#include<iostream>
#include<fstream>
#include<stdlib.h>

using namespace std;

int main(int argc, char*argv[])
{
	int number[9] = {11,22,33,44,55,66,77,88,99};
	
	if(argc != 3)
	{
		cout <<"argc =" <<argc<<endl;
		cout<<"Error in arguments"<<endl;
		exit(1);
	}
	ofstream fout1,fout2;
	
	fout1.open(argv[1]);
	
	if(fout1.fail())
	{
		cout<<"could not open the file"
		    <<argv[1]<<endl;
		    exit(1);
	}
	fout2.open(argv[2]);
	
	if(fout2.fail())
	{
		cout<<"could not open the file"
		    <<argv[2]<<endl;
		    exit(1);
	}
	for(int i=0; i<9; i++)
	{
		if (number[i] % 2 == 0)
		fout2<<number[i]<<"";         //write to EVEN file
		else
		fout1<<number[i]<<"";         //write to ODD file
	}
	fout1.close();
	fout2.close();
	
	ifstream fin;
	char ch;
	for(int i=1; i<argc;i++)
	{
		fin.open(argv[i]);
		cout<<"Contents of"<<argv[i]<<endl;
		do
		{
			fin.get(ch);     // read a value
			cout<<ch;         //display it  
		}
		while(fin);
		cout<<endl<<endl;
		fin.close();
	}
	return 0;
}

