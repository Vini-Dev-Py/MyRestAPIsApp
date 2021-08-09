using System.Collections.Generic;
using MyRestCarnes.Data.Converter.Implementations;
using MyRestCarnes.Data.VO;
using MyRestCarnes.Model;
using MyRestCarnes.Repository;

namespace MyRestCarnes.Business.Implementations
{
    public class UserBusinessImplementation : IUserBusiness
    {
        private readonly IUserRepository _userRepository;

        private readonly UserConverter _converter;

        public UserBusinessImplementation(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _converter = new UserConverter();
        }

        public List<UserVO> FindAll()
        {
            return _converter.Parse(_userRepository.FindAll());
        }

        public UserVO FindByUsername(string username)
        {
            return _converter.Parse(_userRepository.FindByUsername(username));
        }
    }
}