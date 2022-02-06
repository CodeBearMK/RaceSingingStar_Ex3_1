namespace RaceSingingStar_Ex3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "錢一文", "李四維", "周六合" };
            int[,] score = { { 89, 73, 90 }, { 88, 79, 85 }, { 79, 83, 76 }, { 70, 89, 82 }, { 93, 67, 82 } };
            int[] score_sum = { 0, 0, 0 };

            for (int i = 0; i < score.GetLength(0); i++)
            {
                score_sum[0] += score[i, 0];
                score_sum[1] += score[i, 1];
                score_sum[2] += score[i, 2];
            }

            Array.Sort(score_sum, name);
            Array.Reverse(name);
            Array.Reverse(score_sum);
            Console.WriteLine("第1名：{0}　{1}", name[0], score_sum[0]);
            Console.WriteLine("第2名：{0}　{1}", name[1], score_sum[1]);
            Console.WriteLine("第3名：{0}　{1}", name[2], score_sum[2]);
            Console.Read();
        }
    }
}