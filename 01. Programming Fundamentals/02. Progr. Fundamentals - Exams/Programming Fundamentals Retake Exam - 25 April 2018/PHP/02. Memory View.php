<?php
$input = readline();

$text = "";

while ($input != "Visual Studio crash") {
    $text .= $input . " ";
    $input = readline();
}

$words = explode(' ',$text);
for ($i = 0; $i < count($words); $i++) {
    if ($words[$i] == "32656" && $words[$i + 1] == "19759" && $words[$i + 2] == "32763") {
        $length = (int)($words[$i + 4]);
        $word = "";
        for ($j = 0; $j < $length; $j++) {
            $word .= chr((int)($words[$i + 6 + $j]));
                }
        echo($word) . PHP_EOL;
        $word = "";
    }
}
?>