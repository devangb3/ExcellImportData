using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExcellImportData.Models
{
    public class AchEftInstructions
    {
        [Key]
        public Guid Id { get; set; }

        public ICollection<Instructions> Instructions { get; set; }

    }
}