// C program to illustrate empty structure 
//#include <stdio.h> 
#include<iostream>

using namespace std;
  
// empty structure 
struct Record { 
} ;
  
// Driver program 
int main() 
{ 
    Record s; 
    //printf("%d\n", sizeof(s));
	cout<<sizeof(s)<<endl; 
    return 0; 
} 
