code = input()
text = ""

while code != "Visual Studio crash":
    text += code + " "
    code = input()

words = text.split(' ')
for i in range (0, len(words)):
    if (words[i] == "32656" and words[i + 1] == "19759" and words[i + 2] == "32763"):
        length = int(words[i + 4])
        word = ""
        for j in range (0, length):
            word += chr(int(words[i+6+j]))
        print(word)
        word = ""