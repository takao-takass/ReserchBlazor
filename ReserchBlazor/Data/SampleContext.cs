using Microsoft.EntityFrameworkCore;
using ReserchBlazor.Data.Tables;

namespace ReserchBlazor.Data;

public class SampleContext : DbContext
{
    public SampleContext(DbContextOptions<SampleContext> options)
        : base(options)
    { }

    public DbSet<Sample> Samples { get; set; }

    public DbSet<Expense> Expenses {  get; set; }
}