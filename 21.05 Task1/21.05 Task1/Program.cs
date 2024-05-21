namespace _21._05_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                {
                    int[] numbers = { 1, 2, 3 };

                    Array.Resize(ref numbers, 5);

                    Console.WriteLine("array:");
                    foreach (int number in numbers)
                    {
                        Console.WriteLine(number);
                    }

                    Array.Resize(ref numbers, 2);

                    Console.WriteLine("Resized array:");
                    foreach (int number in numbers)
                    {
                        Console.WriteLine(number);
                    }
                }
            }
        }
    }
}
    


