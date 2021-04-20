<?php
	echo 'This PHP is used at the beginning of the page.';
	$c = 10 + 20;
?>

<html>
	<head>
		<title></title>
	</head>
	<body>
		<h1>Experimenting with PHP in a webpage</h1>
		<?php echo 'This PHP is written at the middle of the page.';?>
		<?php echo '<p>This paragraph uses HTML formattings but is called from a PHP code.</p>'; ?>
	</body>
</html>

<?php
	echo 'This PHP is written at the end of the page.';
	echo '<p>The value of c is ' . $c . '.</p>';
?>