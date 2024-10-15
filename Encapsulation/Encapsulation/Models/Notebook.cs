namespace Encapsulation.Models
{
    public class Notebook : Product
    {
        public string _opSystem;
        public string _processor;
        public bool _hasGraphicCard;

        public string OpSystem { get { return _opSystem; } set { _opSystem = value; } }
        public string Processor { get { return _processor; } set { _processor = value; } }

        public bool HasGraphicCard
        {
            get { return _hasGraphicCard; }
            set
            {
                _hasGraphicCard = value;
            }
        }

        public Notebook(string brandname, string model, decimal price, decimal cost, int count, string opsys, string proc) : base(brandname, model, price, cost, count)
        {
            _opSystem = opsys;
            _processor = proc;
        }
        public Notebook(string brandname, string model, decimal price, decimal cost, int count, string opsys, string proc, bool hasgraphiccard) : base(brandname, model, price, cost, count)
        {
            _opSystem = opsys;
            _processor = proc;
            _hasGraphicCard = hasgraphiccard;
        }

        public void GetInfo()
        {
            base.GetInfo();
            if (HasGraphicCard)
            {
                Console.WriteLine("Your notebook has Graphic Card.");
            }
            else
            {
                Console.WriteLine("Your notebook doesnt have Graphic Card.");
            }

            Console.WriteLine($"OpSystem: {OpSystem}\nProcessor: {Processor}\n");
        }
    }
}
