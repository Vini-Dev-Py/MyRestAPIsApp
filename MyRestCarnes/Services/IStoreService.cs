using System.Collections.Generic;
using MyRestCarnes.Model;

namespace MyRestCarnes.Services
{
    public interface IStoreService
    {
         Store Create(Store store);

         Store FindByID(long id);

         List<Store> FindAll();

         Store Update(Store store);

         void Delete(long id);
    }
}