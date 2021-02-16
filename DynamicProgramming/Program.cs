using System;

namespace DynamicProgramming
{
    public class Program
    {
        public static void Main(String[] args)
        {
            string wordA = "hish";
            string wordB = "fish";

            int[,] cell = new int[wordA.Length, wordB.Length];


            for (int i = 0; i < wordA.Length; i++)
            {
                for (int j = 0; j < wordB.Length; j++)
                {
                    // The letters match
                    if (wordA[i] == wordB[j])
                    {
                        if (i > 0 && j > 0)
                        {
                            cell[i, j] = cell[i - 1, j - 1] + 1;
                        }
                        else
                        {
                            cell[i, j] = 1;
                        }
                    }
                    else
                    {
                        // The letters don't match.
                        if (i == 0 && j > 0)
                        {
                            cell[i, j] = cell[i, j - 1];
                        }
                        else if (i > 0 && j == 0)
                        {
                            cell[i, j] = cell[i - 1, j];
                        }
                        else if (i > 0 && j > 0)
                        {
                            cell[i, j] = Math.Max(cell[i - 1, j], cell[i, j - 1]);
                        }
                        else
                        {
                            cell[i, j] = 0;
                        }
                    }
                }
            }

            printResult(cell);
            //      [0, 0, 0, 1]
            //      [0, 1, 1, 1]
            //      [0, 1, 2, 2]
            //      [0, 1, 2, 3]

        }

        private static void printResult(int[,] arr)
        {
            foreach (var row in arr)
            {
                Console.WriteLine(row.ToString());
            }
        }
    }
}
