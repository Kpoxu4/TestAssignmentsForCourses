using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignmentsForCourses
{
    public class MultiplicationTable
    {
        private int _number;
        public string Result { get; set; }

        public MultiplicationTable(int number)
        {
            _number = number;
            Result = PrintMultiplicationTable(_number);
        }

        private string PrintMultiplicationTable(int number)
        {
            var res = new StringBuilder();

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    res.Append($"{i * j}\t");
                }
                res.Append($"\n").Append($"\n");
            }

            return res.ToString().Trim();
        }
    }
}
