using System.Collections.Generic;
using MyRestCarnes.Data.VO;

namespace MyRestCarnes.Business
{
    public interface IProductBusiness
    {
        ProductVO Create(ProductVO product);

        ProductVO FindByID(long id);

        List<ProductVO> FindAll();

        ProductVO Update(ProductVO product);

        void Delete(long id);
    }
}