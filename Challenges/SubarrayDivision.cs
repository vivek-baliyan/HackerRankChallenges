namespace HackerRankChallenges.Challenges
{
    public class SubarrayDivision
    {
        public SubarrayDivision()
        {
            List<int> segments = new() { 1, 2, 1, 3, 2 };
            Console.Out.WriteLine(birthday(segments, 3, 2));
        }
        int birthday(List<int> s, int d, int m)
        {
            int count = 0;
            for (int i = 0; i <= s.Count - m; i++)
            {
                int sum = 0;
                for (int j = i; j < i + m; j++)
                {
                    sum += s[j];
                }
                if (sum == d)
                    count++;
            }
            return count;
        }
    }
}