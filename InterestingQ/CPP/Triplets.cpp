#include<iostream>

using namespace std;

int main()
{
	int i,j=0,a=0,b=0;
	int a1[3]={27,28,30};
	int b1[3]={99,16,8};
	
	for(int i=0;i<3;i++)
	{
		 if(a1[i]<b1[j]){
		 	b++;}
		 	else if(a1[i]>b1[j]){
		 		a++;}
		 	else{
		 		a+=0;
		 		b+=0;}
		 		j++;
    }	
		 		
cout<<a<<b;
return 0;
}

