using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class CountSortUsingHashMap
    {
        private static void sortbyFreqMap(int[] arr)
        {
            Dictionary<int, int> freqMap = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (freqMap.ContainsKey(arr[i]))
                {
                    freqMap.TryGetValue(key: arr[i], value: out arr[i++]);
                }
                else
                {
                    freqMap.TryGetValue(key: arr[i], value: out arr[i]);
                }
            }
            for (int i = 1; i <= 4; i++)
            {
                int freq = freqMap.TryGetValue(key: arr[i], value: out arr[i]) ? 1 : 0;   
                for (int j = 0; j < freq; j++)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

       /*tatic void Main(string[] args)
        {
            int[] arr = { 3, 1, 4, 4, 2, 4, 2, 3, 1, 2 };
            //sortbyFreq(arr);
            //Console.WriteLine();
            sortbyFreqMap(arr);
        }*/
    }
}
