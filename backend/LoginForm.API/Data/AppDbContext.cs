using LoginForm.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginForm.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<User> Users => Set<User>();
}
