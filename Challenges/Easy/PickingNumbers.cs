namespace HackerRankChallenges.Challenges.Easy
{
    public class PickingNumbers
    {
        public PickingNumbers()
        {
            List<int> nums = new() { 4, 2, 3, 4, 4, 9, 98, 98, 3, 3, 3, 4, 2, 98, 1, 98, 98, 1, 1, 4, 98, 2, 98, 3, 9, 9, 3, 1, 4, 1, 98, 9, 9, 2, 9, 4, 2, 2, 9, 98, 4, 98, 1, 3, 4, 9, 1, 98, 98, 4, 2, 3, 98, 98, 1, 99, 9, 98, 98, 3, 98, 98, 4, 98, 2, 98, 4, 2, 1, 1, 9, 2, 4 };
            Console.Out.WriteLine(pickingNumbers(nums));
        }
        int pickingNumbers(List<int> a)
        {
            int[] frequency = new int[101];
            for (int i = 0; i < a.Count; i++)
            {
                int index = a[i];
                frequency[index]++;
            }

            int maxLen = 0;

            for (int i = 0; i <= 99; i++)
            {
                maxLen = Math.Max(maxLen, frequency[i] + frequency[i + 1]);
            }

            return maxLen;
        }
    }
}