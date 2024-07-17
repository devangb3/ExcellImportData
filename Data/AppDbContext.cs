using DocumentFormat.OpenXml.Spreadsheet;
using ExcellImportData.Models;
using Microsoft.EntityFrameworkCore;

namespace ExcellImportData.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Record> Records { get; set; }

        public DbSet<Custodian> Custodians { get; set; }   
        
        public DbSet<BeneficiariesForRetirement> BeneficiariesForRetirements { get; set; }

        public DbSet<BeneficiariesFor529> BeneficiariesFor529 { get; set; }

        public DbSet<OriginalDepositor> originalDepositors { get; set; }    

        public DbSet<Trust> Trusts { get; set; }

        public DbSet<Individual> Individuals { get; set; }  

        public DbSet<AchEftInstructions> AchEftInstructions { get; set; }

        public DbSet<Instructions> Instructions { get; set; }   

        public DbSet<HouseholdSuitabilityInformation> HouseholdSuitabilityInformations { get; set; }    

        public DbSet<HouseholdPreferences> HouseholdPreferences { get; set; }

        public DbSet<Account> Accounts { get; set; } 
    }
}
