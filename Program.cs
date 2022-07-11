using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_loops1
{
    class Program
    {
        static void Main(string[] args)
        {     

            int firstNum = int.Parse(Console.ReadLine());
            if (firstNum < 100000 || firstNum > 300000)
            {
                throw new ArgumentException("Invalid number");
            }

            int secondNum = int.Parse(Console.ReadLine());
            if (secondNum < firstNum || secondNum > 300000)
            {
                throw new ArgumentException("Invalid number");
            }


            for (int i = firstNum; i <= secondNum; i++)
            {

                int evenSum = 0;
                int oddSum = 0;
                for(int j = i; j >0; j=j/10)
                {
                    if (j == (i / 1) || j == (i / 100) || j == (i / 10000))
                    {
                        evenSum = evenSum + (j % 10);
                    }

                    else
                    {
                        oddSum = oddSum + (j % 10);
                    }
                }

                if (oddSum == evenSum)
                {
                    Console.Write("{0} ", i);
                }
            }



            Console.ReadLine();
        }
    }
}
