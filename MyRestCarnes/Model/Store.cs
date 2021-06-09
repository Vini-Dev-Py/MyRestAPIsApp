using System.ComponentModel.DataAnnotations.Schema;

namespace MyRestCarnes.Model
{
    [Table("store")]
    public class Store
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("end")]
        public string End { get; set; }

        [Column("img")]
        public string Img { get; set; }

        [Column("status")]
        public string Status { get; set; }
    }
}