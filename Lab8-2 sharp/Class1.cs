using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_2_sharp
{
    public class Mathem
    {
        public delegate void Delegate(string message);
        public event Delegate Notify;
        public Mathem(double rez)
        {
            Rez = rez;
        }
        public double Rez { get; private set; }
        public void Add(double x)
        {
            Notify?.Invoke($"To {Rez} was added {x}.");
            Rez += x;
            if (Rez == 0)
                Notify?.Invoke("Event's happened: The sum is equal to zero. ");
            else Notify?.Invoke($"The sum is {Rez}.");
        }
        public void Minus(double x)
        {
            Notify?.Invoke($"From {Rez} was taken away {x}");
            Rez -= x;
            if (Rez == 0)
                Notify?.Invoke("Event's happened: The difference is equal to zero. ");
            else Notify?.Invoke($"The difference is {Rez}.");
        }
        public void Multiply(double x)
        {
            Notify?.Invoke($"{Rez} was multiplied by {x}");
            Rez *= x;
            if (Rez == 0)
                Notify?.Invoke("Event's happened: The multiplication is equal to zero. ");
            else Notify?.Invoke($"The result of multiplication is {Rez}.");
        }
        public void Division(double x)
        {
            Notify?.Invoke($"{Rez} was divided by {x}");
            Rez /= x;
            if (Rez == 0)
                Notify?.Invoke("Event's happened: The division is equal to zero. ");
            else Notify?.Invoke($"The result of division is {Rez}.");
        }



    }
}
