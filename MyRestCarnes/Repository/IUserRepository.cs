﻿using MyRestCarnes.Data.VO;
using MyRestCarnes.Model;

namespace MyRestCarnes.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);

        User ValidateCredentials(string username);

        bool RevokeToken(string username);

        User RefreshUserInfo(User user);
    }
}
