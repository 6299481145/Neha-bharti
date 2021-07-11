#include<iostream>
using namespace std;
int main()
{
    int n, *arr;
    cout<<"Enter the size of the array: ";
    cin>>n;

    arr = new int[n];
    cout<<"Enter "<<n<<"value below : "<<endl;
    for(int i=0; i<n; i++)
    {
      cin>>arr[i];
    }

    cout<<"The elements are the array are:"<<endl;
    for(int i=0; i<n; i++)
    {
        cout<<arr[i]<<endl;
    }
    return 0;
}