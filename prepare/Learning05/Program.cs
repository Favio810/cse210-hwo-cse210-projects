using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Green", 3.2);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Black", 2, 9);
        shapes.Add(s2);

        Circle s3 = new Circle("Purple", 8);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}