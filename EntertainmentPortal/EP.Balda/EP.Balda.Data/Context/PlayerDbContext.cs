﻿using EP.Balda.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EP.Balda.Data.Context
{
    public class PlayerDbContext : DbContext
    {
        public PlayerDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<PlayerDb> Players { get; set; }
    }
}