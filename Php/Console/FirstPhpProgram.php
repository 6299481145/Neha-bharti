<?php
class Time{
	private $hh,$mm,$ss,$ampm;
	
	public function get_Time($h,$m,$s, $ap){
		$this->hh=$h;
		$this->mm=$m;
	    $this->ss=$s;
	    $this->ampm=$ap;
	}
	public function show_Time(){
		echo"$this->hh:$this->mm:$this->ss";
		if($this->ampm==0)
		    echo("am\n");
		else
            echo "pm\n";
			
	}
}

	    $t=new Time();
		$t->get_Time(5,47,58,0);
		$t->show_Time();
	
	