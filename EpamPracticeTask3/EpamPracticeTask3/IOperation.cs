namespace EpamPracticeTask3
{
    public interface IOperation
    {
        /// <summary>
        /// Method to adds two vectors
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <param name="start">start of interval</param>
        /// <param name="end">end of interval</param>
        /// <returns>return new vector which is sum of two vector</returns>
        Vector AddTwoVectors(Vector firstVector, Vector secondVector, int start, int end);
        /// <summary>
        /// Method to substract two vectors
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <param name="start">start of interval</param>
        /// <param name="end">end of interval</param>
        /// <returns>return new vector which is substruction of two vector</returns>
        Vector SubstractTwoVectors(Vector firstVector, Vector secondVector, int start, int end);
        /// <summary>
        /// Method for multiplication vector on scalar
        /// </summary>
        /// <param name="vector">vector</param>
        /// <param name="number">scalar</param>
        /// <returns>return new vector which is production vector and scalar</returns>
        Vector MultiplicateForScalar(Vector vector, int number);
        /// <summary>
        /// Method for comparing two vectors
        /// </summary>
        /// <param name="firstVector">first vector</param>
        /// <param name="secondVector">second vector</param>
        /// <returns>true if vectors are equal</returns>
        bool CompareVectors(Vector firstVector, Vector secondVector);
    }
}