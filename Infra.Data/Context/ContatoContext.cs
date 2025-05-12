using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Domain.Entity;

namespace Infra.Data.Context;

public class ContatoContext : DbContext
{
    public ContatoContext(DbContextOptions<ContatoContext> options) : base(options) {}

    public DbSet<Contatos> Contatos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
     
    }
} 
