#include<iostream>
using namespace std;
class Time
{
   private:
   int hour;
   int minute;
   int second;
public:
void input()
   {
      cout<<"Enter hour: ";
      cin>>hour;
      cout<<"Enter minute: ";
      cin>>minute;
      cout<<"Enter second: ";
      cin>>second;    
    }
    void display()
    {
      cout<<hour<<":"<<minute<<":"<<second;
    }
};  
int main()
{
    Time t;
    t.input();
    t.display();
    return 0;

}
