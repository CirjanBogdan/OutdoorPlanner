using OutdoorPlanner.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OutdoorPlanner.ViewModels;

namespace OutdoorPlanner.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Invitation> Invitations { get; set; }
        public DbSet<UserInvitation> UserInvitations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // one to many Event -> Invitations
            modelBuilder.Entity<Invitation>()
                .HasOne(invitation => invitation.Event)
                .WithMany(invitations => invitations.Invitations)
                .HasForeignKey(invitation => invitation.EventId);

            // many to many User -> Invitations

            modelBuilder.Entity<UserInvitation>()
                .HasKey(ui => new { ui.UserId, ui.InvitationId });
            modelBuilder.Entity<UserInvitation>()
                .HasOne(bc => bc.User)
                .WithMany(b => b.UserInvitations)
                .HasForeignKey(bc => bc.UserId);
            modelBuilder.Entity<UserInvitation>()
                .HasOne(bc => bc.Invitation)
                .WithMany(c => c.UserInvitation)
                .HasForeignKey(bc => bc.InvitationId);

            modelBuilder.Entity<Event>().HasData(
                new Event()
                {
                    Id = 1,
                    Name = "Untold Festival",
                    Date = DateTime.Now.AddDays(1).AddHours(1),
                    City = OutdoorPlanner.Models.Enum.RomaniaCity.Cluj,
                    Description = "Description",
                    Category = Models.Enum.Category.Festivals
                },
                new Event()
                {
                    Id = 2,
                    Name = "Massif",
                    Date = DateTime.Now.AddDays(2).AddHours(18),
                    City = OutdoorPlanner.Models.Enum.RomaniaCity.Brasov,
                    Description = "Massif Festival",
                    Category = Models.Enum.Category.Festivals
                },
                new Event()
                {
                    Id = 3,
                    Name = "Smiley Concert",
                    Date = DateTime.Now.AddDays(3).AddHours(12),
                    City = OutdoorPlanner.Models.Enum.RomaniaCity.Bucharest,
                    Description = "Description",
                    Category = Models.Enum.Category.Concerts
                },
                new Event()
                {
                    Id = 4,
                    Name = "Bucharest Food Festival",
                    Date = DateTime.Now.AddDays(4),
                    City = OutdoorPlanner.Models.Enum.RomaniaCity.Bucharest,
                    Description = "Biggest Food Festival",
                    Category = Models.Enum.Category.FoodFestivals
                },
                new Event()
                {
                    Id = 5,
                    Name = "Transylvania Brunch",
                    Date = DateTime.Now.AddDays(1).AddHours(4),
                    City = OutdoorPlanner.Models.Enum.RomaniaCity.Sibiu,
                    Description = "Food",
                    Category = Models.Enum.Category.FoodFestivals
                },
                new Event()
                {
                    Id = 6,
                    Name = "International Wine Festival of Romania",
                    Date = DateTime.Now.AddDays(3).AddHours(3),
                    City = OutdoorPlanner.Models.Enum.RomaniaCity.Constanta,
                    Description = "",
                    Category = Models.Enum.Category.FoodFestivals
                },
                new Event()
                {
                    Id = 7,
                    Name = "Electric Castle",
                    Date = DateTime.Now.AddDays(0).AddHours(9),
                    City = OutdoorPlanner.Models.Enum.RomaniaCity.Cluj,
                    Description = "",
                    Category = Models.Enum.Category.Festivals
                },
                new Event()
                {
                    Id = 8,
                    Name = "Past Event",
                    Date = DateTime.Now,
                    City = OutdoorPlanner.Models.Enum.RomaniaCity.Galati,
                    Description = "",
                    Category = Models.Enum.Category.Concerts
                });
        }
        public DbSet<EventViewModel> EventViewModel { get; set; } = default!;
        public DbSet<InvitationViewModel> InvitationViewModel { get; set; } = default!;
        public DbSet<CreateInvitationBindingModel> CreateInvitationBindingModel { get; set; } = default!;
    }
}
