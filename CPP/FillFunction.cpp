#include<iostream>

using namespace std;

int main()
{
	int n;
	
	cout<<"Please enter a number:";
	cin>>n;
	cout.width(4);
	cout.fill('0');
	cout<<n<<endl;
	return 0;
}
