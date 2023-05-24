using Microsoft.EntityFrameworkCore;
using NumbersInEnglish.Models;
using System;
using System.IO;
using Xamarin.Forms;

namespace NumbersInEnglish.ApplicationContextDB
{
    public class ApplicationContext_DB : DbContext
    {
        public ApplicationContext_DB()
        {
            SQLitePCL.Batteries_V2.Init();

            this.Database.EnsureCreated();
        }

        private const string DatabaseName = "NumbersInEnglish.db3";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String databasePath;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", DatabaseName);
                    break;

                case Device.Android:
                    databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), DatabaseName);
                    break;

                default:
                    throw new NotImplementedException("Platform not supported");
            }
            optionsBuilder.UseSqlite($"Filename={databasePath}");
        }

        public DbSet<Numbers> Number { get; set; }
    }
}