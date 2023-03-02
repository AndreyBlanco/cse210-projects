public class Shapes
{
    private string _color = "";

    public Shapes(string color)
    {
        _color = color;
    }

    public virtual float GetArea()
    {
        return 5;
    }

    public string GetColor()
    {
        return _color;
    }
}