<?php

    //====================================
    // index
    //====================================

    //controle de sessão
    session_start();
    if(!isset($_SESSION['a'])){
        $_SESSION['a'] = 'inicio';
    }

    include_once('inc/gestorBD.php');

    include_once('_cabecalho.php');

    include_once('routes.php');

    include_once('_rodape.php');
?>