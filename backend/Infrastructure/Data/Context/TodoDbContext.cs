using FagdagAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FagdagAPI.Infrastructure.Data.Context;

public class TodoDbContext(DbContextOptions<TodoDbContext> options) : DbContext(options)
{
    public DbSet<Todo> Todos => Set<Todo>();
}