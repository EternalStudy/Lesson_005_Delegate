using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_005_Delegate
{
    internal class Calculator : ICalculator
    {
        public event EventHandler<OperandChangedEventArgs> GetResult;
        private Stack<double> stack = new Stack<double>();
        private double Result { 
            get 
            {
                return stack.Count() == 0 ? 0 : stack.Peek();
            } 
            set 
            { 
                stack.Push(value); 
                RaiseEvent(); 
            } 
        }
        public void RaiseEvent()
        {
            GetResult.Invoke(this, new OperandChangedEventArgs(Result));
        }
        public void CancelLast() 
        {
            if (stack.Count > 0)
            {
                stack.Pop();
                RaiseEvent();
            }
        }
        public void Divide(int number)
        {
            try
            {
                if (number == 0)
                    throw new CalculatorDivideByZeroException("Деление на ноль недопустимо");
                Result /= number;
            }
            catch (OverflowException)
            {
                throw new CalculateOperationCauseOverflowException("Превышено допустимое число");
            }
        }
        public void Multiply(int number)
        {
            try
            {
                checked
                {
                    Result *= number;
                }
            }
            catch
            {
                throw new CalculateOperationCauseOverflowException("Превышено допустимое число");
            }
        }
        public void Substract(int number)
        {
            try
            {
                Result -= number;
            }
            catch
            {
                throw new CalculateOperationCauseOverflowException("Превышено допустимое число");
            }
        }


        public void Sum(int number)
        {
            try
            {

                Result += number;
            }
            catch
            {
                throw new CalculateOperationCauseOverflowException("Превышено допустимое число");
            }
        }
        public void Divide(double numder)
        {
             Result /= numder;
        }

        public void Multiply(double numder)
        {
             Result *= numder;
        }

        public void Substract(double numder)
        {
             Result -= numder;
        }

        public void Sum(double numder)
        {
             Result += numder;
        }
        
    }
}
