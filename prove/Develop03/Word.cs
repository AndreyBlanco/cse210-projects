using System.Collections.Generic;

public class Word
{
    private string _word = "";
    
    public Word(string newWord)
    {
        _word = newWord;
    }

    public void HideWord()
    {
        char _ = char.Parse("_");
        foreach (char letter in _word)
            _word = _word.Replace(letter, _);
    }

    public bool FirstChar()
    {
        char _ = char.Parse("_");
        char fchar = _word[0];
        if (fchar != _) { 
            return true;
        }
        else {
            return false;
        }
    }

    public void Display() 
    {
        Console.Write($"{_word} ");
    }


}