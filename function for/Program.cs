//Дан текст. В тексте нужно заменить все пробелы на черточки, 
//маленькие буквы "k" заменить большими "K", а большие "C" заменить
//маленькими "c".
string text = "- я думаю, сказал князь, улыбаясь, что, "
            + " ежели бы вы послали вместо нашего милого друга,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. вы дадите мне чаю?";
// string s = "qwerty"
//             012
// s[3] // r
string Replay(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int lengch = text.Length;
    for(int i = 0;i < lengch; i++){
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replay(text, ' ','|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replay(newText, 'c', 'C');
Console.WriteLine(newText);

