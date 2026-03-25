namespace Inheritance2
{
    internal class Lake : Water
    {
        //tehke sama asi, mis Riveriga ja kutsuge see Program classi Main meetodis esile
        public override void DoSomething()
        {
            Console.WriteLine("Lake method and it has " + Flow + " and " + Lenght + " is in meters ");
        }
    }
}
