using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public Context(DbContextOptions options) : base(options)
    {

    }

    DbSet<Meeting> Meetings { get; set; }
}