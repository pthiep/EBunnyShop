using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBunnuShop.Model.Abstracts
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
