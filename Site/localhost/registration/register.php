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
    <p style="color:#60bf8e">REGISTER</p>
    </div>

  <form method="post" action="register.php">

  	<div class="input-group">
  	  <label>Логин</label>
  	  <input type="text" name="username" value="<?php echo $username; ?>">
  	</div>

  	<div class="input-group">
  	  <label>Пароль</label>
  	  <input type="password" name="password_1">
  	</div>

  	  <button type="submit" class="btn" name="reg_user">Зарегистрироваться</button>
      <p style="color: white; font-size: 2vh; margin-left:1vh;">
    		Уже есть аккаунт? - <a style="color: white; text-decoration:none;" href="login.php">Войти</a>
    	</p>
      </form>
  	</div>

</body>
</html>
