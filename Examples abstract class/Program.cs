
var rectangle = new Rectangle { Height = 20, Wight = 20 };
var circle = new Circle { Radius = 200 };
PrintShape(rectangle);
PrintShape(circle);

void PrintShape(Shape shape)
{
    Console.WriteLine($"Perimetr: {shape.GetPerimetr()}, Area: {shape.GetArea()}");
}

abstract class Shape
{
    public abstract double GetPerimetr();
    public abstract double GetArea();
}

class Rectangle : Shape
{
    public float Wight { get; set; }
    public float Height { get; set; }

    public override double GetPerimetr()
    {
        return Wight * 2 + Height * 2;
    }
    public override double GetArea() => Wight * Height;
}

class Circle : Shape
{
    const double MAGIC_NUMBER = 3.14;
    public double Radius { get; set; }

    public override double GetPerimetr() { return Radius * 2 * MAGIC_NUMBER; }

    public override double GetArea() => Radius * Radius * MAGIC_NUMBER;
}