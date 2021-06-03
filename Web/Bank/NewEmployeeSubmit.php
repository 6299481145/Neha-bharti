<?php
$eid=$_GET['employee_id'];
$ename=$_GET['employee_name'];
$bcode=$_GET['branch_code'];
$gender=$_GET['gender'];
$cnum=$_GET['contact_no'];
$state=$_GET['state'];
$con=new mysqli('localhost','Neha','Neha','Bank');
if($con->connect_error){
    die($con->connect_error);
}
$sql="INSERT INTO Employee values('$eid','$ename','$bcode','$gender','$cnum','$state')";
if($con->query($sql)==true){
echo "Data inserted successfully";
}else{
   echo $con->error;

}