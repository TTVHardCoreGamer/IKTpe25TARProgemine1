namespace LinqTakeSkip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Skip");
            Console.WriteLine("2. SkipWhile");
            Console.WriteLine("3. TakeWhile");
            Console.WriteLine("4. FirstOrDefault");
            Console.WriteLine("5. AverageLinq");
            Console.WriteLine("6. CountLINQ");
            Console.WriteLine("7. Sum");
            Console.WriteLine("8. Max");
            Console.WriteLine("9. Min");
            //siin kasutada switchi ja peab saama Skip meetodit esile kutsuda
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Skip();
                    break;

                case 2:
                    SkipWhile();
                    break;

                case 3:
                    TakeWhile();
                    break;

                case 4:
                    FirstOrDefault();
                    break;

                case 5:
                    AverageLinq();
                    break;

                case 6:
                    CountLINQ();
                    break;

                case 7:
                    Sum();
                    break;

                case 8:
                    Max();
                    break;

                case 9:
                    Min();
                    break;

                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
        }

        public static void Skip()
        {
            Console.WriteLine("----------Skip----------");
            //mis tähendab: => . See tähendab lambda märki
            //kasuta skip ja jäta kolm tükki vahele
            var Skip = PeopleList.peoples.Skip(3);

            foreach (var item in Skip)
            {
                Console.WriteLine(item.Name);
            }
        }

        //teete uue meetodi, aga kasutate SkipWhile ja vanemad, kui 18 peab olema tingimus
        public static void SkipWhile()
        {
            Console.WriteLine("----------SkipWhile----------");
            //kasuta skip ja jäta kolm tükki vahele
            var skipwhile = PeopleList.peoples.SkipWhile(x => x.Age > 18);

            foreach (var item in skipwhile)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Age);
            }
            //SkipWhile jätab loendis nii kaua vahele ridu kuni vastab tingimusele
            //e antud juhul jätab read vahele kuni leiab 18 a isiku ja
            //peale seda hakkab infot jälle kuvama olenemata vanuse tingimusest
        }

        //kasutada TakeWhile ja kutsuda see esile switchis tingimus Age > 18
        public static void TakeWhile()
        {
            Console.WriteLine("----------TakeWhile----------");
            var takewhile = PeopleList.peoples.TakeWhile(x => x.Age > 18);

            foreach (var item in takewhile)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Age);
            }
            //TakeWhile näitab isikuid kuni vastab tingimusele
            //e antud juhul näitab andmeid kuni leaib 18 a isiku ja 
            //peale seda hakkab enam ei nöitab andmeid
        }

        public static void FirstOrDefault()
        {
            //kuvab esimese elemendi, mis järjestuses
            //vastab tingimustele
            Console.WriteLine("----------FirstOrDefault----------");
            string firstLongName = PeopleList.peoples
                .FirstOrDefault(x => x.Name.Length > 5).Name;
            Console.WriteLine("The first long name is '{0}'.", firstLongName);
        }

        //kasutame Average Linq
        public static void AverageLinq()
        {
            Console.WriteLine("----------AverageLinq----------");

            var average = PeopleList.peoples
                .Average(x => x.Age);

            Console.WriteLine("Kõikide keskmine vanus on " + average);
        }

        public static void CountLINQ()
        {
            var totalPersons = PeopleList.peoples.Count();

            Console.WriteLine("Inimesi on kokku: " + totalPersons);
            Console.WriteLine("---------------------------------");

            var adultPerson = PeopleList.peoples.Count(x => x.Age >= 18);
            Console.WriteLine("Täiskasvanud inimesi on kokku: " + adultPerson);
        }

        public static void Sum()
        {
            var sumAge = PeopleList.peoples.Sum(x => x.Age);
            Console.WriteLine("Koondvanus on " + sumAge);

            Console.WriteLine("---------------------------------");

            var sumAdults = 0;
            var numAdults = PeopleList.peoples.Sum(x =>
            {
                if (x.Age >= 18)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });

            Console.WriteLine("Täiskasvanud isikute koondarv " + numAdults);
        }

        public static void Max()
        {
            var oldestPerson = PeopleList.peoples
                .Max(x => x.Age);

            Console.WriteLine("Kõike vanem isik on " + oldestPerson);
        }
        public static void Min()
        {
            var youngestPerson = PeopleList.peoples
               .Min(x => x.Age);

            Console.WriteLine("Kõike noorem isik on " + youngestPerson);
        }
    }
}

