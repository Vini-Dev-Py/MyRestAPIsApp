using MyRestCarnes.Data.Converter.implementations;
using MyRestCarnes.Data.VO;
using MyRestCarnes.Model;
using MyRestCarnes.Repository;
using System.Collections.Generic;

namespace MyRestCarnes.Business.Implementations
{
    public class StoreBusinessImplementation : IStoreBusiness
    {
        private readonly IRepository<Store> _repository;

        private readonly StoreConverter _converter;

        public StoreBusinessImplementation(IRepository<Store> repository)
        {
            _repository = repository;
            _converter = new StoreConverter();
        }
        public List<StoreVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public StoreVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        public StoreVO Create(StoreVO store)
        {
            var storeEntity = _converter.Parse(store);
            storeEntity = _repository.Create(storeEntity);
            return _converter.Parse(storeEntity);
        }

        public StoreVO Update(StoreVO store)
        {   
            var storeEntity = _converter.Parse(store);
            storeEntity = _repository.Update(storeEntity);
            return _converter.Parse(storeEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}