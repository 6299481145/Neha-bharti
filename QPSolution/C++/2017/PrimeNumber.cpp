#include<iostream>

using namespace std;

int main()
{
    int flag=0;

    cout<<"Prime numbers between 0 and 1000 are :"<<endl;

    for(int i=2; i<=1000; i++)
    {
        flag=0;

        for(int j=2;j<i; j++)
        {
            if(i%j==0)
            {
                flag++;
            }
        }
        if(flag==0)
         cout<<i<<",";
    }
    cout<<endl;
    return 0;
}