using Fagdag.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fagdag.Infrastructure.Data.Context;

public class TodoDbContext(DbContextOptions<TodoDbContext> options) : DbContext(options)
{
    public DbSet<Todo> Todos => Set<Todo>();
}
