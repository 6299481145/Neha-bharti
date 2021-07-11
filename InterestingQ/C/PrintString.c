#include<stdio.h>
#include<stdio.h>
int  main ()
{
char str1[]="I LOVE MY COUNTRY", str2[20];
int count,i;
//clrscr();
i=0;
While (str1[i]=" ");
{
count++;
i++;
}
i=0;
while (str1[i]!=" ")
{
str2[count-1-i]=str1[i];
i++;
}
str2[i] =" ";
printf ("reversed string is %s",str2);
 return 0;
}