using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReadingList.Models;

namespace ReadingList.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<ReadingList.Models.Book> Book { get; set; } = default!;
    public DbSet<ReadingList.Models.List> List { get; set; } = default!;
}