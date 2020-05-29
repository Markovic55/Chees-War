<?php

$con = mysqli_connect('127.0.0.1', 'root', '', 'killtheking');

	
// check connection

	if(mysqli_connect_errno())
	{
		echo "1: Connection failed"; // error code #1 = connection failed
		exit();
	}

	$username = $_POST["username"];
	$password = $_POST["password"];


	//check if name exist

	$namecheckquery = "SELECT username, salt, hash FROM players WHERE username='" . $username . "';";

	$namecheck = mysqli_query($con, $namecheckquery) or die("2: Name check query failed"); // error code #2 - name check query failed

	if(mysqli_num_rows($namecheck) != 1)
	{
		echo "5: Either no user with name, or more than one"; //eror code #5 - number of matching != 1
		exit();
	}

	// get login info from query

	$existinginfo = mysqli_fetch_assoc($namecheck);
	$salt = $existinginfo["salt"];
	$hash = $existinginfo["hash"];


	$loginhash = crypt($password, $salt);


	if ($hash != $loginhash)
	{
				echo "6: Inncorect password"; // error code #6 - password does not hash to match table
		exit();
	}

	echo "0\t" . $existinginfo["score"];



?>