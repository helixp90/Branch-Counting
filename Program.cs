using System;
using System.Collections.Generic;

namespace Branch_Counting
{
    class Branch
    {
        public List<Branch> branches;

        public int GetDepth()
        {
            if (branches == null || branches.Count == 0) //Null or 0 branches means there are no child branches
                return 1;

            int maxDepth = 0;

            foreach (var branch in branches)
            {
                int depth = branch.GetDepth();

                if (depth > maxDepth) //Checks if the current viewed branch has more child branches compared to the previous branch
                    maxDepth = depth;
            }

            return maxDepth + 1; //+ 1 to account for the root branch
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //List all branches

            Branch branch1 = new Branch();
            Branch branch2 = new Branch();
            Branch branch3 = new Branch();
            Branch branch4 = new Branch();
            Branch branch5 = new Branch();
            Branch branch6 = new Branch();
            Branch branch7 = new Branch();
            Branch branch8 = new Branch();
            Branch branch9 = new Branch();
            Branch branch10 = new Branch();
            Branch branch11 = new Branch();

            //I used the given branch structure in the PDF

            branch1.branches = new List<Branch> { branch2, branch3 };
            branch2.branches = new List<Branch> { branch4 };
            branch3.branches = new List<Branch> { branch5, branch6, branch7 };
            branch5.branches = new List<Branch> { branch8 };
            branch6.branches = new List<Branch> { branch9, branch10 };
            branch9.branches = new List<Branch> { branch11 };

            // Calculate the depth starting from the root branch

            int depth = branch1.GetDepth();

            Console.WriteLine("The depth of the given branch structure is: " + depth);

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }

}
