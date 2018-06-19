using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConverter
{
    public class RomanConverter
    {
        private Dictionary<int, string> romanValues => new Dictionary<int, string>
        {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" },
            { 9, "IX" },
            { 10, "X" },
            { 40, "XL" },
            { 50, "L" },
            { 90, "XC" },
            { 100, "C" },
            { 400, "CD" },
            { 500, "D" },
            { 900, "CM" },
            { 1000, "M" }
        };
        private Dictionary<char, int> numberValues => new Dictionary<char, int>
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };

        public string Convert(int number)
        {
            return NumberToRomanNumeral(number);
        }
        public int Convert(string romanNumberString)
        {
            return RomanNumeralToNumber(romanNumberString);
        }
        private int RomanNumeralToNumber(string romanString)
        {
            if (romanString == "nulla")
                return 0;

            int number = 0;
            romanString = romanString.ToUpper();

            List<char> romanStringList = romanString.ToArray().ToList();

            for (int i = 0; i < romanStringList.Count; i++)
            {
                if (i + 1 < romanStringList.Count)
                {
                    if (numberValues[romanStringList[i]] < numberValues[romanStringList[i + 1]])
                    {
                        number -= numberValues[romanStringList[i]];
                        continue;
                    }
                }
                number += numberValues[romanStringList[i]];
            }
            return number;
        }
        private string NumberToRomanNumeral(int number)
        {
            if (number == 0)
                return "nulla";

            if (number > 3999 || number < 0) //we only support the "good" roman numerals - James Mcshane
                throw new NotImplementedException();

            List<string> romanString = new List<string>();

            foreach(KeyValuePair<int, string> numeral in romanValues.OrderByDescending(x => x.Key))
            {
                romanString.AddRange(getString(ref number, numeral.Key));
            }
            return string.Join("", romanString);
        }
        private List<string> getString(ref int number, int divisor)
        {
            List<string> romanString = new List<string>();
            if (number >= divisor)
            {

                if (romanValues.ContainsKey(number))
                {
                    romanString.Add(romanValues[number]);
                    number -= number;
                }
                
                if (number > 0)
                {
                    while(number/divisor > 0)
                    {
                        romanString.Add(romanValues[divisor]);
                        number -= divisor;
                    }
                }
            }
            return romanString;
        }
    }
}
