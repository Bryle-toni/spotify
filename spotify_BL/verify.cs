using spotify_DL;

namespace spotify_BL
{
    public class verify
    {
        public bool verifyUser(string USERName)
        {
            spotify_data data = new spotify_data();
            var result = data.GetUser(USERName);

            return result.USERName!= null ? true : false;
        }
    }
}