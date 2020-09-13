using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TeduAsp.Data.EF
{
    class TeduAspDbContextFactory : IDesignTimeDbContextFactory<TeduAspDbContext>
    {
        public TeduAspDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = configuration.GetConnectionString("TeduAspDb");

            var optionsBuilder = new DbContextOptionsBuilder<TeduAspDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new TeduAspDbContext(optionsBuilder.Options);
        }
    }
}
