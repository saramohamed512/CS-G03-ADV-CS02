namespace Ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:Count numbers greater than X in array
            //string[] firstLine = Console.ReadLine().Split();
            //int N = int.Parse(firstLine[0]);
            //int Q = int.Parse(firstLine[1]);

            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


            //for (int i = 0; i < Q; i++)
            //{
            //    int X = int.Parse(Console.ReadLine());
            //    int count = arr.Count(num => num > X);
            //    Console.WriteLine(count);
            //}
            #endregion
            #region Q2:Check if array is palindrome
            //int N = int.Parse(Console.ReadLine());
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //bool isPalindrome = true;
            //for (int i = 0; i < N / 2; i++)
            //{
            //    if (arr[i] != arr[N - 1 - i])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //Console.WriteLine(isPalindrome ? "YES" : "NO");
            #endregion
            #region Q3:Reverse queue using stack
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("Queue: " + string.Join(", ", queue));

            Stack<int> stack = new Stack<int>();

         
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            Console.WriteLine("Reversed queue: " + string.Join(", ", queue));
            #endregion

        }
    }
}
