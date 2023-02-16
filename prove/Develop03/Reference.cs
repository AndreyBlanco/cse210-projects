using System.Collections.Generic;
using System.IO;

public class Reference
{
    private string _book = "";
    private string _chapter = "";
    private string _verse = "";
    private string _scripture = "";
    private List<string> _reference = new List<string>();
    private Text _text = new Text();

    public Reference()
    {
        
        string[] bookList = System.IO.File.ReadAllLines("books.txt");
        while (_scripture == "")
        {
            
            Console.Write("BOOK LIST: | ");
            foreach (string line in bookList)
            {
                Console.Write($"{line}  ||  ");
            } 
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Please enter the book: ");
            _book = Console.ReadLine();
            Console.Write("Please enter the chapter: ");
            _chapter = Console.ReadLine();
            Console.Write("Please enter the verse: ");
            _verse = Console.ReadLine();
            _scripture = _text.LoadScripture(_book, _chapter, _verse);

            if (_scripture == "")
            {
                Console.WriteLine("This reference doesn't exist, please check and try again");
            }
        }
        _reference.Add(_book);
        _reference.Add(_chapter);
        _reference.Add(_verse);
    }

    public Reference(string book, string chapter, string verse, string scripture)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _scripture = scripture;

        _reference.Add(_book);
        _reference.Add(_chapter);
        _reference.Add(_verse);
    }
    
    public List<string> SendReference()
    {
        List<string> sendReference = new List<string>();

        sendReference = _reference;     
        
        return sendReference;
    }

    public string SendText()
    {
        string text = _scripture;

        return text;
    }
}