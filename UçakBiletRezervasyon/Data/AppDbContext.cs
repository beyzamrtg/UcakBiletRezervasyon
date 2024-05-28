﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using UçakBiletRezervasyon.Models;

namespace UçakBiletRezervasyon.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=..\\..\\Data\\UcakBiletiRezervasyonDb.db");
        }

        public DbSet<Ucak> Ucak { get; set; }
        public DbSet<Lokasyon> Lokasyon{ get; set; }
        public DbSet<Rezervasyon> Rezervasyon { get; set; }
    }
}

