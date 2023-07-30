namespace t02_04_EventsAndDelegates
{
    public class VideoEncoder
    {
        // 1- Define a delegate
        // 2- Define an event based on delegate
        // 3- Raise the event

        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}