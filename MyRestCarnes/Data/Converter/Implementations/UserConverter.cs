using MyRestCarnes.Data.Converter.Contract;
using MyRestCarnes.Data.VO;
using MyRestCarnes.Model;
using System.Collections.Generic;
using System.Linq;

namespace MyRestCarnes.Data.Converter.Implementations
{
    public class UserConverter : IParser<UserVO, User>, IParser<User, UserVO>
    {
        public User Parse(UserVO origin)
        {
            if (origin == null) return null;
            return new User
            {
                Id = origin.Id,
                Password = origin.Password,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Email = origin.Email,
                Role = origin.Role,
                Address = origin.Address,
                CPF = origin.CPF,
                Phone = origin.Phone,
            };
        }

        public List<User> Parse(List<UserVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public UserVO Parse(User origin)
        {
            if (origin == null) return null;
            return new UserVO
            {
                Id = origin.Id,
                Password = origin.Password,
                FirstName = origin.FirstName,
                LastName = origin.LastName,
                Email = origin.Email,
                Role = origin.Role,
                Address = origin.Address,
                CPF = origin.CPF,
                Phone = origin.Phone,
            };
        }

        public List<UserVO> Parse(List<User> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}