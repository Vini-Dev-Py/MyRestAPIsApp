using MyRestCarnes.Data.VO;

namespace MyRestCarnes.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidateCredentials(UserVO user);

        TokenVO ValidateCredentials(TokenVO token);

        bool RevokeToken(string userName);

        UserVO Create(UserVO user);
    }
}
