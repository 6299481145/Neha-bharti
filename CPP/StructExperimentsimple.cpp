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
		cout<<"Enter name: ";
		getchar();  //dummy
		cin.getline(name,30);  //Line-oriented input/output function(getline)
		//cin>>name;
	}
	void display()
	{
		cout<<"Roll No: "<<rollno<<endl;
		cout<<"Name: "<<name<<endl;
	}
};
int main()
{
    student s;
	s.input();
	s.display();
	return 0;	
}	
