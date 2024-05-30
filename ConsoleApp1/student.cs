namespace ConsoleApp1
{
    public class student
    {
         
        private static int Count = 0;
        public string Fullname { get; set; }
        public double Point { get; set; }

        public static int _id;
        public int Id { get; set; }

        static Student()
        {
            Count = 0;
        }
        public Student(string email, string password)
        {
            Count++;
            Id = Count;
        }


        public void StudentInfo()
        {
            Console.WriteLine($"ID: {Id}, Fullname: {Fullname}, Point: {Point}");
        }
    }
}

    

