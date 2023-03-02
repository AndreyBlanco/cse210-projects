using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
/*using Newtonsoft.Json.Linq;*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square square = new Square("red", 4);
        Rectangle rec = new Rectangle("blue", 2, 3);
        Circle cir = new Circle("green", 2);

        List<Shapes> shapes = new List<Shapes>();

        shapes.Add(square);
        shapes.Add(rec);
        shapes.Add(cir);

        foreach (Shapes shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
    
}