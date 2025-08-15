namespace Ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:Count numbers greater than X in array
            string[] firstLine = Console.ReadLine().Split();
            int N = int.Parse(firstLine[0]);
            int Q = int.Parse(firstLine[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


            for (int i = 0; i < Q; i++)
            {
                int X = int.Parse(Console.ReadLine());
                int count = arr.Count(num => num > X);
                Console.WriteLine(count);
            }
            #endregion
        }
    }
}
