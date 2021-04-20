#include<stdio.h>

int main()
{
	static int n;
	if (n++<2)
	main();
	printf("n=%d\n",n);
}
