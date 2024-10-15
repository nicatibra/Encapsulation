namespace Encapsulation.Models
{
    public class Product
    {
        public string _id;
        public string _brandName;
        public string _model;
        public decimal _price;
        public decimal _cost;
        public decimal _income = 0;
        public int _count;

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
        public decimal Cost
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
            set { _count = value < 0 ? 0 : value; }
        }
        public Product(string brandname, string model, decimal price, decimal cost, int count)
        {
            _brandName = brandname;
            _model = model;
            _price = price;
            _cost = cost;
            _count = count;

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
