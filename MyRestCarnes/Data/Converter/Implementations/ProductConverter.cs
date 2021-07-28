using MyRestCarnes.Data.Converter.Contract;
using MyRestCarnes.Data.VO;
using MyRestCarnes.Model;
using System.Collections.Generic;
using System.Linq;

namespace MyRestCarnes.Data.Converter.Implementations
{
    public class ProductConverter : IParser<ProductVO, Product>, IParser<Product, ProductVO>
    {
        public Product Parse(ProductVO origin)
        {
            if (origin == null) return null;

            return new Product
            {
                Id = origin.Id,
                Name = origin.Name,
                Code = origin.Code,
                Image = origin.Image,
                Price = origin.Price,
                StoreID = origin.StoreID,
            };
        }

        public List<Product> Parse(List<ProductVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public ProductVO Parse(Product origin)
        {
            if (origin == null) return null;

            return new ProductVO
            {
                Id = origin.Id,
                Name = origin.Name,
                Code = origin.Code,
                Image = origin.Image,
                Price = origin.Price,
                StoreID = origin.StoreID
            };
        }

        public List<ProductVO> Parse(List<Product> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}