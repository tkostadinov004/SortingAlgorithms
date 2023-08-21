using SortingAlgorithms.Contracts.Interfaces.Base;

namespace SortingAlgorithms.Contracts.Abstracts
{
    public abstract class SelectionSortAlgorithm : ISortingAlgorithm
    {
        public abstract IEnumerable<int> Sort(IEnumerable<int> items);
    }
}
