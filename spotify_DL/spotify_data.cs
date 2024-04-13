using spotify_model;

namespace spotify_DL
{
    public class spotify_data
    {
        List<spotify_mo> Account = new List<spotify_mo>();
        public spotify_data()
        {
            CreateUserData();
        }

        private void CreateUserData()
        {
            spotify_mo user1 = new spotify_mo
            {
                USERName = "Atienza"
            };

            spotify_mo user2 = new spotify_mo
            {
                USERName = "Bryle"
            };

            spotify_mo user3 = new spotify_mo
            {
                USERName = "Anthony"
            };

            Account.Add(user1);
            Account.Add(user2);
            Account.Add(user3);
        }

        public spotify_mo GetUser(string USERName)
        {
            spotify_mo foundUser = new spotify_mo();

            foreach (var user in Account)
            {
                if (USERName == user.USERName)
                {
                    foundUser = user;
                }
            }

            return foundUser;
        }
    }
}