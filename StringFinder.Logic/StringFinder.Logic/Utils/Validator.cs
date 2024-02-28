using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringFinder.Logic.Utils
{
    public static class Validator
    {
        /// <summary>
        /// This method will validate to match numbers and white space
        /// </summary>
        /// <param name="strInput"></param>
        /// <returns></returns>
        public static bool ValidateString(string strInput)
        {
            try
            {
                // Regular expression pattern to match numbers and white space
                string pattern = @"^[0-9\s]+$";

                // Check if the input matches the pattern
                return Regex.IsMatch(strInput, pattern);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during validation
                Console.WriteLine($"An error occurred during string validation: {ex.Message}");
                return false;
            }
        }
    }
}
