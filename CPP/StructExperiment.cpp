#include<iostream>

using namespace std;

struct student
{
	int rollno;
	char name[30];
	
	student()
	{
		cout<<"Enter rollno: ";
		cin>>rollno;
		cout<<"Enter Name: ";
		getchar();
		cin.getline(name,30);
	}
	
	~student()
	{
		cout<<"Roll No: "<<rollno<<endl;
		cout<<"Name: "<<name<<endl;
	}
};

int main()
{
	student s1, s2, s3;
	return 0;
}
