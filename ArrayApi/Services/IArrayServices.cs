using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayApi.Services
{
    public interface IArrayServices
    {
        Task<IEnumerable<int>> Reverse(int[] numbers);
        Task<IEnumerable<int>> DeleteByPosition(int position, int[] numbers);
    }
}
