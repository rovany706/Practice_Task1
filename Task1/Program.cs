using System;

namespace Task1
{
    class Program
    {
        private const int maxN = 8;
        private const int max = Int32.MaxValue;
        private static int minActions = max;
        private static string best;

        private static int[,] dp = new int[maxN, maxN];
        private static int n = int.Parse(Console.ReadLine());
        private static int[,] arr = new int[maxN, maxN];


        static int cur_count(int type, int container)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (i != container)
                    sum += arr[i, type];
            }

            dp[type, container] = sum;
            return sum;
        }
        static int Solve(string currentStr)
        {
            int currentSum = 0;
            for (int i = 0; i < n; i++)
            {
                if (dp[currentStr[i] - 'A', i] != -1)
                    currentSum += dp[currentStr[i] - 'A', i];
                else
                    currentSum += cur_count(currentStr[i] - 'A', i);
            }

            return currentSum;
        }

        static void cnt_ans(string currentStr, byte[] stack)
        {
            bool flag = false;
            for (int i = 0; i < n; i++)
            {
                if (stack[i] != 0)
                {
                    flag = true;
                    stack[i]--;
                    cnt_ans(currentStr + (char)(i + 'A'), stack);
                    stack[i]++;
                }
            }

            if (!flag)
            {
                int cur_ans = Solve(currentStr);
                if (cur_ans < minActions)
                {
                    minActions = cur_ans;
                    best = currentStr;
                }
            }
        }
        static void Main()
        {
            byte[] stack = new byte[maxN];
            for (int i = 0; i < n; i++)
            {
                string[] bottles = Console.ReadLine().Split(' ');
                stack[i] = 1;
                for (int j = 0; j < n; j++)
                {
                    dp[i, j] = -1;
                    arr[i, j] = int.Parse(bottles[j]);
                }
            }
            cnt_ans("", stack);
            Console.WriteLine(best);
            Console.WriteLine(minActions);
        }
    }
}
