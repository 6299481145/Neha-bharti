#include <stdio.h>
#include <stdlib.h>

#define MAX 100

void menu(int *arr, int *size);
void display(int *arr, int *size);
void insert_end(int *arr, int *size);
void insert_index(int *arr, int *size, const int in);
void insert_before(int *arr, int *size, const int val);
void insert_after(int *arr, int *size, const int val);
int search_linear(int *arr, int *size, const int val);
void search_binary(int *arr, int *size, const int val);
void swap(int *x, int *y);
void sort_selection(int *arr, int *size);
void sort_bubble(int *arr, int *size);
void sort_insertion(int *arr, int *size);
void sort_merge(int *arr, int *size);
void sort_heap(int *arr, int *size);
void delete_end(int *arr, int *size);
void delete_index(int *arr, int *size, const int in);
void merge(int *arr1, int *size1, int *arr2, int *size2);

int main()
{
    int size = 0;
    int *arr = malloc(MAX * sizeof(int));
    arr[0] = 23;
    arr[1] = 15;
    arr[2] = 99;
    arr[3] = 12;
    arr[4] = 56;
    size = 5;
    menu(arr, &size);
    return 0;
}

void menu(int *arr, int *size)
{
    int in, no;
    int ch; //O(1)
    do
    {
        printf("**************************** MAIN MENU **********************************\n");
        printf("1. Display (Traverse)\n");
        printf("2. Insert (at the end)\n");
        printf("3. Insert (at a specified index)\n");
        printf("4. Insert (Before)\n");
        printf("5. Insert (After)\n");
        printf("6. Search (Linear)\n");
        printf("7. Search (Binary)\n");
        printf("8. Sort (Selection)\n");
        printf("9. Sort (Bubble)\n");
        printf("13. Delete (from the end)\n");
        printf("14. Delete (from a specified index)\n");
        printf("Enter your choice (0 to exit): ");
        scanf("%d", &ch);
        switch (ch)
        {
        case 0:
            exit(0);
            break;
        case 1:
            display(arr, size);
            break;
        case 2:
            insert_end(arr, size);
            break;
        case 3:
            printf("Enter index: ");
            scanf("%d", &in);
            insert_index(arr, size, in);
            break;
        case 4:
            printf("Enter number before which new element is to be inserted: ");
            scanf("%d", &no);
            insert_before(arr, size, no);
            break;
        case 5:
            printf("Enter number after which new element is to be inserted: ");
            scanf("%d", &no);
            insert_after(arr, size, no);
            break;
        case 6:
            printf("Enter number to search: ");
            scanf("%d", &no);
            search_linear(arr, size, no);
            break;
        case 7:
            printf("Enter number to search: ");
            scanf("%d", &no);
            search_binary(arr, size, no);
            break;
        case 8:
            sort_selection(arr, size);
            break;
        case 9:
            sort_bubble(arr, size);
            break;
        case 13:
            delete_end(arr, size);
            break;
        case 14:
            printf("Enter index: ");
            scanf("%d", &in);
            delete_index(arr, size, in);
            break;
        default:
            printf("\nInvalid option!\n\n");
        }
    } while (1);
}

void display(int *arr, int *size) //O(N) - linear
{
    int i;
    if (*size == 0) //O(1)
    {
        printf("\nThe array is empty. There is nothing to display!\n\n"); //O(1)
    }
    else //O(1)
    {
        printf("\nThe elements of the array are:\n"); //O(1)
        for (i = 0; i < *size; i++)               //O(N)
        {
            printf("%d\n", arr[i]); //O(N)
        }
        printf("\n"); //O(1)
    }
}

void insert_end(int *arr, int *size) //O(1) - constant
{
    if (*size == MAX)
    {
        printf("\nThe array is full. Cannot insert anymore!\n\n");
    }
    else
    {
        printf("Enter a number: ");                       //O(1)
        scanf("%d", &arr[*size]);                         //O(1)
        printf("\nItem inserted at index %d\n\n", *size); //O(1)
        (*size)++;                                        //O(1)
    }
}

