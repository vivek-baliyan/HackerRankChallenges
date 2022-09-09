namespace HackerRankChallenges.Challenges.Easy
{
    public class MigratoryBirds
    {
        public MigratoryBirds()
        {
            List<int> birds = new() { 1, 4, 4, 4, 5, 3, 3, 3 };
            Console.Out.WriteLine(migratoryBirds(birds));
        }

        int migratoryBirds(List<int> arr)
        {
            int count = 0;
            int birdType = 0;
            foreach (int type in arr.Distinct().OrderBy(x => x))
            {
                int typeCount = arr.Count(b => b == type);
                if (typeCount > count)
                {
                    count = typeCount;
                    birdType = type;
                }
            }
            return birdType;
        }
    }
}