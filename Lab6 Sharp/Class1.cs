using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_Sharp
{
    class Calculate
    {
        private double _a,_b,_c,_d;
        public double A
        {
            get { return _a; }
            set
            {
                if (value==0) throw new ArithmeticException
                   (message: "Value in logarifm must be mare than zero , change a!");
                
                _a = value;
            }
        }
        public double B
        {
            get { return _b; }
            set
            {
                if (value == 0) throw new DivideByZeroException
                        (message: " b can't be zero!");

                if (A * value <= 0) throw new ArithmeticException
                    (message: "Value in logarifm must be mare than zero , change b!");

                _b = value;
            }
        }
        public  double C
        {
            get { return _c; }
            set
            {
                _c = value;
            }
        }
        public double D
        {
            get { return _d; }
            set
            {
                if (_c + _b + _a - value == 0) throw new DivideByZeroException
                        (message: "Sum of a, b, c and -d can't be zero!");
                _d = value;
            }
        }

        public Calculate(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        
        }
        public double Result()
        {
            return (4 * Math.Log(_a / _b) + 1) / (_c + _b - _d + _a);
        }
    }
}
