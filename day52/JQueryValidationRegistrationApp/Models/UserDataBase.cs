namespace JQueryValidationRegistrationApp.Models
{
    public class UserDataBase
    {
        public string userName { get; set; }
        public string Email { get; set; }

        public IDictionary<string, string> dataBase { get { return userDatabase(); } }



        public IDictionary<string, string> userDatabase()
        {
            IDictionary<string, string> userDataBase = new Dictionary<string, string>();
            userDataBase.Add(new KeyValuePair<string, string>("sachin", "sachin@gmail.com"));
            userDataBase.Add(new KeyValuePair<string, string>("akhilesh", "akhilesh@gmail.com"));
            userDataBase.Add(new KeyValuePair<string, string>("venkat", "venkat@gmail.com"));
            userDataBase.Add(new KeyValuePair<string, string>("minu", "minu@gmail.com"));
            return userDataBase;
        }

        public bool isUserAvailable(string userName)
        {
            var userlist = userDatabase();
            bool isAuthenticated = false;
            foreach (var user in userlist)
            {
                if (userName == user.Key)
                {
                    isAuthenticated = true;
                    break;
                }

            }
            return isAuthenticated;

        }
        public bool isEmailAvailable(string email)
        {
            var userlist = userDatabase();
            bool isAuthenticated = false;
            foreach (var pass in userlist)
            {
                if (email == pass.Value)
                {
                    isAuthenticated = true;
                    break;
                }

            }
            return isAuthenticated;

        }
    }
}
