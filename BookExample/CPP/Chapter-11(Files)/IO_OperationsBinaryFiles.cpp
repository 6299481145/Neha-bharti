//Program 11.5 I/O Operations on binary files

#include<iostream>
#include<fstream>
#include<iomanip>

using namespace std;

const char* filename = "BINARY";

int main()
{
	float height[4] = {175.5, 153.0, 167.25, 160.70};
	
	ofstream outfile;
	outfile.open(filename);
	
	outfile.write((char*) &height, sizeof(height));
	
	outfile.close();        // close the file for reading
	
	for(int i=0; i<4; i++)   //clear array from memory
	height[i] = 0;
	ifstream infile;
	infile.open(filename);
	
	infile.read((char*) &height, sizeof(height));
	
	for(int i=0; i<4;i++)
	{
		cout.setf(ios::showpoint);
		cout<<setw(10)<<setprecision(2)<<height[i];
	}
	infile.close();
	
	return 0;
}
