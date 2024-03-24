namespace tpmodul6_1302223153
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - [Rafli]");
            video.IncreasePlayCount(26);
            video.PrintVideoDetails();
        }
    }
}
