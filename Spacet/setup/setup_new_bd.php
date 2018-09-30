<?php
    
    //====================================
    // setup
    //====================================

    //verificar a sessão
    if(!isset($_SESSION['a'])){
        exit();
    }

    //=====================================
    $gestor = new cl_gestorBD();

    $config = include('inc/config.php');

    //apagar a base de dados se existir
    $gestor->EXE_NON_QUERY('DROP DATABASE IF EXISTS '.$config['BD_DATABASE']);

    //cria a nova base de dados
    $gestor->EXE_NON_QUERY('CREATE DATABASE '.$config['BD_DATABASE'].' CHARACTER SET UTF8 COLLATE utf8_general_ci');
    $gestor->EXE_NON_QUERY('USE '.$config['BD_DATABASE']);

    //criação das tabelas
    //usuários
    $gestor->EXE_NON_QUERY(
        'CREATE TABLE users('.
        'id_user            INT UNSIGNED PRIMARY KEY NOT NULL AUTO_INCREMENT,'.
        'usuario            NVARCHAR(50),'.
        'palavra_pass       NVARCHAR(200),'.
        'nome               NVARCHAR(50),'.
        'email              NVARCHAR(50),'.
        'criado_em          DATETIME,'.
        'atualizado         DATETIME)'
    );
?>


<div class="alert alert-success text-center">Base de dados criada com sucesso.</div>