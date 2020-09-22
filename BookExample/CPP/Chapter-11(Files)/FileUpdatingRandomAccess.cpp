//Program 11.8 File Updating :: Random Access

#include<iostream>
#include<fstream> 
#include<iomanip>

using namespace std;

class INVENTORY

{
    char name[10];
    int code;
    float cost;
  public:
      void getdata()
	  {
	    cout<<"Enter item name:";
 	    cin>>name;
	    cout<<"Enter item code:";
	    cin>>code;
	    cout<<"Enter item cost:";
	    cin>>cost;
	  }
	  void putdata()
	  {
	  	cout<<setw(10)<<code;
	    cout<<setw(10)<<name;
	    cout<<std::fixed<<setprecision(2)<<setw(10)<<cost;
	    cout<<endl;
	  }	
};  //End of class definition
int main()
{
	INVENTORY item;   
	fstream inoutfile;     //input/output stream
	    inoutfile.open("STOCK.DAT", ios::ate | ios::in | ios::out | ios::binary);
	      inoutfile.seekg(0,ios::beg);    //go to start
	      
	      cout<<"CURRENT CONTENTS OF STOCK"<<endl;
	      
	      while(inoutfile.read((char*) &item, sizeof item));
		  {
		     item.putdata();			
		  } 
		      inoutfile.clear();  //turn of EOF flag 
		      
		      /*>>>>>>>>>>>>>>>>>>>>>>> Add one more item<<<<<<<<<<<<<<<<<<<<<<<*/
		      
		      cout <<endl <<"AD AN ITEM"<<endl;
		      item.getdata();
		      char ch;
		      cin.get(ch);
		      inoutfile.write((char*) &item, sizeof item);
		      
		     // Display the appended file
		      inoutfile.seekg(0);   //go to the start
		      
		      cout<<"CONTENTS OF APPENDED FILE "<<endl;
		      
		      while(inoutfile.read((char*) &item, sizeof item));
		      {
		      	 item.putdata();
			  }
			 // Find number of objects in the file
			  int last = inoutfile.tellg();
			  int n = last/sizeof(item);
			  
			  cout<<"number of object ="<<endl<<endl;
			  cout<<"Total byte in the file  ="<<last<<endl;
			  
			  /*>>>>>>>>>>>>>>>>>>>>>>> MODIFY THE DETAILS OF AN ITEM<<<<<<<<<<<<<<<<<<<<<<<*/
			  
			  cout<<"Enter object number to be updated"<<endl;
			  int object;
			  cin >> object;
			  
			  cin.get(ch);
			  
			  int location = (object-1) *sizeof(item);
			  
			  if(inoutfile.eof())
			  inoutfile.clear();
			  
			  inoutfile.seekp(location);
			  cout<<"Enter new values of the object"<<endl;
			  item.getdata();
			  cin.get(ch);
			  
			  inoutfile.write((char*) &item, sizeof item)<<flush;
			  
			   /*>>>>>>>>>>>>>>>>>>>>>>> SHOW UPDATE FILE <<<<<<<<<<<<<<<<<<<<<<*/
			   
			   inoutfile.seekg(0);   //go to the start
			   
		       cout<<"CONTENTS OF UPDATE FILE "<<endl;
		       
		       while(inoutfile.read((char*) &item, sizeof item));
		       {
		      	 item.putdata();
			   }
			   inoutfile.close();
			   
			   return 0;
}
