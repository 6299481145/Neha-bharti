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
    t.hour=12;
    t.minute=30;
    t.second=23;

    cout<<"Time is "<<t.hour<<":"<<t.minute<<":"<<t.second;
    return 0;
}    