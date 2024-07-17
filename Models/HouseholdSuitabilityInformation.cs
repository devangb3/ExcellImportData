using System.ComponentModel.DataAnnotations;

namespace ExcellImportData.Models
{
    public class HouseholdSuitabilityInformation
    {
        [Key]
        public Guid Id { get; set; }
        public string AnnualIncome { get; set; }//enum
        public string NetWorth { get; set; }//enum
        public string LiquidNetWorth { get; set; }//enum
        public string ClientTaxBracket { get; set; }//enum

    }
}