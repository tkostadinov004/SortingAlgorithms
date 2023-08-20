using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Contracts.Interfaces.Base
{
    public interface ISortingAlgorithm
    {
        public IEnumerable<int> Sort(IEnumerable<int> items);
    }
}
