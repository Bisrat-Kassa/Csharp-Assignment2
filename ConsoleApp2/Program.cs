namespace ConsoleApp2
{
    class lab3
    {
        private string _name;
        //
        public string name
        {
           get => _name;
            set => _name = value;
        }
        public int age { get; set; }    
    }
   
    
    internal class Program
    {
        static void Main(string[] args)
        {
            lab3 lb=new lab3();
            lb.name = "BISRAT";
            Console.WriteLine(lb.name);
            lb.age = 10;
        }
    }
}