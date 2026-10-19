using Microsoft.EntityFrameworkCore;

public class Tirlea_Mihai_Lab2Context(DbContextOptions<Tirlea_Mihai_Lab2Context> options) : DbContext(options)
{
    public DbSet<Tirlea_Mihai_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Tirlea_Mihai_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Tirlea_Mihai_Lab2.Models.Author> Author { get; set; } = default!;
}
