using System.Collections.Generic;
using MyRestCarnes.Data.VO;

namespace MyRestCarnes.Business
{
    public interface IUserBusiness
    {
        UserVO FindByUsername(string username);
        List<UserVO> FindAll();
    }
}