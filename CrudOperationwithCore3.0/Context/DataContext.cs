using CoreDemo_3_0.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo_3_0.Models;

namespace CoreDemo_3_0.Context
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<CoreDemo_3_0.Models.JobModel> JobModel { get; set; }
    }


}
