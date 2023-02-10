using System.Collections.Generic;
using System.IO;

public class Reference
{
    private string book = "";
    private string chapter = "";
    private string verse = "";
    private string scripture = "";
    private List<string> reference = new List<string>();
    private Text text = new Text();

    public Reference()
    {
        
        string[] bookList = System.IO.File.ReadAllLines("books.txt");
        while (scripture == "")
        {
            
            Console.Write("BOOK LIST: | ");
            foreach (string line in bookList)
            {
                Console.Write($"{line}  ||  ");
            } 
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Please enter the book: ");
            book = Console.ReadLine();
            Console.Write("Please enter the chapter: ");
            chapter = Console.ReadLine();
            Console.Write("Please enter the verse: ");
            verse = Console.ReadLine();
            scripture = text.LoadScripture(book, chapter, verse);

            if (scripture == "")
            {
                Console.WriteLine("This reference doesn't exist, please check and try again");
            }
        }
        reference.Add(book);
        reference.Add(chapter);
        reference.Add(verse);
    }
    
    public List<string> SendReference()
    {
        List<string> sendReference = new List<string>();

        sendReference = reference;     
        
        return sendReference;
    }

    public string SendText()
    {
        string text = scripture;

        return text;
    }
}