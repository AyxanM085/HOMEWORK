namespace _23._05_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        { } 
              private double _price;
        private int _count;
        private int _id;

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price
        {
            get => _price;
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }

        }


        public Program(
            int count,
            int ıd,
            string name,
            double price)
        {
            _count = count;
            _id = Id;
            Name = name;
            _price = price;
        }

    }
}

