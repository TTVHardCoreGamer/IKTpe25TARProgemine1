namespace Inheritance2
{
    //River on antud juhul alamklass ja viitab Waterile e peamisele classile
    class River : Water
    {
        //kui kirjutan override, siis kirjutab Water meetodis oleva DoSomething meetodi üle
        //kui panen siia publiv birtual void, siis ei kirjuta Water meetodi Dosomethingut üle
        public override void DoSomething()
        {
            //Water classis on olemas muutujad Flow ja Lenght ja
            //selleprärast ei pea neid siin uuseti defineerima
            Console.WriteLine("River method and it has " + Flow + " and " + Lenght + " is in meters ");
        }
    }
}
