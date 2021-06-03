<?php
$n=readline("Enter a number:");
$f=1;
for($i=$n;$i>1;$i--){
    $f=$f*$i;
}
echo"The factorial of $n is $f.\n";