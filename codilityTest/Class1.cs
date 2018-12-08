using System;
using System.Linq;

namespace codilityTest
{
    public class Class1
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 6, 3, 1, 4, 1, 2 };
            int[] B = new int[] { 1, 2, 3 };
            int[] C = new int[] { -1, -3 };

            Console.WriteLine(smallestpositiveinteger(A));
            Console.WriteLine(smallestpositiveinteger(B));
            Console.WriteLine(smallestpositiveinteger(C));
        }
        public static int smallestpositiveinteger(int[] A)
        {
            int[] postive = A.Select(i => i).Where(x => x > 0).OrderBy(j => j).ToArray();
            int length = postive.Length;
            if (postive != null && postive.Length > 0)
            {
                if ((postive[length - 1] - postive[length - 2]) == 0)
                {
                    return postive[length - 1] + 1;
                }
                else if ((postive[length - 1] - postive[length - 2]) > 0 && postive.Select(x => x).Where(i => i == (postive[length - 2] + 1)).ToList().Count == 0)
                {
                    return postive[length - 2] + 1;
                }
                else
                {
                    return postive[length - 1] + 1;
                }

            }
            else
            {
                return 1;
            }
        }

    }
}
