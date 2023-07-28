using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ubac_asp.Models;

    public class User
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
}

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
    : base(options)
    {
    }

    public DbSet<User> TodoItems { get; set; } = null!;
}