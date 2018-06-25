'use strict';
let input = ["32656 19759 32763 0 5 0 80 101 115 104 111 0 0 0 0 0 0 0 0 0 0 0",
    "0 32656 19759 32763 0 7 0 83 111 102 116 117 110 105 0 0 0 0 0 0 0 0",
    "Visual Studio crash"];

function result(input) {
    let text = "";

    for (let line of input) {
        text += line + " ";
    }
    let words = text.split(' ');
    for (let i = 0; i < words.length; i++) {
        if (words[i] === "32656" && words[i + 1] === "19759" && words[i + 2] === "32763") {
            let length = +words[i + 4];
            let word = "";
            for (let j = 0; j < length; j++) {
                word += String.fromCharCode(+words[i + 6 + j]);
            }
            console.log(word);
            word = "";
        }
    }
}

result(input);