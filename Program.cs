using EFCoreAssignment01.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAssignment01
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
           using BookStoreDbContext context = new BookStoreDbContext();
            await context.Database.MigrateAsync(); //Apply migration
            Console.WriteLine("Database created succesfully");
        }
    }
}
