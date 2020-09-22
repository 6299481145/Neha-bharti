//Program 11.6 Reading and Writing Class Objects

#include<iostream>
#include<fstream>
#include<iomanip>

using namespace std;

class INVENTORY
{
	int code;
	char name[10];
	float cost;
 public:
    void readdata();
    void writedata();
};

void INVENTORY:: readdata()     // read from keyboard
{
	cout<<"Enter item code:";
	cin>>code;
	cout<<"Enter item name:";
	cin>>name;
	cout<<"Enter item cost:";
	cin>>cost;
}

void INVENTORY ::writedata()
{
	cout<<setw(10)<<code;
	cout<<setw(10)<<name;
	cout<<std::fixed<<setprecision(2)<<setw(10)<<cost;
	cout<<endl;
}

int main()
{
	INVENTORY item[3];
	
	fstream file;
	
	file.open("STOCK.DAT", ios::in | ios::out);
	
	cout<<"ENTER DETAILS FOR THREE ITEMS"<<endl;
	for(int i=0;i<3;i++)
	{
		item[i].readdata();
		file.write((char*) &item[i], sizeof(item[i]));    //reading object from file
	}
	file.seekg(0);
	
	cout<<endl<<"OUTPUT"<<endl<<endl;
	for(int i=0;i<3;i++)
	{
		file.read((char*) &item[i], sizeof(item[i]));      //writing object from file
		item[i].writedata();
	}
	file.close();
	return 0;
}
