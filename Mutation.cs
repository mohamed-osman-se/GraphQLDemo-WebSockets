using GraphQLDemo.Models;
using HotChocolate.Subscriptions;

public class Mutation
{
    public async Task<Book> AddBook(BookDTO input, [Service] AppDbContext context, [Service] ITopicEventSender eventSender)
    {
        var book = new Book { Title = input.Title, AuthorId = input.AuthorId };
        context.Add(book);
        await context.SaveChangesAsync();

        await eventSender.SendAsync(nameof(Subscription.BookAdded), book);

        return book;
    }
}
