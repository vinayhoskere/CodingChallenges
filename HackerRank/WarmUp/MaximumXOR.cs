namespace CodingChallenges.HackerRank.WarmUp
{
    class MaximumXOR
    {
        /// <summary>
        /// Given two integers, L and R, find the maximal value of A xor B, where A and B satisfy the following condition:
        /// </summary>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>

        static int maxXor(int l, int r)
        {
            if (l == r)
                return l ^ r;

            int result = 0;
            for (int i = l; i <= r; i++)
            {
                for (int j = i; j <= r; j++)
                {
                    if (result < (i ^ j))
                        result = i ^ j;
                }
            }
            return result;
        }

        //static void Main(String[] args)
        //{
        //    int res;
        //    int _l;
        //    _l = Convert.ToInt32(Console.ReadLine());

        //    int _r;
        //    _r = Convert.ToInt32(Console.ReadLine());

        //    res = maxXor(_l, _r);
        //    Console.WriteLine(res);

        //}
    }
}
