using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace EpamPracticeTask3
{
    /// <summary>
    /// Class for work with vector
    /// </summary>
    public class Vector:IFormattable
    {
        /// <summary>
        /// Initialize vector
        /// </summary>
        private int [] vector;
        /// <summary>
        /// Property for Lenth of vector
        /// </summary>
        public int Length => vector.Length;
        /// <summary>
        /// Indexator
        /// </summary>
        /// <param name="index">input index</param>
        /// <returns>element of vector</returns>
        public int this[int index]
        {
            set
            {   
                if (index > Length)
                    throw new LengthOutofRangeException("The input index is out of range");
                vector[index] = value;
            }
            get
            {
                if (index > Length)
                    throw new LengthOutofRangeException("The input index is out of range");
                return vector[index];
            }
        }
        /// <summary>
        /// Constructor to initialize object vector
        /// </summary>
        /// <param name="length">input length of vector</param>
        public Vector(int length)
        {
            vector = new int[length];
            GenerateVector();
        }
        /// <summary>
        /// Method for random generating vector
        /// </summary>
        private void GenerateVector()
        {
            var random = new Random();
            Thread.Sleep(20);
            for (var i = 0; i < Length; i++)
            {
                vector[i] = random.Next(0, 500);
            }
        }
        /// <summary>
        /// Method to represent vector in string
        /// </summary>
        /// <returns> string which represent vector</returns>
        public override string ToString()
        {
            return ToString("", CultureInfo.CurrentCulture);
        }
        /// <summary>
        /// Method to represent vector in string
        /// </summary>
        /// <returns> string which represent vector</returns>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < Length; i++)
                sb.Append($"{vector[i]} ");
            sb.Append("\n");
            return sb.ToString();
        }
    }
}
