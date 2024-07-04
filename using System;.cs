using System;
using System.Collections.Generic;
using System.Linq;

// Genre class
public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; }
}

// Book class
public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal SalePrice { get; set; }
    public decimal CostPrice { get; set; }
    public int GenreId { get; set; }  // Foreign key for Genre
}

// Repository for managing genres and books
public class LibraryRepository
{
    private List<Genre> genres;
    private List<Book> books;
    private int nextGenreId;
    private int nextBookId;

    public LibraryRepository()
    {
        genres = new List<Genre>();
        books = new List<Book>();
        nextGenreId = 1;
        nextBookId = 1;
    }

    // Genre CRUD operations

    // Create a new genre
    public Genre CreateGenre(string name)
    {
        Genre newGenre = new Genre
        {
            Id = nextGenreId++,
            Name = name
        };
        genres.Add(newGenre);
        return newGenre;
    }

    // Get a genre by Id
    public Genre GetGenreById(int id)
    {
        return genres.FirstOrDefault(g => g.Id == id);
    }

    // Get all genres
    public List<Genre> GetAllGenres()
    {
        return genres;
    }

    // Update a genre
    public Genre UpdateGenre(int id, string newName)
    {
        Genre genreToUpdate = genres.FirstOrDefault(g => g.Id == id);
        if (genreToUpdate != null)
        {
            genreToUpdate.Name = newName;
        }
        return genreToUpdate;
    }

    // Delete a genre
    public bool DeleteGenre(int id)
    {
        Genre genreToDelete = genres.FirstOrDefault(g => g.Id == id);
        if (genreToDelete != null)
        {
            genres.Remove(genreToDelete);
            // Also delete associated books
            books.RemoveAll(b => b.GenreId == id);
            return true;
        }
        return false;
    }

    // Book CRUD operations

    // Create a new book
    public Book CreateBook(string name, decimal salePrice, decimal costPrice, int genreId)
    {
        Book newBook = new Book
        {
            Id = nextBookId++,
            Name = name,
            SalePrice = salePrice,
            CostPrice = costPrice,
            GenreId = genreId
        };
        books.Add(newBook);
        return newBook;
    }

    // Get a book by Id
    public Book GetBookById(int id)
    {
        return books.FirstOrDefault(b => b.Id == id);
    }

    // Get all books
    public List<Book> GetAllBooks()
    {
        return books;
    }

    // Update a book
    public Book UpdateBook(int id, string newName, decimal newSalePrice, decimal newCostPrice)
    {
        Book bookToUpdate = books.FirstOrDefault(b => b.Id == id);
        if (bookToUpdate != null)
        {
            bookToUpdate.Name = newName;
            bookToUpdate.SalePrice = newSalePrice;
            bookToUpdate.CostPrice = newCostPrice;
        }
        return bookToUpdate;
    }

    // Delete a book
    public bool DeleteBook(int id)
    {
        Book bookToDelete = books.FirstOrDefault(b => b.Id == id);
        if (bookToDelete != null)
        {
            books.Remove(bookToDelete);
            return true;
        }
        return false;
    }
}

// Example usage
class Program
{
    static void Main(string[] args)
    {
        LibraryRepository repository = new LibraryRepository();

        // Create genres
        Genre fiction = repository.CreateGenre("Fiction");
        Genre nonFiction = repository.CreateGenre("Non-Fiction");

        // Create books
        Book book1 = repository.CreateBook("Book 1", 20.0m, 10.0m, fiction.Id);
        Book book2 = repository.CreateBook("Book 2", 25.0m, 12.5m, nonFiction.Id);

        // Display all genres and books
        Console.WriteLine("All Genres:");
        foreach (var genre in repository.GetAllGenres())
        {
            Console.WriteLine($"Id: {genre.Id}, Name: {genre.Name}");
        }

        Console.WriteLine("\nAll Books:");
        foreach (var book in repository.GetAllBooks())
        {
            Console.WriteLine($"Id: {book.Id}, Name: {book.Name}, SalePrice: {book.SalePrice}, CostPrice: {book.CostPrice}");
        }

        // Update a genre
        Genre updatedGenre = repository.UpdateGenre(fiction.Id, "Updated Fiction");
        if (updatedGenre != null)
        {
            Console.WriteLine($"\nUpdated Genre - Id: {updatedGenre.Id}, Name: {updatedGenre.Name}");
        }

        // Delete a book
        bool deleted = repository.DeleteBook(book2.Id);
        if (deleted)
        {
            Console.WriteLine($"\nBook with Id {book2.Id} deleted successfully.");
        }
        else
        {
            Console.WriteLine($"\nBook with Id {book2.Id} not found.");
        }
    }
}
