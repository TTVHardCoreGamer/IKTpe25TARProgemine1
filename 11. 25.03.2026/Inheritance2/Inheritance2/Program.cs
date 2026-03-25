namespace Inheritance2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance 2");

            //kui siin on Water class, siis kuvatakse seal olevat DoSomething meetodi sisu
            //kui panna Water water = new River();, siis kuvatakse River classis olevast Dosomething
            //meetodi sisu
            Water water = new River();
            water.Flow = true;
            water.Lenght = "123";

            Water water3 = new Lake();
            water.Flow = false;
            water.Lenght = "987";

            //kuidas meetodi esile
            water.DoSomething();
            water3.DoSomething();
        }
    }
}
