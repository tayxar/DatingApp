using Microsoft.EntityFrameworkCore;
using API.Entities;
using API.Data;
namespace API.Data;
public class DataContext : DbContext{

    public DataContext(DbContextOptions options) : base(options){

    }

    public DbSet<AppUser> Users { get; set; }
    public DbSet<Rating> Rate {get; set;}

    protected override void OnModelCreating(ModelBuilder modelbuilder){

        modelbuilder.Entity<Rating>().HasKey(b => b.rateID);
    }    

}