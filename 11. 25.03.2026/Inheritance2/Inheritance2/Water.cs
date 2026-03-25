namespace Inheritance2
{
    internal class Water
    {
        public bool Flow;
        public string Lenght;

        //siin on DoSomething meetod, mida siis viidatakse River classi all
        //see võib olla virtual ja ei pea panema override kuna teda kirjutatakse üle
        public virtual void DoSomething()
        {
            Console.WriteLine("Do Something method water");
        }
    }
}
