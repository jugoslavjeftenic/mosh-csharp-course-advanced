namespace t02_09_ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Acces YouTube web service
                // Read the data
                // Create a list of video objects
                throw new Exception("Some low level YouTube error.");
            }
            catch (Exception e)
            {
                // Log
                throw new YouTubeException("Could not fetch the videos from YouTube.", e);
            }

            return new List<Video>();
        }
    }
}