<?php
$item_id=$_POST['item_id'];
$qty=$_POST['quantity'];
$sql = "INSERT INTO orders(item_id, quantity) VALUES($item_id,$qty)";
$con->query($sql);
echo "Data inserted successfully";