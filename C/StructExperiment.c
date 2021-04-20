#include<stdio.h>

struct student
{
	int rollno;
	char name[30];
}	s;

    void input()
	{
		int i;
		for( i=0;i<3;i++){
			char name[30];
		
		
		printf("Enter rollno: ");
		scanf("%d", &s.rollno);
		
		printf("Enter name: ");
	    getchar();
		scanf("%[^\n]s",s.name);
	
	//	gets("name");
}
	//	scanf("%s",s1.name);
		
		//s.rollno=getline(&name,&30,stdin); 
		//gets(str);
		
		/*printf("Enter rollno: ");
		scanf("%d", &s2.rollno);
		
		printf("Enter name: ");
		scanf("%s",s2.name);
		
		printf("Enter rollno: ");
		scanf("%d", &s3.rollno);
		
		printf("Enter name: ");
		scanf("%s",s3.name);*/
	}
	
    void display()
	{
		int i;
		for(i=0;i<3;i++){
		
		printf("\nRoll No: %d\n",s.rollno);
		printf("Name: %s",s.name);
	}
		/*printf("\nRoll No: %d\n",s2.rollno);
		printf("Name: %s",s2.name);
		
		printf("\nRoll No: %d\n",s3.rollno);
		printf("Name: %s",s3.name);*/
	}

int main()
{
	struct student  ;
	input();
	display();
	return 0;
}
