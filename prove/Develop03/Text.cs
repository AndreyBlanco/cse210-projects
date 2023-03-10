using System.Collections.Generic;
using System.IO;

public class Text
{
    private string _textName = "";

    public Text()
    {
        _textName = "lds-scriptures.txt";
    }
    
    public Text(string namefile)
    {
        _textName = namefile;

    }

    public string LoadScripture(string book, string chapter, string verse)
    {
        string[] lines = System.IO.File.ReadAllLines(_textName);
        string text = "";
        
        foreach (string line in lines)
        {
            string[] books = line.Split("°", 2);
            string[] chapters = books[1].Split("°", 2);
            string[] verses = chapters[1].Split("°", 2);
            
            if (books[0] == book && chapters[0] == chapter && verses[0] == verse) {
                    text = verses[1];
                    break;
            }
        }

        return text;        
    }
}