using System.Collections.Generic;

public class Scripture
{
    private List<string> _scriptureReference = new List<string>();
    private List<Word> _wordList = new List<Word>();
    private List<int> remainWords = new List<int>();
    
    public Scripture(List<string> refer, string text)
    {
        _scriptureReference = refer;
        string[] words = text.Split(" ");
        int index = 0;

        foreach (String word in words)
        {
            Word scriptureWord = new Word(word);
            _wordList.Add(scriptureWord);
            remainWords.Add(index);
            index ++;
        } 
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine("Welcome to Scripture Memorizer Program");
        Console.WriteLine("");        
        Console.Write($"{_scriptureReference[0]} {_scriptureReference[1]}:{_scriptureReference[2]} ");        
        
        foreach (Word word in _wordList)
        {
            word.Display();
        }
        Console.WriteLine("");
    }

    public void SelectWords()
    {
        remainWords.Clear();
        int index = 0;
        foreach (Word word in _wordList)
        {            
            if (word.FirstChar())
            {
                remainWords.Add(index);
            }
            index ++;
        } 
        Random randomIndex = new Random();
        int Index = randomIndex.Next(remainWords.Count);
        _wordList[remainWords[Index]].HideWord();           
    }

    public int RemainWords()
    {
        int remain = remainWords.Count;

        return remain;
    }
}

