using SortingAlgorithms.Algorithms;
using SortingAlgorithms.Contracts.Interfaces.Base;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISortingAlgorithm algorithm = new CountingSort();
            Console.WriteLine(string.Join(", ", algorithm.Sort(new int[] { 2, 3, -1,-2, 5 })));
        }
    }
}