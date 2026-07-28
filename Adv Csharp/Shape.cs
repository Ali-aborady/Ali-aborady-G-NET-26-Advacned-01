namespace Adv_Csharp
{
    public abstract class Shape
    {
        public string Color { get; set; } = "White";
        public abstract double Area();
        public virtual void Describe()
            => Console.WriteLine($"{GetType().Name} | Color: {Color} | Area: {Area():F2}");
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area() => Math.PI * Radius * Radius;
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area() => Width * Height;
    }

    class ShapeCollection<T> where T : Shape
    {
        private List<T> _shapes = new List<T>();

        public void Add(T shape) => _shapes.Add(shape);

        public double TotalArea()
        {
            double total = 0;
            foreach (T s in _shapes)
                total += s.Area(); 
            return total;
        }

        public void DescribeAll()
        {
            foreach (T s in _shapes)
                s.Describe();
        }
    }
}
