namespace HackerRankChallenges.Challenges.Medium
{
    public class MagicSquare
    {
        public MagicSquare()
        {
            List<List<int>> array2D = new();

            array2D.Add(new List<int>() { 2, 9, 8 });
            array2D.Add(new List<int>() { 4, 2, 7 });
            array2D.Add(new List<int>() { 5, 6, 7 });

            Console.Out.WriteLine(formingMagicSquare(array2D));

        }

        int formingMagicSquare(List<List<int>> s)
        {
            var allMagicSquares = new int[,,] {
                {{ 8, 1, 6 }, { 3, 5, 7 }, { 4, 9, 2 }},
                {{ 6, 1, 8 }, { 7, 5, 3 }, { 2, 9, 4 }},
                {{ 4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 6 }},
                {{ 2, 9, 4 }, { 7, 5, 3 }, { 6, 1, 8 }},
                {{ 8, 3, 4 }, { 1, 5, 9 }, { 6, 7, 2 }},
                {{ 4, 3, 8 }, { 9, 5, 1 }, { 2, 7, 6 }},
                {{ 6, 7, 2 }, { 1, 5, 9 }, { 8, 3, 4 }},
                {{ 2, 7, 6 }, { 9, 5, 1 }, { 4, 3, 8 }},
            };

            int minCost = int.MaxValue;

            for (int i = 0; i < allMagicSquares.GetLength(0); i++)
            {
                int cost = 0;
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        cost += Math.Abs(s[j][k] - allMagicSquares[i, j, k]);
                    }
                }
                minCost = minCost > cost ? cost : minCost;
            }
            return minCost;
        }
    }
}