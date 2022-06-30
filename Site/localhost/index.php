<?php
  session_start();

  if (!isset($_SESSION['username'])) {
    $_SESSION['msg'] = "You must log in first";
    header('location: ../registration/register.php');
  }
  if (isset($_GET['logout'])) {
    session_destroy();
    unset($_SESSION['username']);
    header("location: ../registration/login.php");
  }

              $db = mysqli_connect('localhost', 'root', '', 'registration');

              $progress = mysqli_query($db, "SELECT * FROM `progress`");
              $progress = mysqli_fetch_all($progress);
              foreach ($progress as $p) {}

              $timetable = mysqli_query($db, "SELECT * FROM `timetable`");
              $timetable = mysqli_fetch_all($timetable);
              foreach ($timetable as $t) {}
?>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <meta http-equiv="X-UA-Compatible" content="ie=edge">
  <link rel="preconnect" href="https://fonts.googleapis.com">
  <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
  <link href="https://fonts.googleapis.com/css2?family=Cairo:wght@600&display=swap" rel="stylesheet">
  <link rel="preconnect" href="https://fonts.googleapis.com">
  <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
  <link href="https://fonts.googleapis.com/css2?family=Cairo:wght@600&display=swap" rel="stylesheet">
  <link rel="preconnect" href="https://fonts.googleapis.com">
  <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
  <link href="https://fonts.googleapis.com/css2?family=Play&display=swap" rel="stylesheet">
  <link rel="stylesheet" href="main.css">
  <script type="text/javascript" src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
  <script type="text/javascript" src="script.js"></script>
  <title>RUBICONE</title>
</head>
<body>
    <div class="left">

      <div class="logo">
        <img style="width:8vh;height:8vh;" src="png/logo.png" alt="">
        <p style="  margin-top: -4vh;  font-size: 6vh;">RUBICON</p>
      </div>

      <div class="profile">
        <p class="username"><?php echo $_SESSION['username']; ?></p>
        <div class="avatar"></div>
      </div>

      <div class="menu">
        <p style="margin:2vh;" class="timetableMenu">Расписание</p>
        <p style="margin:2vh;opacity:0.8" class="chatMenu">Чат</p>
      </div>

      <div class="progres">

        <div style="border-radius: 7px; background-image: url(png/фон.png);" class="task">Прогресс</div>
          <div class="line"><progress value="<?php if ($p[0] = $_SESSION['username']) echo $p[1];?>" max="100">
          </progress>
        </div>
      </div>

    </div>


    <div class="header">

      <div class="containH">
        <h style="margin: 2vh;">Новости</h>
        <h style="margin: 2vh;" class="but">+Уведомление</h>
      </div>
      <div class="links">
      </div>

    </div>


    <div class="titel">

      <div class="containT">

        <div class="timetable">
          <div class="day">
            <p><?php if ($t[0] = $_SESSION['username']) echo $t[1];?></p>
            <p style="margin-top:-1vh;">.........................</p>
          </div>
          <div class="lessons">
            <p><?php if ($t[0] = $_SESSION['username']) echo $t[2];?></p>
            <p><?php if ($t[0] = $_SESSION['username']) echo $t[3];?></p>
            <p><?php if ($t[0] = $_SESSION['username']) echo $t[4];?></p>
          </div>
        </div>

        <div style="display:none;" class="chat">
          <input type="text" class="input">
        </div>

      </div>

    </div>


    <div class="lineNotif"></div>



</body>
</html>
