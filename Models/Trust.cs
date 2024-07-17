using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExcellImportData.Models
{
    public class Trust
    {

        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Record))]
        public Guid RecordId { get; set; }
        public Record Record { get; set; }


        public string FullTrustName { get; set; }
        public DateTime TrustDate { get; set; }
        public string IsRevocable { get; set; } // bool
        public string StateOfEstablishment { get; set; }
        public string EstablishedBy { get; set; }
        public string SSNTIN { get; set; }
        public string SSNTINType { get; set; } // enum
        public ICollection<Individual> Individuals { get; set; }

    }
}