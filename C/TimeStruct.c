#include<stdio.h>

struct Time
{
   int hour;
   int minute;
   int second;
}; 
int main()
   {
      struct Time t; 
      printf("Enter hour: ");
      scanf("%d", &t.hour);

      printf("Enter minute: ");
      scanf("%d", &t.minute);

      printf("Enter second: ");
      scanf("%d", &t.second);
    
      printf("The time is %d:%d:%d", t.hour, t.minute,t.second );
    
     return 0;

}
