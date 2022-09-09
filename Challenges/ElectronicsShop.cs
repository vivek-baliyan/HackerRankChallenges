namespace HackerRankChallenges.Challenges
{
    public class ElectronicsShop
    {
        public ElectronicsShop()
        {
            int[] keyboards = { 3, 1 };
            int[] drives = { 5, 2, 8 };
            int budget = 10;
            Console.Out.WriteLine(getMoneySpent(keyboards, drives, budget)); //Testcase 1
        }

        int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int expensiveOption = -1;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    int price = keyboards[i] + drives[j];
                    if (price <= b && price > expensiveOption)
                        expensiveOption = price;
                }
            }
            return expensiveOption;
        }
    }
}