public class Circle : Shapes
{
    private float _radius;

    public Circle(string color, float radius) : base(color)
    {
        _radius = radius;
    }

    public override float GetArea()
    {
        float sq = (float)Math.PI * _radius * _radius;
        return sq;
    }
}