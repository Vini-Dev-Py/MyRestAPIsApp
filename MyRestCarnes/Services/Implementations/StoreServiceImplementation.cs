using MyRestCarnes.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyRestCarnes.Services.Implementations
{
    public class StoreServiceImplementation : IStoreService
    {
        private Model.Context.MySQLContext _context;

        public StoreServiceImplementation(Model.Context.MySQLContext context)
        {
            _context = context;
        }
        public List<Store> FindAll()
        {
            return _context.Shops.ToList();
        }

        public Store FindByID(long id)
        {
            return _context.Shops.SingleOrDefault(s => s.Id.Equals(id));
        }

        public Store Create(Store store)
        {
            try
            {
                _context.Add(store);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

            return store;
        }

        public Store Update(Store store)
        {   
            if (!Exists(store.Id)) return new Store();

            var result = _context.Shops.SingleOrDefault(p => p.Id.Equals(store.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(store);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return store;
        }

        public void Delete(long id)
        {
            var result = _context.Shops.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Shops.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private bool Exists(long id)
        {
            return _context.Shops.Any(p => p.Id.Equals(id));
        }
    }
}