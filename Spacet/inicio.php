<?php
    
    //====================================
    // Inicio
    //====================================

    //verificar a sessão
    if(!isset($_SESSION['a'])){
        exit();
    }
?>
<div class="container-fluid pad-20">
    <div class="text-center">
        <a href="?a=setup" class="btn btn-secondary">Setup</a>   
    </div>
</div>