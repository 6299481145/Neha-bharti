// EMI Calculator program in C //

#include<stdio.h>
#include<math.h>

// Function to calculate EMI //

float EMI_Calculator (float p,float r, float t);
{

	float EMI;
	
	r=r/(12*100);//one month interest//
	t=t*12;//one month period
	
	EMI=(p*r*pow(1+r),t);
	
	return 0 ;
}
