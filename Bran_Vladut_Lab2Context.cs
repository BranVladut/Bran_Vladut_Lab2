using Microsoft.EntityFrameworkCore;

public class Bran_Vladut_Lab2Context(DbContextOptions<Bran_Vladut_Lab2Context> options) : DbContext(options)
{
    public DbSet<Bran_Vladut_Lab2.Models.Book> Book { get; set; } = default!;

    public DbSet<Bran_Vladut_Lab2.Models.Publisher> Publisher { get; set; }

    public DbSet<Bran_Vladut_Lab2.Models.Author> Author { get; set; }

    public DbSet<Bran_Vladut_Lab2.Models.Category> Category { get; set; } = default!;

    public DbSet<Bran_Vladut_Lab2.Models.BookCategory> BookCategory { get; set; } = default!;
}