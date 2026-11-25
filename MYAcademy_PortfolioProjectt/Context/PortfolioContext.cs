using Microsoft.EntityFrameworkCore;
using MYAcademy_PortfolioProjectt.Entities;

namespace MYAcademy_Portfolio.Context
{
    public class PortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Halime\\SQLEXPRESS2022;Database=PortfolioDbNight;integrated security=true;trust server certificate=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<HeroSection> HeroSections { get; set; }
      
    }
}
// Bu sınıf c# daki sınıflarımızı sql deki tablolara dönüştüren yapınınn bir köprüsü olacak.
// override -> bir metot var bir işlem yapacak ama benim istediğim şekilde yapsın.
// payment --> Pay() -> Havale/EFT , Kredi Kartı , Kapıda Ödeme