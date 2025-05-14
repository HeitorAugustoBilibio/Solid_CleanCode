using Microsoft.EntityFrameworkCore;
using Domain.Entities;


namespace Infra.Data.Context;

public class ContatoContext : DbContext
{
    public ContatoContext(DbContextOptions<ContatoContext> options) : base(options) {}

    public DbSet<Contatos> Contatos { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
     
    //}
} 
