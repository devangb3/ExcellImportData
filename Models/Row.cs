using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExcellImportData.Models
{
    public class Record
    {
        [Key]
        public Guid Id { get; set; } 
        public string HouseholdDeliveryPreference { get; set; }    
        public ICollection<Custodian> Custodians { get; set; }  

        public ICollection<Trust> Trusts { get; set; }


        //
        [ForeignKey(nameof(AchEftInstructions))]
        public Guid AchEftInstructionsId { get; set; }

        public AchEftInstructions AchEftInstructions { get; set; }



        //
        [ForeignKey(nameof(HouseholdSuitabilityInformation)) ]
        public Guid HouseholdSuitabilityInformationId { get; set; }

        public HouseholdSuitabilityInformation HouseholdSuitabilityInformation { get; set; }


        //
        [ForeignKey(nameof(HouseholdPreferences))]
        public Guid HouseholdPreferencesId { get; set; }
        public HouseholdPreferences HouseholdPreferences { get; set; }  

        public ICollection<Account> Accounts { get; set; }
    }

    
}
