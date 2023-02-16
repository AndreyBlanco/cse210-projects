using System.Collections.Generic;

public class Scripture
{
    private List<string> _scriptureReference = new List<string>();
    private List<Word> _wordList = new List<Word>();
    private List<int> _remainWords = new List<int>();

    public Scripture()
    {
        List<string> refer = new List<string>();
        refer.Add("Moroni");
        refer.Add("7");
        refer.Add("41");

        string text = "And what is it that ye shall hope for? Behold I say unto you that ye shall have hope through the atonement of Christ and the power of his resurrection, to be raised unto life eternal, and this because of your faith in him according to the promise.";

        _scriptureReference = refer;
        string[] words = text.Split(" ");
        int index = 0;

        foreach (String word in words)
        {
            Word scriptureWord = new Word(word);
            _wordList.Add(scriptureWord);
            _remainWords.Add(index);
            index ++;
        } 
    }
    
    public Scripture(List<string> refer, string text)
    {
        _scriptureReference = refer;
        string[] words = text.Split(" ");
        int index = 0;

        foreach (String word in words)
        {
            Word scriptureWord = new Word(word);
            _wordList.Add(scriptureWord);
            _remainWords.Add(index);
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
        _remainWords.Clear();
        int index = 0;
        foreach (Word word in _wordList)
        {            
            if (word.FirstChar())
            {
                _remainWords.Add(index);
            }
            index ++;
        } 
        Random randomIndex = new Random();
        int Index = randomIndex.Next(_remainWords.Count);
        _wordList[_remainWords[Index]].HideWord();           
    }

    public int RemainWords()
    {
        int remain = _remainWords.Count;

        return remain;
    }
}

