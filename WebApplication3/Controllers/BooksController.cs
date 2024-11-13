using Microsoft.AspNetCore.Mvc;
using BookApp.Data;
using BookApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly AppDbContext _context;

    public BooksController(AppDbContext context)
    {
        _context = context;
    }

    // Получение всех книг
    [HttpGet]
    public async Task<IEnumerable<Book>> GetBooks()
    {
        return await _context.Books.ToListAsync();
    }

    // Добавление новой книги
    [HttpPost]
    public async Task<IActionResult> AddBook(Book book)
    {
        _context.Books.Add(book);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetBooks), new { id = book.Id }, book);
    }
}
