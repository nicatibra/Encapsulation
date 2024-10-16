namespace Encapsulation.Models
{
    public class Product
    {
        private string _id;
        private string _brandName;
        private string _model;
        private decimal _price;
        protected decimal _cost;
        private decimal _income = 0;
        private int _count;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string BrandName
        {
            get { return _brandName; }
            set { _brandName = value; }
        }
        public string Model
        {
            get { return _model; }
            private set { _model = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
        public decimal Income
        {
            get { return _income; }
            set { _income = value; }
        }
        public int Count
        {
            get { return _count; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Count can't be negative. Setting it to 0.");
                    _count = 0;
                }
                else
                {
                    _count = value;
                }
            }
        }
        public Product(string brandname, string model, decimal price, decimal cost, int count)
        {
            BrandName = brandname;
            Model = model;
            Price = price;
            Cost = cost;
            Count = count;

            _id = _brandName.Substring(0, 2) + _model.Substring(0, 2);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Brandname: {BrandName}\nModel: {Model}\nId: {Id}\nPrice: {Price}\nCost: {Cost}\nIncome: {Income}\nCount: {Count}");
        }

        public void Sale(int quantity)
        {
            if (quantity <= Count)
            {
                decimal income = (Price - Cost) * quantity;
                Income += income;
                Count -= quantity;
            }
            else
            {
                Console.WriteLine($"Not enough products.");
            }
        }
    }
}
