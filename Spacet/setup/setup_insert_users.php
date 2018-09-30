<?php
    
    //====================================
    // setup - inserir usuários
    //====================================

    //verificar a sessão
    if(!isset($_SESSION['a'])){
        exit();
    }

    //inserir o administrador
    $gestor = new cl_gestorBD();
        ':usuario' => 'admin',
        
    params[];
?>