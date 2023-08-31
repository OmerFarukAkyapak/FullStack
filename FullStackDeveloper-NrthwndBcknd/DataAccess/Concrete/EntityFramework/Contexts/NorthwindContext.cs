﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.Concrete.EntityFramework.Contexts
{
    //Nesneler ve veritabani arasindaki iliskiyi kuran nesne
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");

        }

        public DbSet<Product> Products { get; set; }

    }
}