#include<iostream>
using namespace std;

int main()
{
 int arr1[]={1,2,3,4,5};
 int arr2[]={6,7,8,9,10};
 int arr3[10];
 int j=0;
 
 for(int i=0;i<10;i++)	
 {
 	arr3[i]=arr1[i];
 
    if(i>4)
	{
 	  arr3[i]=arr2[j];
 	  j++;
	}
 }
 for(int i=0;i<10;i++)
 {
 	cout<<arr3[i]<<",";
 }
 return 0;
}
