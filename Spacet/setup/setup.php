<?php
    
    //====================================
    // setup
    //====================================

    //verificar a sessão
    if(!isset($_SESSION['a'])){
        exit();
    }

    $a = '';
    if(isset($_GET['a'])){
        $a = $_GET['a'];
    }

    //rout do setup
    switch($a){
        case 'setup_new_bd': 
            include('setup/setup_new_bd.php');
            break;
    }
?>
<div class="container-fluid pad-20">
    <h2 class="text-center">SETUP</h2>
    <div class="text-center">
        <p><a href="?a=setup_new_bd" class="btn btn-secondary btn-size-250">Criar BD</a></p>
        <p><a href="?a=setup_new_bd" class="btn btn-secondary btn-size-250">Inserir usuários</a></p>
        <hr>
        <p><a href="?a=inicio" class="btn btn-secondary btn-size-150">Voltar</a></p>
    </div>
</div>