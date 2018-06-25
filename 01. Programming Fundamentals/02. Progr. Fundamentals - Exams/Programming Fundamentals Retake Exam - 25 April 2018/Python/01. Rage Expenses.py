import math

lostGamesCount = int(input())
headsetPrice = float(input())
mousePrice = float(input())
keyboardPrice = float(input())
displayPrice = float(input())

headsets = math.floor(lostGamesCount / 2)
mouses = math.floor(lostGamesCount / 3)
keyboards = math.floor(lostGamesCount / 3 / 2)
displays = math.floor(keyboards / 2)

expenses = headsets*headsetPrice+mouses*mousePrice+keyboards*keyboardPrice+displays*displayPrice

print(f"Rage expenses: {expenses:.2f} lv.")