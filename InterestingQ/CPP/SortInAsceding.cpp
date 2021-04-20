//Q8.WAP to accept 10 integer in an arrayand sort it in asceding order.
#include<iostream>
using namespace std;
int main()
{
	int arr[]={3,6,4,7,5,2,1,9,8};
	int n=sizeof(arr)/sizeof(int);
	
for(int i=0;i<=n-1;i++)
  {
	for(int j=i+1;j<=n;j++)
	 {
		int temp;
		
		if(arr[i]>arr[j]){
			temp=arr[i];
			arr[i]=arr[j];
			arr[j]=temp;}
			
		}
		cout<<arr[i]<<",";
	}
	//cout<<arr[i]<<".";
	
	return 0;	
}
