using StringFinder.Logic.Interfaces;
using StringFinder.Logic.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFinder.Logic.Services
{
    public class FindingService : IFindingService
    {
        /// <summary>
        /// function outputs the longest increasing consective subsequence (increased by any number) present in that sequence
        /// </summary>
        /// <param name="strInput"></param>
        /// <returns></returns>
        public string SubsequenceFinder(string strInput) 
        {
            try
            {
                if (Validator.ValidateString(strInput))
                {
                    int[] intNumbers = strInput.Split(' ').Select(int.Parse).ToArray();

                    int intMaxLength = 0;
                    int intStart = 0;
                    int intEnd = 0;

                    int intWindowStart = 0;

                    for (int windowEnd = 0; windowEnd < intNumbers.Length; windowEnd++)
                    {
                        if (windowEnd > 0 && intNumbers[windowEnd] <= intNumbers[windowEnd - 1])
                        {
                            intWindowStart = windowEnd;  // Reset window if increasing pattern breaks
                        }

                        if (windowEnd - intWindowStart + 1 > intMaxLength)
                        {
                            intMaxLength = windowEnd - intWindowStart + 1;
                            intStart = intWindowStart;
                            intEnd = windowEnd;
                        }
                    }

                    return string.Join(" ", intNumbers.Skip(intStart).Take(intMaxLength)); 
                }
                else
                {
                    return "No valid input provided.";
                }
            }
            catch (FormatException ex)
            {
                throw new FormatException("No valid input provided.");
            }
        }
    }
}
