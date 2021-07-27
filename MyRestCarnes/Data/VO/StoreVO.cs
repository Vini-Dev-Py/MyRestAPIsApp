using System;

namespace MyRestCarnes.Data.VO
{
    public class StoreVO
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string End { get; set; }

        public string Img { get; set; }

        public string Status { get; set; }

        public TimeSpan Abertura { get; set; }

        public TimeSpan Fechamento { get; set; }
    }
}