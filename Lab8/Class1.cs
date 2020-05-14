using System;

namespace Lab8
{
    public class Math
    {
        public delegate void Delegate(string message);
        public event Delegate Notify;
        public Math(double rez)
        {
            Rez = rez;
        }
        public double Rez { get; private set; }
        public void Add(double x)
        {
            Notify?.Invoke($"To {Rez} was added {x}");
            Rez += x;
            if (Rez == 0)
                Notify?.Invoke("The sum is equal to zero. ");
            else Notify?.Invoke($"The sum is {Rez}.");
        }
        public void Minus(double x)
        {
            Notify?.Invoke($"From {Rez} was taken away {x}");
            Rez -= x;
            if (Rez == 0)
                Notify?.Invoke("The difference is equal to zero. ");
            else Notify?.Invoke($"The difference is {Rez}.");
        }
        public void Multiply(double x)
        {
            Notify?.Invoke($"{Rez} was multiplied by {x}");
            Rez *= x;
            if (Rez == 0)
                Notify?.Invoke("The multiplication is equal to zero. ");
            else Notify?.Invoke($"The result of multiplication is {Rez}.");
        }
        public void Division(double x)
        {
            Notify?.Invoke($"{Rez} was divided by {x}");
            Rez /= x;
            if (Rez == 0)
                Notify?.Invoke("The division is equal to zero. ");
            else Notify?.Invoke($"The result of division is {Rez}.");
        }



    }
}
