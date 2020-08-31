#include<iostream>
#include<cstdio>
#include<fstream>

using namespace std;

int main()
{
	string str;
	ofstream fout;     //fout is an object of ofstream class
	
	
	//.........WARITING CONTENT TO A FILE
	fout.open("FirstFile.txt");
	cout<<"Please type some text below:"<<endl;
	getline(cin,str);
	
	fout<<str;
	cout<<"Entered information successfully saved in the file:FirstFile"<<endl;
	fout.close();
	
	
	//.........READING CONTENT FROM A FILE
	cout<<"To view the content of FirstFile press enter key...."<<endl;
	fflush(stdin);
	getchar();
	ifstream fin;
	fin.open("FirstFile.txt");
	cout<<"FirstFile contains the following text:"<<endl;
	getline(fin,str);
	cout<<str<<endl;
	fin.close();
	
	return 0;
}
