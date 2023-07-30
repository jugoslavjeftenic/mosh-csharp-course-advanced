namespace t02_02_Delegates
{
    public class PhotoProcessor
    {
        // System.Action<> - returns void
        // System.Func<>   - returns value

        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}