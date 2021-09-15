using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmergencyHelpLine.Model;

namespace EmergencyHelpLine.Data
{
    public class EmergencyHelpLineContext : DbContext
    {
        public EmergencyHelpLineContext (DbContextOptions<EmergencyHelpLineContext> options)
            : base(options)
        {
        }

        public DbSet<EmergencyHelpLine.Model.Messages> Messages { get; set; }
    }
}
