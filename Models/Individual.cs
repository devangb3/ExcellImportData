using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExcellImportData.Models
{
    public class Individual
    {

        [Key]
        public Guid Id { get; set; }
        public string IndividualName { get; set; }
        public string Role { get; set; } // enum
        public string Authority { get; set; } // enum

        [ForeignKey(nameof(Trust))]
        public Guid TrustId { get; set; }
        public Trust Trust { get; set; }
    }
}