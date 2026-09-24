using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Hashing
{
    /*
    Question:
    Given an array of strings, group the strings that are anagrams
    of each other.

    Anagrams are words that contain the same characters with the
    same frequencies, but possibly in a different order.

    Example:
    Input:
    ["eat", "tea", "tan", "ate", "nat", "bat"]

    Output:
    ["eat", "tea", "ate"]
    ["tan", "nat"]
    ["bat"]
    */

    /*
    Time Complexity (TC):
    O(n * k log k)

    Explanation:
    n is the number of strings and k is the maximum length of a string.
    Each string is sorted to create a common key, which takes O(k log k).

    Space Complexity (SC):
    O(n * k)

    Explanation:
    The dictionary stores all strings grouped by their sorted-character
    keys. The output also requires space proportional to the input.
    */

    public class GroupAnagrams
    {
        public static IList<IList<string>> Group(string[] words)
        {
            Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

            foreach (string word in words)
            {
                char[] characters = word.ToCharArray();
                Array.Sort(characters);
                string key = new string(characters);

                if (!groups.ContainsKey(key))
                {
                    groups[key] = new List<string>();
                }

                groups[key].Add(word);
            }

            return groups.Values.Select(group => (IList<string>)group).ToList();
        }

        public static void Main(string[] args)
        {
            string[] words =
            {
                "eat",
                "tea",
                "tan",
                "ate",
                "nat",
                "bat"
            };

            IList<IList<string>> result = Group(words);

            foreach (IList<string> group in result)
            {
                Console.WriteLine("[" + string.Join(", ", group) + "]");
            }
        }
    }
}