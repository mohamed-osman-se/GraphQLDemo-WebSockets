using GraphQLDemo.Models;

public static class SeedData
{
    public static void Init(AppDbContext context)
    {
        if (context.Authors.Any()) return;

        var authors = new List<Author>
        {
            new Author { Name = "J.K. Rowling", Books = new List<Book>
            {
                new Book { Title = "Harry Potter and the Philosopher's Stone" },
                new Book { Title = "Harry Potter and the Chamber of Secrets" },
                new Book { Title = "Harry Potter and the Prisoner of Azkaban" }
            }},
            new Author { Name = "George R.R. Martin", Books = new List<Book>
            {
                new Book { Title = "A Game of Thrones" },
                new Book { Title = "A Clash of Kings" },
                new Book { Title = "A Storm of Swords" },
                new Book { Title = "A Feast for Crows" }
            }},
            new Author { Name = "J.R.R. Tolkien", Books = new List<Book>
            {
                new Book { Title = "The Hobbit" },
                new Book { Title = "The Fellowship of the Ring" },
                new Book { Title = "The Two Towers" },
                new Book { Title = "The Return of the King" }
            }},
            new Author { Name = "Agatha Christie", Books = new List<Book>
            {
                new Book { Title = "Murder on the Orient Express" },
                new Book { Title = "And Then There Were None" },
                new Book { Title = "The Murder of Roger Ackroyd" }
            }},
            new Author { Name = "Stephen King", Books = new List<Book>
            {
                new Book { Title = "The Shining" },
                new Book { Title = "It" },
                new Book { Title = "Misery" },
                new Book { Title = "Carrie" }
            }},
            new Author { Name = "Isaac Asimov", Books = new List<Book>
            {
                new Book { Title = "Foundation" },
                new Book { Title = "Foundation and Empire" },
                new Book { Title = "Second Foundation" },
                new Book { Title = "I, Robot" }
            }}
        };

        context.Authors.AddRange(authors);
        context.SaveChanges();
    }
}
