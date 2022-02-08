using CounselingCenter.Api.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CounselingCenter.Api.Data
{
    public class CounselingCenterContext : IdentityDbContext<AppUser>
    {
        public CounselingCenterContext(DbContextOptions<CounselingCenterContext> options) : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AnamnesisForm> AnamnesisForms { get; set; }
    }
}