namespace StructProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Struct");

            Coordinate point = new Coordinate(3, 5);
            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);

            Console.WriteLine("-------------------------");
            IntAndString intAndString = new IntAndString();
            Console.WriteLine(intAndString.Age);
            Console.WriteLine(intAndString.Name);

            Console.WriteLine("-------------------------");
            InsertIntAndString insertIntAndString = new InsertIntAndString();
            Console.WriteLine(insertIntAndString.PostalCode);
            Console.WriteLine(insertIntAndString.City);
            
        }
    }

    //Mis on struct???
    struct Coordinate
    {
        public int X;
        public int Y;

        //teha konstruktor
        //See on väärtustüüp (value type), mis sarnaneb klassile
        public Coordinate(int x, int y)
        {
            x = 6;
            y = 9;

            X = x;
            Y = y;
        }
    }

    //teha struct nimega IntAndString
    //string Name ja int on Age
    //kutsuda see struct Mains-is välja

    struct IntAndString
    {
        public string Name;
        public int Age;

        public IntAndString(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    //teha struct nimega InsertIntAndString
    //string City ja int PostalCode
    //kutsuda see stuct Main-is välja
    //structi sees tuleb sellele anda juba väärtus

    struct InsertIntAndString
    {
        public string City;
        public int PostalCode;

        public InsertIntAndString(string city, int postalCode)
        {
            City = "Tallinn";
            PostalCode = 1234;
        }
    }
}
