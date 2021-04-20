#include<stdio.h>

int main()
{
	int a=12,b=13,c=9;
	
	printf("The sorted values are:\n");
	if(a>b&&b<c)
    	printf("%d,%d,%d\n",a,b,c);
    else if(b<a&& a<c)
	    printf("%d,%d,%d\n",b,a,c);
	else if(c<a&& a<b)
	    printf("%d,%d,%d\n",c,a,b);
	else if(a<c&& c<b)
	    printf("%d,%d,%d\n",a,c,b);
	else if(b<a&& a<c)
	    printf("%d,%d,%d\n",a,c,b);
    else if(c<b&& b<a)
	    printf("%d,%d,%d\n",a,c,b);

	return 0;
}
