<?php

    $host = "dpg-d89gp46gvqtc73bvp750-a.frankfurt-postgres.render.com";
    $dbname = "penzugyi_nyilvantarto";
    $user = "penzugyi_nyilvantarto_user";
    $password = "Z2OhgBKjVxYTxpV8aYHowMRTxPSzpovm";
    $sslmode = "require";

    try{
        $db = new PDO("pgsql:host=$host; dbname=$dbname; sslmode=$sslmode", $user, $password);
        $db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    }
    catch (PDOException $e){
        echo "Connection failed: " . $e->getMessage();
    }

?>