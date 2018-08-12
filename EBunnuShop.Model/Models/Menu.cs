using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBunnyShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public string DislayOrder { get; set; }
        [Required]
        public string GroupID { get; set; }
        [Required]
        public string Target { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
