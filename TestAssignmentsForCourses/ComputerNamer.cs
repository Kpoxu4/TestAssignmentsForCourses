using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignmentsForCourses
{
    public class ComputerNamer
    {
        public string ResultString { get; set; }    
        public int _number;

        public ComputerNamer(int number)
        {
            _number = number;
            ResultString = FormatComputers(_number);
        }

        private string FormatComputers(int number)
        {
            string result = string.Empty;
            string[] fromat = { "компьютер", "компьютера", "компьютеров" };

            if (10 <= number % 100 && number % 100 <= 20)
            {
                result = $"{number} {fromat[2]}";
            }

            else
            {
                int lastDigit = number % 10;
                if (lastDigit == 1)
                {
                    result = $"{number} {fromat[0]}";
                }
                else if (2 <= lastDigit && lastDigit <= 4)
                {
                    result = $"{number} {fromat[1]}";
                }
                else
                {
                    result = $"{number} {fromat[2]}";
                }
            }

            return result;
        }
    }
}
