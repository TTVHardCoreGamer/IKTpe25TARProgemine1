namespace LinqTakeSkip
{
    public class PeopleList
    {
        public static readonly List<People> peoples = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Moona",
                Age = 31,
                GenderId = Guid.Parse("63a694f3-e80e-4df2-af2e-f35c5d973105")
            },
            new People()
            {
                Id = 2,
                Name = "Joonas",
                Age = 21,
                GenderId = Guid.Parse("bdf2fa86-d8dd-4548-bc98-3f15907b8e55")
            },
            new People()
            {
                Id = 3,
                Name = "Ron",
                Age = 15,
                GenderId = Guid.Parse("bdf2fa86-d8dd-4548-bc98-3f15907b8e55")
            },
            new People()
            {
                Id = 4,
                Name = "Anna",
                Age = 20,
                GenderId = Guid.Parse("63a694f3-e80e-4df2-af2e-f35c5d973105")
            },
            new People()
            {
                Id = 5,
                Name = "Mari",
                Age = 19,
                GenderId = Guid.Parse("63a694f3-e80e-4df2-af2e-f35c5d973105")
            },
            new People()
            {
                Id = 6,
                Name = "Mari",
                Age = 21,
                GenderId = Guid.Parse("63a694f3-e80e-4df2-af2e-f35c5d973105")
            },
            new People()
            {
                Id = 7,
                Name = "Bill",
                Age = 21,
                GenderId = Guid.Parse("bdf2fa86-d8dd-4548-bc98-3f15907b8e55")
            }
        };
    }
}


