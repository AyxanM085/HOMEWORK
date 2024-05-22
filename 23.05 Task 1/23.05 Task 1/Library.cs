using static System.Reflection.Metadata.BlobBuilder;

namespace _23._05_Task_1
{
    internal class Library
    {
        public Books[] Books = new Books[0];

        internal static void AddBook(Books book2)
        {
            throw new NotImplementedException();
        }

        public void AddBooks(Books books)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = books;
        }
    }   }
