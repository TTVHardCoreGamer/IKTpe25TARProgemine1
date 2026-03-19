//using InheritanceAndServiceClass.Core.ServiceInterface;

using InheritanceAndServiceClass.Core.ServiceInterface;

namespace InheritanceAndServiceClass.AppService.Services
{
    public class CarServices : ICarServices
    {
        public void GetData()
        {
            Console.WriteLine("Car Services 123");
        }
    }
}
