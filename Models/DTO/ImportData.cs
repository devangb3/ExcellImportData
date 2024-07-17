using System.ComponentModel.DataAnnotations;

namespace ExcellImportData.Models.DTO
{
    public class ImportData
    {
        [Required]
        public IFormFile File { get; set; } 
    }
}
