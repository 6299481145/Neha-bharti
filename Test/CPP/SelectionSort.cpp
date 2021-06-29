#include<iostream>
using namespace std;
int main()
{
   int i, x, y, n[20];

   cout<<"How many numbers you are going to enter?: ";
   cin>>x;

   //printf("Enter %d elements: ", x);
   cout<<"Enter " <<x<< " elements: ";
   // Loop to get the elements stored in array
   for(int i=0;i<x;i++)
      
      cin>>n[i];
 
   // Logic of selection sort algorithm
   for(int i=0;i<x;i++){
      for(int j=i+1;j<x;j++){
         if(n[i]>n[j]){
            y=n[i];
            n[i]=n[j];
            n[j]=y;
         }
      }
   }

   //printf("Sorted elements: ");
   cout<<"Sorted elements: ";
   for(int i=0;i<x;i++)
   cout<<n[i]<<" ";
     
   return 0;
}  
 