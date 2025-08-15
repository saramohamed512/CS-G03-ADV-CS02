using System.Collections;
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
            //Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
            //Console.WriteLine("Queue: " + string.Join(", ", queue));

            //Stack<int> stack = new Stack<int>();


            //while (queue.Count > 0)
            //{
            //    stack.Push(queue.Dequeue());
            //}

            //while (stack.Count > 0)
            //{
            //    queue.Enqueue(stack.Pop());
            //}

            //Console.WriteLine("Reversed queue: " + string.Join(", ", queue));
            #endregion
            #region Q4:Check balanced parentheses
            //string input = Console.ReadLine();
            //Stack<char> stack = new Stack<char>();
            //bool balanced = true;

            //foreach (char c in input)
            //{
            //    if (c == '(' || c == '[' || c == '{')
            //    {
            //        stack.Push(c);
            //    }
            //    else
            //    {
            //        if (stack.Count == 0)
            //        {
            //            balanced = false;
            //            break;
            //        }

            //        char top = stack.Pop();
            //        if (!((top == '(' && c == ')') ||
            //              (top == '[' && c == ']') ||
            //              (top == '{' && c == '}')))
            //        {
            //            balanced = false;
            //            break;
            //        }
            //    }
            //}

            //if (stack.Count > 0) balanced = false;

            //Console.WriteLine(balanced ? "Balanced" : "Not Balanced");
            #endregion
            #region Q5:Remove duplicates from array
            //int[] arr = { 1, 2, 2, 3, 4, 4, 4, 5, 5 };
            //Console.WriteLine("Array: " + string.Join(", ", arr));


            //int[] distinctArr = arr.Distinct().ToArray();

            //Console.WriteLine("Array after removing duplicates: " + string.Join(", ", distinctArr));
            #endregion
            #region Q6:Remove odd numbers from ArrayList


            //ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("List: " + string.Join(", ", list.ToArray()));

            //for (int i = list.Count - 1; i >= 0; i--)
            //{
            //    if ((int)list[i] % 2 != 0)
            //    {
            //        list.RemoveAt(i);
            //    }
            //}

            //Console.WriteLine("List after removing odd numbers: " + string.Join(", ", list.ToArray()));
            #endregion
            #region Q7:Generic queue with different data types
            //Queue<object> queue = new Queue<object>();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //Console.WriteLine("Queue items:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


        }
    }
}
