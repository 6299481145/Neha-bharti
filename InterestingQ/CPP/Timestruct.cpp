#include<iostream>
using namespace std;

struct Time
{
    int hour;
    int minute;
    int second;
};
int main()
{
    struct Time t; 
      cout<<"Enter hour: ";
      cin>>t.hour;

      cout<<"Enter minute: ";
       cin>>t.minute;

    cout<<"Enter second: ";
    cin>>t.second;                                                                                                                                                                                                                                                                                                                                                                                                                                                       
    
      cout<<t.hour<<":"<<t.minute<<":"<<t.second;
    
     return 0;
}