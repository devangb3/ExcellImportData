using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExcellImportData.Models
{
    public class Instructions
    {

        [Key]
        public Guid Id { get; set; }
        public string BankAccountRegristration { get; set; }

        //later can be converted to enum
        public string BankAccountType { get; set; }
        public string BankRouting { get; set; }
        public string BankName { get; set; }
        public string BankAccount { get; set; }

        [ForeignKey(nameof(AchEftInstructions))]
        public Guid AchEftInstructionsId { get; set; }
        public AchEftInstructions AchEftInstructions { get; set; }

    }
}