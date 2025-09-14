

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var gql = builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddSubscriptionType<Subscription>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();
gql.AddInMemorySubscriptions();
builder.Services
.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=app.db"));


var app = builder.Build();


app.UseRouting();

app.UseWebSockets();

app.MapGraphQL();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
    SeedData.Init(db);
}


app.Run();
