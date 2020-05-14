using System;


namespace Lab5_Sharp
{
    class Punkt
    {
        private double x;
        private double y;
        public Punkt()
        {
            this.x = 0;
            this.y = 0;
        }
        public Punkt(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double X()
        {
            return x;
        }
        public double Y()
        {
            return y;
        }
    }
    class Shape : Exception
    {
        protected Punkt[] _shape;
        protected int count;
        protected double[] lenghts;

        public Shape()
        {
            _shape = new Punkt[count];
            lenghts = new double[count];
        }
        public double LenSide(Punkt[] _shape, int z)
        {
            for (int i = 0; i < count; i++)
            {
                if (i == count - 1)
                {
                    int j = i;
                    i = 0;
                    lenghts[j] = Math.Sqrt(Math.Pow(_shape[i].X() - _shape[j].X(), 2) + Math.Pow(_shape[i].Y() - _shape[j].Y(), 2));
                    break;
                }
                else
                {
                    lenghts[i] = Math.Sqrt(Math.Pow(_shape[i].X() - _shape[i + 1].X(), 2) + Math.Pow(_shape[i].Y() - _shape[i + 1].Y(), 2));
                }
            }
            return lenghts[z];
        }
        public double LenSide(int z)
        {
            for (int i = 0; i < count; i++)
            {
                if (i == count - 1)
                {
                    int j = i;
                    i = 0;
                    lenghts[j] = Math.Sqrt(Math.Pow(_shape[i].X() - _shape[j].X(), 2) + Math.Pow(_shape[i].Y() - _shape[j].Y(), 2));
                    break;
                }
                else
                {
                    lenghts[i] = Math.Sqrt(Math.Pow(_shape[i].X() - _shape[i + 1].X(), 2) + Math.Pow(_shape[i].Y() - _shape[i + 1].Y(), 2));
                }
            }
            return lenghts[z];
        }
    }
    class Romb :Shape {

        public Romb(Punkt tochka1, Punkt tochka2, Punkt tochka3, Punkt tochka4)
        {
            count = 4;
            _shape = new Punkt[count];
            _shape[0] = tochka1;
            _shape[1] = tochka2;
            _shape[2] = tochka3;
            _shape[3] = tochka4;
            lenghts = new double[count];

            for (int i = 0; i < count - 1; i++)
            {
                try
                {
                    if (LenSide(_shape, i) != LenSide(_shape, i + 1))
                    {
                        throw new ArgumentException("Sides must be the same");
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("It was mistake: " + e);
                    //cerr << "Error: " << exeption << '\n';
                }
            }
        }

        public double Square()
    {
        double diag1 = Math.Sqrt(Math.Pow(_shape[3].X() - _shape[1].X(), 2) + Math.Pow(_shape[3].Y() - _shape[1].Y(), 2));
        double diag2 = Math.Sqrt(Math.Pow(_shape[2].X() - _shape[0].X(), 2) + Math.Pow(_shape[2].Y() - _shape[0].Y(), 2));
        return (diag1 * diag2) / 2;
    }
        public double Perimetr()
    {
        double per = 0;
        for (int i = 0; i < count; i++)
        {
            per += LenSide(_shape, i);
        }
        return per;
    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Punkt tochka1 = new Punkt(0,4);
           
            Punkt tochka2 = new Punkt(3, 0);
            Punkt tochka3 = new Punkt(0, -4);
            Punkt tochka4 = new Punkt(-3, 0);
            Romb romb = new Romb(tochka1, tochka2, tochka3, tochka4);
            Console.WriteLine(romb.Perimetr());
            Console.WriteLine(romb.Square());
            Console.WriteLine(romb.LenSide(1));

        }
    }
}