/*
    O(1) + O(1) + O(1) + O(1)   =   O(4 X 1) =  O(1)
*/

void insert_index(int *arr, int *size, const int in)
{
    int i;
    if (*size == MAX)
    {
        printf("\nThe array is full. Cannot insert anymore!\n\n");
    }
    else if (in >= *size)
    {
        printf("\nIndex is out of range. Valid range is 0 to %d.\n\n", *size - 1);
    }
    else
    {
        for (i = *size; i > in; i--)
        {
            arr[i] = arr[i - 1];
        }

        printf("Enter a number: ");
        scanf("%d", &arr[in]);
        printf("\nItem inserted at index %d\n\n", in);
        (*size)++;
    }
}

void insert_before(int *arr, int *size, const int val)
{
    int in = search_linear(arr, size, val);
    insert_index(arr, size, in);
}

void insert_after(int *arr, int *size, const int val)
{
    int in = search_linear(arr, size, val);
    in++;
    insert_index(arr, size, in);
}

int search_linear(int *arr, int *size, const int val) //O(n)
{
    int i;

    for (i = 0; i < *size; i++) //O(n)
    {
        if (arr[i] == val)
        {
            printf("\n%d found at index %d.\n\n", val, i);
            break;
        }
    }
    return i;
}

void search_binary(int *arr, int *size, const int val) //O(log(n))
{
    int lb = 0, ub = *size - 1, i, mid, iterate=0;
    sort_selection(arr, size);

    for (i = 0; i < *size; i++)
    {
        iterate++;
        mid = (lb + ub) / 2;
        if (val == arr[mid])
        {
            printf("\n%d found at index %d.\n\n", val, mid);
            break;
        }
        else if (val < arr[mid])
        {
            ub = mid;
        }
        else
        {
            lb = mid;
        }
    }
    printf("iterate: %d\n\n", iterate);
}

void swap(int *x, int *y)
{
    int t;
    t = *x;
    *x = *y;
    *y = t;
}

void sort_selection(int *arr, int *size)        //O(n^2)
{
    int i, j, iterate=0;
    for (i = 0; i < *size - 1; i++)             //O(n)
    {
        for (j = i + 1; j < *size; j++)         //O(n^2)
        {
            iterate++;
            if (arr[i] > arr[j])
                swap(&arr[i], &arr[j]);
        }
    }
    //printf("iterate=%d\n", iterate);
    printf("\nArray sorted!\n\n");
}

void sort_bubble(int *arr, int *size)       //O(n^2)
{
    int i, j, iterate=0;
    for (i = 0; i < *size - 1; i++)         //O(n)
    {
        for (j = 0; j < *size - 1; j++)     //O(n^2)
        {
            iterate++;
            if (arr[j] > arr[j + 1])
                swap(&arr[j], &arr[j + 1]);
        }
    }
    printf("iterate=%d\n", iterate);
    printf("\nArray sorted!\n\n");
}

void delete_end(int *arr, int *size) //O(1)
{
    if (*size == 0) //O(1)
    {
        printf("\nThe array is empty. There is nothing to delete!\n\n"); //O(1)
    }
    else //O(1)
    {
        (*size)--;                                        //O(1)
        printf("\nItem at index %d deleted.\n\n", *size); //O(1)
    }
}

void delete_index(int *arr, int *size, const int in)
{
    int i;
    if (*size == 0)
    {
        printf("\nThe array is empty. There is nothing to delete!\n\n"); //O(1)
    }
    else if (in >= *size)
    {
        printf("\nIndex is out of range. Valid range is 0 to %d.\n\n", *size - 1);
    }
    else
    {
        for ( i = in; i < *size; i++)
        {
            arr[i] = arr[i + 1];
        }
        (*size)--;
        printf("\nItem at index %d deleted.\n\n", in); //O(1)
    }
}