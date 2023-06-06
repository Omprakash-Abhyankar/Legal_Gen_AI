using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularAuthAPI.Models
{
    public class SearchQuery
    {
        [Key]
        public int SQuery_Id { get; set; }
        public string Keywords { get; set; }
        public string Date_time { get; set; }

        public int? User_Id { get; set; }
        [ForeignKey("Id")]
        public virtual Users Users { get; set; }
    }
}
