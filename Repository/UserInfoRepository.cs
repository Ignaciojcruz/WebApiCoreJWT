using WebApiCoreJWT.Interface;
using WebApiCoreJWT.Models;

namespace WebApiCoreJWT.Repository
{
    public class UserInfoRepository : IUserInfo
    {
        readonly DataBaseContext _dbContext = new();

        public UserInfoRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<UserInfo> GetUserInfos()
        {
            try
            {
                return _dbContext.UserInfos.ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
