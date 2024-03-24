namespace tpmodul6_1302223153
{
    public class SayaTubeVideo
    {
        Random random = new Random();
        int id;
        string title;
        int playCount;
        public SayaTubeVideo(string title)
        {
            this.title = title;
            id = random.Next(10000, 99999);
            playCount = 0;
    }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount = playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Judul: " + title + "\nId: " + id + "\nPlay count: " + playCount);
        }
    }
}
