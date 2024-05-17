namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string sentence = "Hello World";
                PrintInitials(sentence);
            }

            static void PrintInitials(string input)
            {
                string[] words = input.Split(' ');

                foreach (string word in words)
                {
                    if (!string.IsNullOrEmpty(word))
                    {
                        Console.Write(word[0] + " ");
                    }
                }
            }
        }
    }

}
    
