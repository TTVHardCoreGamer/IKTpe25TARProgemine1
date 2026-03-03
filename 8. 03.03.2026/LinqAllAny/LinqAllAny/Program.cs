namespace LinqAllAny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello LINQ");
            Console.WriteLine("1. All");
            Console.WriteLine("2. Any");
            Console.WriteLine("3. Join");


            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AllLinq();
                    break;

                case 2:
                    AnyLinq();
                    break;

                case 3:
                    JoinLinq();
                    break;
                    
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }

        public static void AllLinq()
        {
            //kasutate All
            //kontrollite, kas on vanemaid, kui 12 ja nooremaid kui 20
            bool result = StudentData.students
                .All(x => x.Age > 12 && x.Age < 20);
           
            Console.WriteLine(result);
        }

        //teeme uue meetodi nimega AnyLinq
        //Kasutada Any-t
        //vastus on true
        public static void AnyLinq()
        {
            bool result = StudentData.students
                .Any(x => x.Age > 12 && x.Age < 20);
            
            Console.WriteLine(result);
        }

        //teha meetod nimega JoinLinq
        //kasutada Join-i
        public static void JoinLinq()
        {
            var innerjoin = StudentData.students
                .Join
                (
                StandardData.standards,
                students => students.StandardId,
                standardId => standardId.StandardId,
                (students, standardId) => new
                {
                    Name = students.Name,
                    StandardId = standardId.StandardId,
                }
            );
               
            foreach (var item in innerjoin)
            {
                Console.WriteLine("{0} - {1}", item.Name, item.StandardId);
            }
        }
    }
}
