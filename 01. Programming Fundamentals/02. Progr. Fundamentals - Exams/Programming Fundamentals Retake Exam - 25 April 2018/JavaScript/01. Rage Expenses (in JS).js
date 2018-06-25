'use strict';
let input = [7, 2, 3, 4, 5];

function result(input) {
    let lostGamesCount = +input[0];
    let headsetPrice = +input[1];
    let mousePrice = +input[2];
    let keyboardPrice = +input[3];
    let displayPrice = +input[4];

    let headsets = Math.floor(lostGamesCount / 2);
    let mouses = Math.floor(lostGamesCount / 3);
    let keyboards = Math.floor(lostGamesCount / 3 / 2);
    let displays = Math.floor(keyboards / 2);

    let expenses = headsets * headsetPrice + mousePrice * mouses + keyboards * keyboardPrice + displays * displayPrice;

    console.log(`Rage expenses: ${expenses.toFixed(2)} lv.`);
}

result(input);