using System.Collections.Generic;
using MyRestCarnes.Data.VO;
using MyRestCarnes.Model;

namespace MyRestCarnes.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);

        User ValidateCredentials(string username);
        
        User FindByUsername(string username);

        List<User> FindAll();

        bool RevokeToken(string username);

        User RefreshUserInfo(User user);
    }
}
