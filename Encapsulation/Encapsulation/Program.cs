using Encapsulation.Models;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////BrandName,  Model,  Price,Cost,Count,Ram, Color(Optinonal)
            Phone phone1 = new Phone("Apple", "Iphone", 1000, 500, 10, 8);
            phone1.Sale(3);
            phone1.GetInfo();


            phone1.Pay(50);
            phone1.Call(30);
            phone1.GetInfo();

            ///////////////////////BrandName,  Model,  Price,Cost,Count, Ram,OpSystem,  Procssor,HasGraphicCard
            Notebook notebook1 = new Notebook("Asus", "Rog", 3000, 1000, 10, "Windows", "Intel", true);
            notebook1.Sale(1);
            notebook1.GetInfo();
        }
    }
}
