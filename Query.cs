using Microsoft.EntityFrameworkCore;

public class Query
{

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Author> GetAuthors(AppDbContext context)
    {
        return context.Authors;
    }
}
