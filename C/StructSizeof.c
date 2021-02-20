// C program to illustrate empty structure 
#include <stdio.h> 
  
// empty structure 
struct Record { 
}; 
  
// Driver program 
int main() 
{ 
    struct Record s; 
    printf("%d\n", sizeof(s)); 
    return 0; 
} 
