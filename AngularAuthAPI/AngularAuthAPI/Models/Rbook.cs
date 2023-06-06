using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularAuthAPI.Models
{
    public class RBook
    {
        [Key]
        public int RBook_Id { get; set; }              
        public string? Name { get; set; }
        public string? Creation_date { get; set; }
        public string? Last_Modified { get; set; }
        //public string? Due_date { get; set; }
        //public string? Status { get; set; }
        
        public int? User_Id { get; set; }
        [ForeignKey("Id")]
        public virtual Users Users {get; set; }
    }
}
