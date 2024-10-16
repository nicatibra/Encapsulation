namespace Encapsulation.Models
{
    class Phone : Product
    {
        private int _ram;
        private string _color;
        private double _balance;
        public int Ram
        {
            get { return _ram; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Ram cant be neagtive.");
                    _ram = 0;
                }
                else
                {
                    _ram = value;
                };
            }
        }

        public string Color
        {
            get
            { return _color; }
            set
            { _color = value; }
        }

        public double Balance
        {
            get
            { return _balance; }

            set
            { _balance = value; }
        }

        public Phone(string brandName, string model, decimal price, decimal cost, int count, int ram, string color = "Black")
        : base(brandName, model, price, cost, count)
        {
            Ram = ram;
            Color = color;
            Balance = 0;
        }

        public void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Ram: {Ram}\nColor: {Color}\nBalance: {Balance}\n");
        }

        public void Call(int seconds)
        {
            if (Balance > seconds * 0.1)
            {
                Balance -= seconds * 0.1;
                Console.WriteLine($"Call successful! Duration: {seconds} seconds.");
            }
            else
            {
                Console.WriteLine("Not enough balance!");
            }
        }

        public void Pay(double money)
        {
            if (money > 0)
            {
                Balance += money;
                Console.WriteLine($"Payment successful! New Balance: {Balance}\n");
            }
            else
            {
                Console.WriteLine("Payment must be greater than zero.");
            }
        }
    }
}
