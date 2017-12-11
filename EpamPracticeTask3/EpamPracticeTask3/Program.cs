using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace EpamPracticeTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstVector = new Vector(10);
            var secondVector = new Vector(10);
            var operations = new Operations();
            Console.WriteLine(firstVector.ToString());
            Console.WriteLine(secondVector.ToString());
            
            //Checking index
            try
            {
                firstVector[12] = 5;
            }
            catch (LengthOutofRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            //Adding
            try
            {
                var resultaddVector = operations.AddTwoVectors(firstVector, secondVector, 3, 8);
                Console.WriteLine(resultaddVector.ToString());
            }

            catch (ArgumentNullException e)
            {

                Console.WriteLine(e.Message);
            }
            catch (LengthException e)
            {
                Console.WriteLine(e.Message);
            }
            //Substracting
            try
            {
                var resutsubVector = operations.SubstractTwoVectors(firstVector, secondVector, 3, 8);
                Console.WriteLine(resutsubVector.ToString());
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (LengthException e)
            {
                Console.WriteLine(e.Message);
            }
            //Multiplication
            try
            {
                var resutmultyVector = operations.MultiplicateForScalar(firstVector, 2);
                Console.WriteLine(resutmultyVector.ToString());
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            //Comparing
            try
            {
                Console.WriteLine(operations.CompareVectors(firstVector, secondVector)
                    ? "Vectors are equal"
                    : "Vectors are not equal");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (LengthException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
