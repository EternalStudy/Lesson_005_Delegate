using System.Runtime.Serialization;

namespace Lesson_005_Delegate
{
    internal class CalculateOperationCauseOverflowException : Exception
    {
        public CalculateOperationCauseOverflowException(string message) : base(message)
        {

        }
    }
}