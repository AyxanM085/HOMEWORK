namespace ConsoleApp26
{
    internal class book
    {
        public class Book
        {
            private static int _bookCounter = 0;

            public string Name { get; private set; }

            public string AuthorName { get; private set; }

            public int PageCount { get; private set; }

            public string Code { get; private set; }

            public Book(string name, string authorName, int pageCount)
            {
                Name = name;
                AuthorName = authorName;
                PageCount = pageCount;


                _bookCounter++;
                Code = CreateCode();
            }
            private string CreateCode()
            {
                return $"{Name[0].ToString().ToUpper()}{Name[1].ToString().ToUpper()}{_bookCounter}";
            }
        }
    }
}

