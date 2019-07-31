using System;

namespace BuildingAnExponentMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //exponent is a function where we can pass in base and power number and it will take the base number rather than the power number 


            Console.WriteLine(GetPow(3, 2)); //should return result of 3 squared = 9
            Console.ReadLine();


        }

        static int GetPow (int baseNum, int powNum)
        {
            int result = 1;
            for (int i = 0; i < powNum; i++) //looping through the numbe rof powNum if powNum is 4 times it will loop 4 times 
            {
                result = result * baseNum;
            }


            return result; 
        }
    }
}
