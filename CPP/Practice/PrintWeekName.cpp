#include<iostream>

using namespace std;

int main()
{
    int ch; 

    cout<<"Enter a number choose for week name: ";
    cin>>ch;
    
    switch(ch)
    {
       case 1:
          cout<<"Sunday";
          break;
       case 2:
          cout<<"Monday";
          break;
       case 3:
          cout<<"Tuesday";  
          break;
       case 4:
          cout<<"Wednesday";
          break;
       case 5:
          cout<<"Thrusday";
          break;
       case 6:
          cout<<"Friday"; 
          break;       
   }
   return 0;
    
}