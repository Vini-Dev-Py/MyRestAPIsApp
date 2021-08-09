using MyRestCarnes.Data.Converter.Implementations;
using MyRestCarnes.Data.VO;
using MyRestCarnes.Model;
using MyRestCarnes.Repository;
using System.Collections.Generic;

namespace MyRestCarnes.Business.Implementations
{
    public class ProductBusinessImplementation : IProductBusiness
    {
        private readonly IRepository<Product> _repository;

        private readonly ProductConverter _converter;

        public ProductBusinessImplementation(IRepository<Product> repository)
        {
            _repository = repository;
            _converter = new ProductConverter();
        }
        public List<ProductVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public ProductVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        public ProductVO Create(ProductVO product)
        {
            var productEntity = _converter.Parse(product);
            productEntity = _repository.Create(productEntity);
            return _converter.Parse(productEntity);
        }

        public ProductVO Update(ProductVO product)
        {   
            var productEntity = _converter.Parse(product);
            productEntity = _repository.Update(productEntity);
            return _converter.Parse(productEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}