using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readingPassion.Services
{
    public class ReaderContext : DbContext
    {
        public DbSet<Book> books {  get; set; }

        public ReaderContext()
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "reader.sqlite");
            options.UseSqlite($"Filename={dbPath}");
        }
    }
}
