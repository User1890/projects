<?php include('server.php') ?>
<!DOCTYPE html>
<html>
<head>
  <link rel="preconnect" href="https://fonts.googleapis.com">
  <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
  <link href="https://fonts.googleapis.com/css2?family=Play&display=swap" rel="stylesheet">
  <link rel="preconnect" href="https://fonts.googleapis.com">
  <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
  <link href="https://fonts.googleapis.com/css2?family=Play&display=swap" rel="stylesheet">
  <title>RUBICONE</title>
  <link rel="stylesheet" href="style.css">
</head>
<body>
  <img src="../png/LOGO.png" alt="">
  <div class="form">

    <div class="header">
    <p style="margin-vottom:-2vh;">RUBICON</p>
    <p style="color:#60bf8e">LOGIN</p>
    </div>

    <form method="post" action="login.php">

    	<div class="input-group">
    		<label>Логин</label>
    		<input type="text" name="username" >
    	</div>

    	<div class="input-group">
    		<label>Пароль</label>
    		<input type="password" name="password">
    	</div>

    	<div class="input-group">
    		<button type="submit" class="btn" name="login_user">Войти</button>
    	</div>

    	<p style="color: white; font-size: 2vh; margin-left:1vh;">
    		Нет аккаунта? - <a href="register.php" style="color: white; text-decoration:none;">Зарегистрироваться</a>
    	</p>

    </form>

  </div>

</body>
</html>
