namespace HackerRankChallenges.Challenges.Easy
{
    public class DrawingBook
    {
        public DrawingBook()
        {
            Console.Out.WriteLine(pageCount(6, 2)); //Testcase 1
            Console.Out.WriteLine(pageCount(5, 4)); //Testcase 2
            Console.Out.WriteLine(pageCount(6, 5)); //Testcase 26
        }

        int pageCount(int n, int p)
        {
            int totalPagesToTurn = n / 2;
            int targetPagesToTurn = p / 2;
            int targetPagesToTurnFromBack = totalPagesToTurn - targetPagesToTurn;

            return targetPagesToTurn < targetPagesToTurnFromBack ? targetPagesToTurn : targetPagesToTurnFromBack;
        }
    }
}