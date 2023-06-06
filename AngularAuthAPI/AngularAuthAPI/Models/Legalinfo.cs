using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AngularAuthAPI.Models
{
    public class Legalinfo
    {
        [Key]
        public int Legalinfo_Id { get; set; }
        public string? Type { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Document { get; set; }
        public string? Dateadded { get; set; }

        public int? Rbook_Id { get; set; }
        [ForeignKey("Id")]
        public virtual RBook RBook { get; set; }
    }
}

