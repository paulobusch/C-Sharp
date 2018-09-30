<?php
    
    //====================================
    // routes
    //====================================

    //verificar a sessão
    if(!isset($_SESSION['a'])){
        exit();
    }

    $a = 'inicio';

    if(isset($_GET['a'])){
        $a = $_GET['a'];
    }


    //====================================
    // routes
    //====================================
    switch($a){
        case 'inicio':                      include_once('inicio.php'); break;
        case 'about':                      include_once('about.php'); break;
        case 'setup':                      include_once('setup/setup.php'); break;
            
        //=============================================
        //SETUP
        case 'setup_new_bd':                      include_once('setup/setup.php'); break;
    }
?>