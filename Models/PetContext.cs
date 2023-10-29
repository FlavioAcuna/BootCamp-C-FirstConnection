using Microsoft.EntityFrameworkCore;

namespace FirstConnection.Models;

public class PetContext : DbContext
{
    public PetContext(DbContextOptions options) : base(options) { }

    public DbSet<Pet> Pets { get; set; }

}