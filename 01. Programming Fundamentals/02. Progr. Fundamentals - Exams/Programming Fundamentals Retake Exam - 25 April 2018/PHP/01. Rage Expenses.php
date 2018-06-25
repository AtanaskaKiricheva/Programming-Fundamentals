<?php
    $lostGamesCount = readline();
    $headsetPrice = readline();
    $mousePrice = readline();
    $keyboardPrice = readline();
    $displayPrice = readline();

    $headsets = floor($lostGamesCount / 2);
    $mouses = floor($lostGamesCount / 3);
    $keyboards = floor($lostGamesCount / 3 / 2);
    $displays = floor($keyboards / 2);

    $expenses = $headsets * $headsetPrice + $mousePrice * $mouses + $keyboards * $keyboardPrice + $displays * $displayPrice;

    echo 'Rage expenses: ',number_format($expenses,2,'.',''),' lv.';
?>