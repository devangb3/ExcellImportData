using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace ExcellImportData.Models
{
    public class BeneficiariesForRetirement
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }    
        public string RealationShip { get; set; }

        public DateTime DOB { get; set; }

        public string SSN { get; set; }

        public string Type { get; set; }  
        public double BeneficiaryPercentage { get; set; }

        [ForeignKey(nameof(Custodian))]
        public Guid CustodianId { get; set; }
        public Custodian Custodian { get; set; }    
    }
}