﻿using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseContext;
using DataBaseContext;

namespace DataBaseContext
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<DB_Context_Class>
    {
        public DB_Context_Class CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DB_Context_Class>();
            string databasePath = Path.Combine("..", "SI2projekat.db");
            optionsBuilder.UseSqlite($"Data Source={databasePath}");

            return new DB_Context_Class(optionsBuilder.Options);
        }
    }
    
}