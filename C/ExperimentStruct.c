#include<stdio.h>

struct student
{
	int rollno;
	char name[30];
}s1,s2,s3;

    void input()
	{
		
		
		printf("Enter rollno: ");
		scanf("%d", &s1.rollno);
		
		printf("Enter name: ");
	    getchar();
		scanf("%[^\n]s",s1.name);
	
	//	gets("name");

	//	scanf("%s",s1.name);
		
		//s.rollno=getline(&name,&30,stdin); 
		//gets(str);
		
		printf("Enter rollno: ");
		scanf("%d", &s2.rollno);
		
		printf("Enter name: ");
		scanf("%[^\n]s",s2.name);
		
		printf("Enter rollno: ");
		scanf("%d", &s3.rollno);
		
		printf("Enter name: ");
		scanf("%[^\n]s",s3.name);
	}
	
    void display()
	{
	
		
		printf("\nRoll No: %d\n",s1.rollno);
		printf("Name: %s",s1.name);
	
		printf("\nRoll No: %d\n",s2.rollno);
		printf("Name: %s",s2.name);
		
		printf("\nRoll No: %d\n",s3.rollno);
		printf("Name: %s",s3.name);
	}

int main()
{
	struct student  ;
	input();
	display();
	return 0;
}
