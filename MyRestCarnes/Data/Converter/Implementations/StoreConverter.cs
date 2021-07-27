using MyRestCarnes.Data.Converter.Contract;
using MyRestCarnes.Data.VO;
using MyRestCarnes.Model;
using System.Collections.Generic;
using System.Linq;

namespace MyRestCarnes.Data.Converter.implementations
{
    public class StoreConverter : IParser<StoreVO, Store>, IParser<Store, StoreVO>
    {
        public Store Parse(StoreVO origin)
        {
            if (origin == null) return null;
            return new Store
            {
                Id = origin.Id,
                Name = origin.Name,
                End = origin.End,
                Img = origin.Img,
                Status = origin.Status,
                Abertura = origin.Abertura,
                Fechamento = origin.Fechamento,
            };
        }

        public StoreVO Parse(Store origin)
        {
            if (origin == null) return null;
            return new StoreVO
            {
                Id = origin.Id,
                Name = origin.Name,
                End = origin.End,
                Img = origin.Img,
                Status = origin.Status,
                Abertura = origin.Abertura,
                Fechamento = origin.Fechamento,
            };
        }

        public List<Store> Parse(List<StoreVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<StoreVO> Parse(List<Store> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}