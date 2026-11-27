using Microsoft.EntityFrameworkCore;
using MYAcademy_PortfolioProjectt.Entities;
using MYAcademy_PortfolioProjectt.Entities;
using MYAcademy_PortfolioProjectt.Entities;

namespace MYAcademy_Portfolio.Context
{
    public class PortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS2022;database=MyAcademyPortfolioDb;integrated security=true;TrustServerCertificate=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<HeroSection> HeroSections { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
//override

//Payment--> Pay() ---> Havale/Eft, Kredi Kartı, Kapıda Ödeme

// Bu sınıf c# daki sınıflarımızı sql deki tablolara dönüştüren yapınınn bir köprüsü olacak.
// override -> bir metot var bir işlem yapacak ama benim istediğim şekilde yapsın.
// payment --> Pay() -> Havale/EFT , Kredi Kartı , Kapıda Ödeme