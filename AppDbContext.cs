using AvaloniaApplication12.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AvaloniaApplication12;

public class AppDbContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string appFolder = Path.Combine(appData, "David and Tagir");
        Directory.CreateDirectory(appFolder);
        string path = Path.Combine(appFolder, "app.db");
        optionsBuilder.UseSqlite($"Data Source={path}");
    }
}
