namespace ViewBagExcercise.Models
{
    public class UserMaster
    {
        public AppUser GetUser(string username)
        {
            AppUser appUser = new AppUser
            {
                UserName = username,
            };
            return appUser;
        }
        
    }
}
