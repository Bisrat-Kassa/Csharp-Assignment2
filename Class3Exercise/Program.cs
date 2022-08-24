namespace Class3Exercise
{
    abstract class shape{
        public abstract double calculateArea();
        public abstract double parameter();

    };
    class circle : shape {
        readonly double pi = 3.14;
        public double radius { get; set; }
       
       
       public override double calculateArea (){
            return  pi * radius * radius;
            }
        public override double parameter()
        {
           return  2*pi*radius;
        }

    }

    class square : shape
    {
       public double width { get;set;}

        
        public override double calculateArea()
        {
            return width * width;
        }
        public override double parameter()
        {
            return 4*width;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string ans,temp;
            square sq = new square();
            circle circ = new circle();

            do
            {
                Console.Write("Enter the radius of your circle: ");
                // circ.radius = Convert.ToDouble(circ.radius);
                circ.radius = Convert.ToDouble(Console.ReadLine(circ.radius));
                Console.WriteLine("Area of the circle is: " + circ.calculateArea());
                Console.WriteLine("Parameter of the circle is: " + circ.parameter());

                Console.WriteLine("Enter the width of your square: ");
                sq.width = Convert.ToDouble(sq.width);
                Console.WriteLine("Area of the square is: " + sq.calculateArea());
                Console.WriteLine("Parameter of the square is: " + sq.parameter());

                Console.Write("Would you like to continue?(Y?N): ");
                ans = Console.ReadLine();
            } while (ans == "Y" || ans == "y");

            Console.ReadKey();

        }
    }
}