using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AngularAuthAPI.Models
{
    public class Chatinteraction
    {
        [Key]
        public int Cinteraction_Id { get; set; }
        public string? Massage { get; set; }
        public string? Date_time { get; set; }       

        public int? User_Id { get; set; }
        [ForeignKey("Id")]
        public virtual Users Users { get; set; }
    }
}
