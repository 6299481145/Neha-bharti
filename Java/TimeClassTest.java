class Time{
	private int hh,mm, ss,ampm;
	
	void get_Time(int h,int m,int s, int ap){
		hh=h;
		mm=m;
	    ss=s;
	    ampm=ap;
	}
	void show_Time(){
		System.out.print(hh+":"+mm+":"+ss+"");
		if(ampm==0)
		    System.out.println("am");
		else
            System.out.println("pm");
			
	}
}
class TimeTest{
	public static void main(String[]args)
	{
		Time t=new Time();
		t.get_Time(11,40,30,0);
		t.show_Time();
	}
}	