//Program 11.2 Working with Multiple Files

#include<iostream>
#include<fstream>

using namespace std;

int main()
{
	ofstream fout;           //create output stream
	fout.open("country");    //connect "country" to it 
	
	fout<<"United States of America" <<endl;
	fout<<"United Kingdom" <<endl;
	fout<<"South Korea" <<endl;
	
    fout.close();
	
	fout.open("capital");
	
	fout<<"Washington" <<endl;
	fout<<"London" <<endl;
	fout<<"Seoul" <<endl;
	
    fout.close();
	
   //	Reading the files
   const int N = 80;
   char line[N];
   
   ifstream fin;
   fin.open("country");
   
   cout<<"contents of country file"<<endl;
   
   while(fin)
   {
   	       fin.getline(line,N);
   	       cout<<line;
   }
   fin.close();
   fin.open("capital");
   
   cout<<endl<<"Contents of capital file"<<endl;
   
   while(fin)
   {
   	       fin.getline(line,N);
   	       cout<<line;     
   }
   fin.close();
   
   return 0;
}
