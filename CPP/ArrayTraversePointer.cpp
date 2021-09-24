#include<iostream>
using namespace std;

namespace ArrayTraversePointer
{
   void display_array(int *p, int size)
   {
       for(int i=1; i<=size; i++)
       {
           printf("%d\n", *p);
           p++;
       }
   }
}

using namespace ArrayTraversePointer;

int main()
{
    int size = 5;
    int arr[]={45, 999, 65, 74, 3};
    printf("The array contains following elements:\n");
    display_array(arr, size);
    return 0;
}