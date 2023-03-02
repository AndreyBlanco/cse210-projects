public class Square : Shapes
{
    private float _side;

    public Square(string color, float side) : base(color)
    {
        _side = side;
    }

    public override float GetArea()
    {
        float sq = _side * _side;
        return sq;
    }
}