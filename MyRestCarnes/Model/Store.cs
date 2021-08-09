using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyRestCarnes.Model.Base;

namespace MyRestCarnes.Model
{
    [Table("store")]
    public class Store : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("end")]
        public string End { get; set; }

        [Column("img")]
        public string Img { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("abertura")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{HH:mm:ss}")]
        public TimeSpan Abertura { get; set; }

        [Column("fechamento")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{HH:mm:ss}")]
        public TimeSpan Fechamento { get; set; }
    }
}