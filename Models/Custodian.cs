using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Net;
using System.Numerics;
using System.Xml.Linq;

namespace ExcellImportData.Models
{
    public class Custodian
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Record))]
        public Guid RecordId { get; set; }

        public Record Record { get; set; }  

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SsnTin { get; set; }

        public string SSNTINCheckbox { get; set; }
        public DateTime DOB { get; set; }
        public string CitizenshipStatusPrimary { get; set; }
        public string DayPhone { get; set; }
        public string EveningPhone { get; set; }
        public string EmailPrimary { get; set; }
        public string LegalAddress { get; set; }
        public string LegalCity { get; set; }
        public string LegalState { get; set; }
        public string LegalZip { get; set; }

        public string LegalCountry { get; set; }
        public string MailingAddress { get; set; }
        public string MailingCity { get; set; }
        public string MailingState { get; set; }
        public string MailingZip { get; set; }
        public string MailingCountry { get; set; }
        public string Employment { get; set; }
        public string SourceOfWealth { get; set; }


        //2 checkboxes
        public string AffiliatedPrimary { get; set; }
        public string ControlPublic { get; set; }

        //trusted contacts
        public string TC { get; set; }
        public string TCName { get; set; }
        public string TCRelationship { get; set; }
        public string TCLegalAddress { get; set; }
        public string TCEmail { get; set; }
        public string TCPhone { get; set; }

        public ICollection<BeneficiariesForRetirement> BeneficiariesForRetirement { get; set; }

        public ICollection<BeneficiariesFor529> BeneficiariesFor529 { get; set; }
        
        public ICollection<OriginalDepositor> OriginalDepositor { get; set; }

    }
}