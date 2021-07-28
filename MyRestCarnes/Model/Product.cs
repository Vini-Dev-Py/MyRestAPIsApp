using System.ComponentModel.DataAnnotations.Schema;
using MyRestCarnes.Model.Base;

namespace MyRestCarnes.Model
{
    [Table("product")]
    public class Product : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("code")]
        public string Code { get; set; }

        [Column("img")]
        public string Image { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("storeid")]
        public long StoreID { get; set; }
    }
}