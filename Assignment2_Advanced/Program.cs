using System.Collections;
namespace Assignment2_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Collections
            #region non-generic collection [Array list]
            // ArrayList arrayList = new ArrayList();
            // arrayList.Add(1);
            // arrayList.Add(2);
            // arrayList.Add(3);
            //Console.WriteLine($"count:{arrayList
            //    .Count} , capacty:{arrayList.Capacity}");
            // arrayList.Add(4);
            // Console.WriteLine($"count:{arrayList
            //  .Count} , capacty:{arrayList.Capacity}");
            // arrayList.TrimToSize();

            //============================================
            //ArrayList arrayListwithCapacity = new ArrayList(5) { 1, 2, 3, "sara", 5 };
            //Console.WriteLine($"count:{arrayListwithCapacity.Count} , capacty:{arrayListwithCapacity.Capacity}");
            //arrayListwithCapacity.Add(6);
            //Console.WriteLine($"count:{arrayListwithCapacity.Count} , capacty:{arrayListwithCapacity.Capacity}");

            //Console.WriteLine(SumArrayList(arrayListwithCapacity));
            //foreach(object item in arrayListwithCapacity)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region generic collection
            #region  [List<T>]
            //List<int> numbers = new List<int>();
            //Console.WriteLine($"count:{numbers.Count} , capacty:{numbers.Capacity}");
            //numbers.Add(1);
            //Console.WriteLine($"count:{numbers.Count} , capacty:{numbers.Capacity}");
            //numbers.AddRange(new int[] { 2, 3, 4, 5 });
            //Console.WriteLine($"count:{numbers.Count} , capacty:{numbers.Capacity}");
            //numbers.Add(6);
            //Console.WriteLine($"count:{numbers.Count} , capacty:{numbers.Capacity}");
            //numbers.TrimExcess();
            //Console.WriteLine($"count:{numbers.Count} , capacty:{numbers.Capacity}");
            //========================================
            //List<int> numbersWithCapacity = new List<int>(5) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"count:{numbersWithCapacity.Count} , capacty:{numbersWithCapacity.Capacity}");
            //Console.WriteLine(SumList(numbersWithCapacity));
            #endregion
            #region List<T> methods
            List<int> numbersWithCapacity = new List<int>(5) { 1, 2, 3, 4, 5 };
            numbersWithCapacity.Add(6);
            numbersWithCapacity.AddRange(7, 8, 9);
            //foreach (int item in numbersWithCapacity)
            //{
            //    Console.WriteLine(item);
            //}
            #region binary search
            //int result=numbersWithCapacity.BinarySearch(50);
            //Console.WriteLine($"Binary search result: {result}");
            #endregion
            #region clear
            //Console.WriteLine($"count:{numbersWithCapacity.Count} , capacty:{numbersWithCapacity.Capacity}");
            //numbersWithCapacity.Clear();
            //Console.WriteLine($"count:{numbersWithCapacity.Count} , capacty:{numbersWithCapacity.Capacity}");
            #endregion
            #region get range
            //List<int> rangeNumbers = numbersWithCapacity.GetRange(0, 3);
            //for (int i = 0; i < rangeNumbers.Count; i++)
            //{
            //    Console.WriteLine(rangeNumbers[i]);
            //}
            #endregion
            #region indexof | lastindexof
            //int index = numbersWithCapacity.IndexOf(3);
            //Console.WriteLine($"Index of 3: {index}");
            //int lastIndex = numbersWithCapacity.LastIndexOf(3);
            //Console.WriteLine($"Last index of 3: {lastIndex}");

            #endregion
            #region copy to array
            //int[] array = new int[numbersWithCapacity.Count];
            //numbersWithCapacity.CopyTo(array);
            //Console.WriteLine("Copied array:");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            #endregion
            #region remove
            // Console.WriteLine( numbersWithCapacity.Remove(3));
            //numbersWithCapacity.RemoveRange(0,2);
            // Console.WriteLine("After removing elements:");
            // foreach(int item in numbersWithCapacity)
            // {
            //     Console.WriteLine(item);
            //}
            //numbersWithCapacity.RemoveAt(0);
            #endregion
            #region as read only
            //IReadOnlyList<int> readOnlyList = numbersWithCapacity.AsReadOnly<int>();
            ////readOnlyList[0] = 100; // This will cause a compile-time error since it's read-only
            //numbersWithCapacity[0] = 100; // This is allowed since numbersWithCapacity is still mutable

            #endregion

            #endregion
            #region LinkedList<T>
            //LinkedList<int> numbers = new LinkedList<int>();
            //numbers.AddFirst(1);
            //numbers.AddAfter(numbers.First, 2);
            //numbers.AddLast(3);
            //numbers.AddLast(4);
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region stack<T>
            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //Console.WriteLine($"Count: {stack.Count}");
            //foreach (int item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //stack.Pop(); //2,1
            //stack.Pop(); //1
            //stack.Pop(); //empty
            //stack.TryPop(out int result);// result will be 0, since stack is empty [handel the exception]
            //Console.WriteLine(result); //0, since stack is empty
            #endregion
            #region Queue<T>
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Dequeue(); // Removes the first element (1)
            //queue.Dequeue(); // Removes the next element (2)
            //queue.Dequeue(); // Removes the next element (3)
            //queue.TryDequeue(out int result); // result will be 0, since queue is empty [handel the exception]
            //Console.WriteLine(result); // 0, since queue is empty
            #endregion


            #endregion


            #endregion
        }
        #region method to sum nongeneric arraylist
        //static int SumArrayList(ArrayList array)
        //{
        //    int sum = 0;
        //    if (array != null) {
        //        for (int i=0; i< array.Count; i++) { 
        //            sum+= (int)array[i];
        //        }
        //    }
        //    return sum;
        //}
        #endregion
        #region method to sum generic list 
        static int SumList(List<int> list) 
        {
            int sum = 0;
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    sum += list[i];
                }
            }
            return sum;
        }
        #endregion
    }
}
