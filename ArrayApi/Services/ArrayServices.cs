using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayApi.Services
{
    public class ArrayServices : IArrayServices
    {
        public async Task<IEnumerable<int>> DeleteByPosition(int position, int[] numbers)
        {
            var cell = 0;
            var count = numbers.Length;
            var updatedNumbers = new int[count - 1];

            await Task.Run(() =>
            {
                for (var i = 0; i < count; i++)
                {
                    if (i == position - 1)
                        continue;

                    updatedNumbers[cell] = numbers[i];
                    cell++;
                }
            });

            return updatedNumbers;
        }

        public async Task<IEnumerable<int>> Reverse(int[] numbers)
        {
            var reversedNumbers = new int[] { };

            if (numbers.Any())
            {
                reversedNumbers = await Task.Run(() =>
                {
                    var count = numbers.Length;

                    // loop through only the 1st half of the array
                    for (var i = 0; i < count / 2; i++)
                    {
                        var temp = numbers[i];
                        numbers[i] = numbers[count - i - 1];
                        numbers[count - i - 1] = temp;
                    }

                    return numbers;
                });
            }

            return reversedNumbers;
        }
    }
}
