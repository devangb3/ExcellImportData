using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExcellImportData.Models
{
    public class Account
    {

        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string RegistrationTypeAccount { get; set; } //enum
        public int ContraAccountNumber { get; set; }
        public int NewAccountNumber { get; set; }
        public string NewCustodian { get; set; } //enum
        public string TransactionCharges { get; set; } //enum
        public string AdvisorAnnualFee { get; set; }
        public string InvestmentObjective { get; set; } //enum
        public string TimeHorizon { get; set; } //enum
        public string LiquidityNeedsIsPresent { get; set; }
        public string LiquidityNeedsType { get; set; }
        public int StandingInstructionsNumber { get; set; }
        public string Margin { get; set; } //enum
        public string AlternateInvestmentsIsPresent { get; set; } //AI account
        public string AlternateInvestmentsAccountId { get; set; } //AI account
        public string ACAPAccount { get; set; } //bool(Yes/No)
        public string ZeroBalCALAccount { get; set; }
        public string ThirdPartyCollateralAccountIsPresent { get; set; }
        public string ThirdPartyCollateralAccountId { get; set; }
        public string OptionsTrading { get; set; } // bool(Yes/No)
        public string SubadvisorStrategy { get; set; }

        [ForeignKey(nameof(Record))]
        public Guid RecordId { get; set; }
        public Record Record { get; set; }  
    }
}