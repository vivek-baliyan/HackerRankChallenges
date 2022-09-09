namespace HackerRankChallenges.Challenges.Easy
{
    public class CountingValleys
    {
        public CountingValleys()
        {
            Console.Out.WriteLine(countingValleys(8, @"UDDDUDUU")); //Testcase 1
        }

        int countingValleys(int steps, string path)
        {
            int level = 0, valleys = 0;

            foreach (char step in path.ToCharArray())
            {
                if (step == 'U')
                {
                    level++;
                    if (level == 0)
                        valleys++;
                }
                else
                    level--;
            }

            return valleys;
        }
    }
}