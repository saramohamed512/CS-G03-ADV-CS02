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
