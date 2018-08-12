using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using EBunnuShop.Model.Abstracts;

namespace EBunnuShop.Model.Models
{
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string CategoriyID { get; set; }
        public string Image { get; set; }
        public XElement MoreImages { get; set; }
        public decimal Price { get; set; }
        public decimal Promotion { get; set; }
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
        public string Tags { set; get; }
        public int Quantity { set; get; }
        public decimal OriginalPrice { set; get; }
    }
}