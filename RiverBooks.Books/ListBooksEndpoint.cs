using Microsoft.AspNetCore.Builder;
using System.Security.Cryptography.X509Certificates;
using FastEndpoints;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RiverBooks.Books;



internal class ListBooksEndpoint(IBookService bookService) : EndpointWithoutRequest<ListBooksResponse>
{
    private readonly IBookService bookService = bookService;

    public override void Configure()
    {
        Get("/books");
        AllowAnonymous();
    }

    public override async  Task HandleAsync(CancellationToken cancellationToken = default)
    {
       var books = bookService.ListBooks();

        await SendAsync(new ListBooksResponse { Books = books }, cancellation: cancellationToken);
    }
}