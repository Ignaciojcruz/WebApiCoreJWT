using WebApiCoreJWT.Models;

namespace WebApiCoreJWT.Interface
{
    public interface IUserInfo
    {
        public List<UserInfo> GetUserInfos();
    }
}
