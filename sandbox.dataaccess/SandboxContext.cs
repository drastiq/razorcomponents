using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using sandbox.core;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace sandbox.dataaccess
{
    public class SandboxContext : DbContext
    {
        public SandboxContext(DbContextOptions<SandboxContext> options)
            : base(options)
        { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameHistory> GameHistories { get; set; }
        public DbSet<Card> Cards { get; set; }

    }
}
