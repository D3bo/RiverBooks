using Microsoft.Extensions.DependencyInjection;

namespace RiverBooks.Books;

public static class BookServiceExtensions
{
    public static IServiceCollection AddBookService(this IServiceCollection services)
    {
        services.AddSingleton<IBookService, BookService>();
        return services;
    }
}