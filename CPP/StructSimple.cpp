#include<iostream>

using namespace std;

struct student
{
	int rollno;
	char name[30];
	
	void input()
	{
		cout<<"Enter rollno: ";
		cin>>rollno;
		cout<<"Enter Name: ";
		getchar();
		cin.getline(name,30);
	}
	
	void display()
	{
		cout<<"Roll No: "<<rollno<<endl;
		cout<<"Name: "<<name<<endl;
	}
}s;

int main()
{
	student s;
	s.input();
	s.display();
	return 0;
}
