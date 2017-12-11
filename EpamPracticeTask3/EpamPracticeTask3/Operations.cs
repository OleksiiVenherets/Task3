using System;

namespace EpamPracticeTask3
{
    public class Operations: IOperation
    {
        /// <summary>
        /// Method to adds two vectors
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <param name="start">start of interval</param>
        /// <param name="end">end of interval</param>
        /// <returns>return new vector which is sum of two vector</returns>
        public Vector AddTwoVectors(Vector firstVector, Vector secondVector, int start, int end)
        {
            if (firstVector == null || secondVector == null)
                throw new ArgumentNullException();

            if (firstVector.Length != secondVector.Length)
                throw new LengthException("Lengths of vectors are not equal");

            var resultVector = new Vector(end - start + 1);
            for (var i = start; i <= end; i++)
                resultVector[i - start] = firstVector[i] + secondVector[i];
            return resultVector;
        }
        /// <summary>
        /// Method to substract two vectors
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <param name="start">start of interval</param>
        /// <param name="end">end of interval</param>
        /// <returns>return new vector which is substruction of two vector</returns>
        public Vector SubstractTwoVectors(Vector firstVector, Vector secondVector, int start, int end)
        {
            if (firstVector == null || secondVector == null)
                throw new ArgumentNullException();
            if (firstVector.Length != secondVector.Length)
                throw new LengthException("Lengths of vectors are not equal");
            var resultVector = new Vector(end - start + 1);

            for (var i = start; i <= end; i++)
                resultVector[i - start] = firstVector[i] - secondVector[i];
            return resultVector;
        }
        /// <summary>
        /// Method for multiplication vector on scalar
        /// </summary>
        /// <param name="vector">vector</param>
        /// <param name="number">scalar</param>
        /// <returns>return new vector which is production vector and scalar</returns>
        public Vector MultiplicateForScalar(Vector vector, int number)
        {
            if (vector == null )
                throw new ArgumentNullException();
            var resultVector = new Vector(vector.Length);
            for (var i = 0; i < vector.Length; i++)
                resultVector[i] = vector[i]*number;
            return resultVector;
        }
        /// <summary>
        /// Method for comparing two vectors
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <returns>true if vectors are equal</returns>
        public bool CompareVectors(Vector firstVector, Vector secondVector)
        {
            if (firstVector == null || secondVector == null)
                throw new ArgumentNullException();

            if (firstVector.Length != secondVector.Length)
                throw new LengthException("Lengths of vectors are not equal");

            for (var i = 0; i < firstVector.Length; i++)
                if (firstVector[i] != secondVector[i])
                    return false;
            return true;
        }
    }
}