#include<iostream>
using namespace std;

int main()
{
	int arr[3][3],i,j;
	
	cout<<"Enter a 3 x 3 matrix:"<<endl;
	
	for(i=0;i<3;i++)
	{
		for(j=0;j<3;j++)
		{
			cin>>arr[i][j];
		}
	}
	cout<<"Transpose of matrix is:"<<endl;
	for(i=0;i<3;i++)
	{
		for(j=0;j<3;j++)
		{
			cout<<arr[j][i]<<" ";
		}
		cout<<endl;
	}
	return 0;
}
