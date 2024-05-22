namespace _23._05_Task_1
{
    internal class _Book
    {
        private string genre;
        private int ıd;
        private string name;
        private double price;
        private string Book;

        private string GetGenre()
        {
            return Book;
        }

        private void SetGenre(string value)
        {
            genre = value;
        }

        public _Book(
            int count,
            int ıd,
            string name,
            double price) : this(ıd, name, price)
        {
            SetGenre(name);
        }

        public _Book(int ıd, string name, double price, string genre) : this(ıd, name, price) => SetGenre(genre);

        public _Book(int ıd, string name, double price)
        {
            this.ıd = ıd;
            this.name = name;
            this.price = price;
        }
    }
}
