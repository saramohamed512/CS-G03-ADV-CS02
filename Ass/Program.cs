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
            #region Q8:Search for target in stack
            //    Stack<int> stack = new Stack<int>();

            //for (int i = 1; i <= 10; i++) stack.Push(i);

            //Console.Write("Enter target to search: ");
            //int target = int.Parse(Console.ReadLine());

            //int count = 0;
            //bool found = false;
            //Stack<int> tempStack = new Stack<int>();


            //while (stack.Count > 0)
            //{
            //    count++;
            //    int current = stack.Pop();
            //    tempStack.Push(current);

            //    if (current == target)
            //    {
            //        found = true;
            //        break;
            //    }
            //}


            //while (tempStack.Count > 0)
            //{
            //    stack.Push(tempStack.Pop());
            //}

            //if (found)
            //{
            //    Console.WriteLine($"Target was found successfully and the count = {count}");
            //}
            //else
            //{
            //    Console.WriteLine("Target was not found");
            //}
            #endregion
            #region Q9:Find intersection of two arrays with counts


            //string[] sizes = Console.ReadLine().Split(',');
            //int size1 = int.Parse(sizes[0].Trim());
            //int size2 = int.Parse(sizes[1].Trim());

            //int[] arr1 = Array.ConvertAll(Console.ReadLine().Trim('[', ']').Split(','), int.Parse);
            //int[] arr2 = Array.ConvertAll(Console.ReadLine().Trim('[', ']').Split(','), int.Parse);

            //ArrayList freq1 = new ArrayList();
            //ArrayList freq2 = new ArrayList();

            //foreach (int num in arr1)
            //{
            //    bool found = false;
            //    for (int i = 0; i < freq1.Count; i += 2)
            //    {
            //        if ((int)freq1[i] == num)
            //        {
            //            freq1[i + 1] = (int)freq1[i + 1] + 1;
            //            found = true;
            //            break;
            //        }
            //    }
            //    if (!found)
            //    {
            //        freq1.Add(num);
            //        freq1.Add(1);
            //    }
            //}

            //foreach (int num in arr2)
            //{
            //    bool found = false;
            //    for (int i = 0; i < freq2.Count; i += 2)
            //    {
            //        if ((int)freq2[i] == num)
            //        {
            //            freq2[i + 1] = (int)freq2[i + 1] + 1;
            //            found = true;
            //            break;
            //        }
            //    }
            //    if (!found)
            //    {
            //        freq2.Add(num);
            //        freq2.Add(1);
            //    }
            //}

            //ArrayList result = new ArrayList();
            //for (int i = 0; i < freq1.Count; i += 2)
            //{
            //    int num = (int)freq1[i];
            //    int count1 = (int)freq1[i + 1];

            //    for (int j = 0; j < freq2.Count; j += 2)
            //    {
            //        if ((int)freq2[j] == num)
            //        {
            //            int count2 = (int)freq2[j + 1];
            //            int minCount = Math.Min(count1, count2);
            //            for (int k = 0; k < minCount; k++)
            //            {
            //                result.Add(num);
            //            }
            //            break;
            //        }
            //    }
            //}

            //Console.WriteLine("[" + string.Join(", ", result.ToArray()) + "]");
            #endregion
            #region Q10:Find contiguous sublist with target sum
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim('[', ']').Split(','), int.Parse);
            int target = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if (sum == target)
                    {
                        int[] sublist = new int[j - i + 1];
                        Array.Copy(arr, i, sublist, 0, j - i + 1);
                        Console.WriteLine("[" + string.Join(", ", sublist) + "]");
                        return;
                    }
                    else if (sum > target)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("No sublist found");
            #endregion

        }
    }
}
