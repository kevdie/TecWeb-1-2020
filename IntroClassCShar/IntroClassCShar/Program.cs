using System;

namespace IntroClassCShar
{
    public class Shape
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public virtual void Show()
        {
            //Console.WriteLine(string.Format("my name is {0} shape", name));
            Console.WriteLine($"my name is {Name} shape");
        }
    }
    public class Square:Shape
    {
        public override void Show()
        {
            Console.WriteLine($"im a square {Name}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Shape myShape = new Shape("basic");
            var myShape = new Shape() { Name="obj"};
            myShape.Show();           
            Console.WriteLine("Hello World!");
        }
    }
}
