<?php

            $db = mysqli_connect('localhost', 'root', '', 'registration');

            $products = mysqli_query($db, "SELECT * FROM `progress`");

            $products = mysqli_fetch_all($products);
            if ($product[0] = 1)
            foreach ($products as $product) {
              echo $product[1];
            }
?>
