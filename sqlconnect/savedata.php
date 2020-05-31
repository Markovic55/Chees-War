<?php

$con = mysqli_connect('127.0.0.1', 'root', '', 'killtheking');

	
// check connection

	if(mysqli_connect_errno())
	{
		echo "1: Connection failed"; // error code #1 = connection failed
		exit();
	}

   $username = $_POST["username"];
   $newwins = $_POST["wins"];
   $newlosses= $_POST["losses"];

   $namecheckquery = "SELECT username  FROM players WHERE username='" . $username . "';";

   $namecheck = mysqli_query($con, $namecheckquery) or die("2: Name check query failed"); // error code #2 - name check query failed

	if(mysqli_num_rows($namecheck) != 1)
	{
		echo "5: Either no user with name, or more than one"; //eror code #5 - number of matching != 1
		exit();
	}


	$updatequery = "UPDATE players SET 'wins' = '$newwins', 'losses'='$newlosses' WHERE username = '" .$username . "';";
	mysqli_query($con, $updatequery) or die("7: Save query failed") // error code #7 - update query failed

	echo "0";



	?>