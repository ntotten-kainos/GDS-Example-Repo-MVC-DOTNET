using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JobApplicationMVCApp.Models;

namespace JobApplicationMVCApp.Data
{
    public class JobApplicationMVCAppContext : DbContext
    {
        public JobApplicationMVCAppContext (DbContextOptions<JobApplicationMVCAppContext> options)
            : base(options)
        {
        }

        public DbSet<JobApplicationMVCApp.Models.JobPosting> JobPosting { get; set; } = default!;
    }
}
