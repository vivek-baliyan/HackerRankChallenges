namespace HackerRankChallenges.Challenges
{
    public class CatsAndMouse
    {
        public CatsAndMouse()
        {
            string[] locations = { "1,2,3", "1,3,2" };
            for (int i = 0; i < 2; i++)
            {
                string[] l = locations[i].Split(",");
                Console.Out.WriteLine(catAndMouse(Convert.ToInt32(l[0]), Convert.ToInt32(l[1]), Convert.ToInt32(l[2])));
            }
        }

        string catAndMouse(int x, int y, int z)
        {
            int catA = Math.Abs(x - z);
            int catB = Math.Abs(y - z);
            return catA == catB ? "Mouse C" : catA > catB ? "Cat B" : "Cat A";
        }
    }
}