//#include<iostream>
#include<stdio.h>
//using namespace std;

struct student
{
	int rollno;
	char name[30];
}s1;	
    student()
	{
		//cout<<"Enter rollno: ";
		printf("Enter rollno: ");
		scanf("%d", &rollno);
		//cin>>rollno;
		//cout<<"Enter Name: ";
		printf("Enter Name: ");
		getchar();
		cin.getline(name,30);
	}
	
	student()
	{
		cout<<"Roll No: "<<rollno<<endl;
		cout<<"Name: "<<name<<endl;
	}

//};
int main()
{
	student s1, s2, s3;
	return 0;
}
