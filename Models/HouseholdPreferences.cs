using System.ComponentModel.DataAnnotations;

namespace ExcellImportData.Models
{
    public class HouseholdPreferences
    {
        [Key]
        public Guid Id { get; set; }
        public string AccountAccessRights { get; set; }
        public string StatementPrefences { get; set; }
        public string TradeConfirmation { get; set; }
        public string DividendReinvestment { get; set; }
        public string RetirementMoneyMarket { get; set; }
        public string NonRetirementMoneyMarket { get; set; }

    }
}