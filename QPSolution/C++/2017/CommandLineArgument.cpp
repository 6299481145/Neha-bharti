#include<iostream>

using namespace std;

int main(int argc, char *argv[])
{
    printf("The various command line arguments are:\n");

    for(int i=1; i<argc; i++)
        printf("%s\n",argv[i]);
    return 0;
}