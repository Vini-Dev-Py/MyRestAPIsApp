namespace MyRestCarnes.Data.VO
{
    public class ProductVO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public long StoreID { get; set; }
        public string Featured { get; set; }
    }
}