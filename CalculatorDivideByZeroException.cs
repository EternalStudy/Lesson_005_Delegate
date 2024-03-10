using System.Runtime.Serialization;

namespace Lesson_005_Delegate
{/*
     * Доработайте реализацию калькулятора разработав собственные типы  ошибок.
    CalculatorDivideByZeroException
    CalculateOperationCauseOverflowException
    */
    internal class CalculatorDivideByZeroException : Exception
    {
        public CalculatorDivideByZeroException(string message) : base(message)
        {

        }

    }
}