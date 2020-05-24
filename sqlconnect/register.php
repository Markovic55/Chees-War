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

	$namecheckquery = "SELECT username FROM players WHERE username='" . $username . "';";

	$namecheck = mysqli_query($con, $namecheckquery) or die("2: Name check query failed"); // error code #2 - name check query failed

	if(mysqli_num_rows($namecheck)>0)
	{
		echo "3: Name already exists"; // error code #3 - name exists cannot register
		exit();
	}

	//add user to the table
	$salt = "\$6\$rounds=6000\$" . "steamedhams" . $username . "\$";
	$hash = crypt($password, $salt);
	$insertuserquery = "INSERT INTO players (username, hash, salt) VALUES ('" . $username . "', '" .$hash . "', '" . $salt . "');";
	mysqli_query($con, $insertuserquery) or die("4: Insert player query failed"); // error code #4 - insert qeury failed


	echo("0"); 

?>