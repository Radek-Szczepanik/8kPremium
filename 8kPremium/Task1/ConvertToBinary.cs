using System;

namespace Task1
{
    public class ConvertToBinary
    {
        public string ConvertNumberToBinary()
        {
            Console.WriteLine("Give number: ");
            string number = Console.ReadLine();
            int numberToInt = int.Parse(number);
            var convertedNumber = Convert.ToString(numberToInt, 2);
            Console.WriteLine("Binary number: \n" + convertedNumber);
            return convertedNumber;
        }
    }
}
