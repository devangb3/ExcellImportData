using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExcellImportData.Models
{
    public class BeneficiariesFor529
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }

        [ForeignKey(nameof(Custodian))]
        public Guid CustodianId { get; set; }
        public Custodian Custodian { get; set; }

    }
}