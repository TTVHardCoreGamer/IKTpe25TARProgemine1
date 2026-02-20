namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tuleb teha class nimega PeopleList
            //Seal on kuus rida andmeid
            //Kindlasti peab olema kaks Mari nimega isikut,
            //aga erinevate vanustega

            Console.WriteLine("Tee valik numbriga");
            Console.WriteLine("1. ThenByLINQ");
            Console.WriteLine("2. ThenByDescendingLINQ");
            Console.WriteLine("3. SelectLINQ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ThenByLINQ();
                    break;

                case 2:
                    ThenByDescendingLINQ();
                    break;

                case 3:
                    SelectLINQ();
                    break;

                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
        }

        //kutsuda meetod switchis esile
        public static void ThenByLINQ()
        {
            //thenby sorteerib numbrilises järjestuses
            var thenByResult = PeopleList.peoples
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Age);

            Console.WriteLine("ThenBy järgi sorteerimine");
            foreach (var item in thenByResult)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }

        public static void ThenByDescendingLINQ()
        {
            var thenByResult = PeopleList.peoples
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.Age);

            Console.WriteLine("ThenByDescending järgi sorteerimine");
            foreach (var item in thenByResult)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }

        public static void SelectLINQ()
        {
            //select lihtsalt tagastab andmed nii nagu need on andmebaasis
            //sama hea, mis SQL select
            var result = PeopleList.peoples
                .Select(x => new
                { 
                    Name = x.Name, 
                    Age = x.Age,
                });
                
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }
    }
}
