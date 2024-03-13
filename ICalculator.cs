using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_005_Delegate
{
    internal interface ICalculator
    {
        void Sum(int x);
        void Substract(int x);
        void Divide(int x);
        void Multiply(int x);
        void CancelLast();
        public event EventHandler<OperandChangedEventArgs> GetResult;
    }
}
