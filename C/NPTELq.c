#include<stdio.h>

void main()
{
	static int n;
	if (n++<2)
	main();
}
