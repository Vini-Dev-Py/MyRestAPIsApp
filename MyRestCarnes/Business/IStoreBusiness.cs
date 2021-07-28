using System.Collections.Generic;
using MyRestCarnes.Data.VO;

namespace MyRestCarnes.Business
{
    public interface IStoreBusiness
    {
        StoreVO Create(StoreVO store);

        StoreVO FindByID(long id);

        List<StoreVO> FindAll();

        StoreVO Update(StoreVO store);

        void Delete(long id);
    }
}