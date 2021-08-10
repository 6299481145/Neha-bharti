#include <stdio.h>

int main()
{
  int a;

  printf("Enter a number: ");
  scanf("%d",&a);

  if(a > 0 && (a & (a - 1)) == 0)
  {
    printf("%d is a power of 2.", a);
  }
  else
  {
    printf("%d is not a power of 2.", a);
  }
  return 0;
}