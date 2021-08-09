#include<stdio.h>
#include<stdlib.h>
typedef struct date
{
   int dd;
   int mm;
   int yyyy;
} DATE;

void menu(DATE *d1, DATE *d2);
void input(DATE *d);
void display();
void date_add();
void date_diff(DATE *d1, DATE *d2);

//DATE d;

int main()
{
    DATE  *d1, *d2;
    d1= malloc(sizeof(DATE));
    d2= malloc(sizeof(DATE));
    menu(d1, d2);
}

void menu(DATE *d1, DATE *d2)
{
    int ch;
    //DATE *d1, *d2;
    while(1)
    {
    printf("MENU\n");
    printf("1. Read Date\n");
    printf("2. Display Date\n");
    printf("4. Date difference\n");
    printf("Enter you choice(o to exit):");
    scanf("%d", &ch);
    
    switch (ch)
    {
    case 0:
       exit(0);
       break;
    case 1: 
        input(d1);
        break;
    case 2:
        display(d1);
        break; 
    case 4: 
        input(d1);
        input(d2);
        date_diff(d1,d2);   

    default:
        printf("Invalid option!");
    }
  }
}
void input(DATE *d)
{
    printf("Enter date(dd/mm/yyyy): ");
    scanf("%d/%d/%d",&d->dd,&d->mm,&d->yyyy);
}

void display(DATE *d)
{
printf("%d/%d/%d\n", d->dd, d->mm, d->yyyy);
}

void date_diff(DATE *d1, DATE *d2)
{
  DATE res;  
  if (d2->dd < d1->dd)
  {
      d2->dd = d2->dd+30;
     
      d2->mm--;
  }
  res.dd=d2->dd-d1->dd;

  if(d2->mm < d1->mm)
  {
      d2->mm=d2->mm+12;
      d2->yyyy--;
  }
  res.mm= d2->mm-d1->mm;

  res.yyyy=d2->yyyy- d1->yyyy;

  printf("The date difference is %d years, %d months and %d days.\n\n", res.yyyy, res.mm,res.dd);
}