#include<iostream>
using namespace std;
 int main()
{
    int arr[]={56,23,89,45,15};
    int* p=arr;
    cout<<"The value of pointer " <<*p<< "," <<*p+1<<","<<*p+2<<","<<*p+3<<","<<*p+4;
    return 0;
}