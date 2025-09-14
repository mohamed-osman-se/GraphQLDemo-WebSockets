using GraphQLDemo.Models;

public class Subscription
{

    [Subscribe]
    public Book BookAdded([EventMessage] Book book) => book;
}