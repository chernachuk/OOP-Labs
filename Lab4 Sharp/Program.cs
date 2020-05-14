using System;


namespace Lab4_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector Z1= new Vector();
            Vector Z2=new Vector(3, 45);
            Vector Z3 = new Vector(Z2);
            Z2.Turn(90);           
            Console.WriteLine(Z1.Radius() + "   " + Z1.Angle());                      
            Console.WriteLine(Z2.Radius() + "   " + Z2.Angle());
            Console.WriteLine(Z3.Radius() + "   " + Z3.Angle());
            Z3 = Z3 * 2;
            Console.WriteLine(Z3.Radius() + "   " + Z3.Angle());
            Z1 = Z2 + Z3; 
            Console.WriteLine(Z1.Radius() + "   " + Z1.Angle());                      
        }
    }

    class Vector
    {
        private double r;
        private double fi;

        public Vector()
        {
            r = 0;
            fi = 0;
        }
        public Vector(double r,double fi)
        {
            this.r = r;
            this.fi = fi;
        }
        public Vector(Vector vec)
        {
            r = vec.r;
            fi = vec.fi;
        }
        public void Turn(double fi)
        {
            this.fi += fi;
        }
        public double Radius()
        {
            return this.r;
        }
        public double Angle()
        {
            return this.fi;
        }
        public static Vector operator *(Vector vec, double a) => new Vector(r: vec.r * a, fi: vec.fi);
        public static Vector operator *(double a,Vector vec) => vec * a;
        public static Vector operator +(Vector vec1, Vector vec2)
        {
            //const double PI = 3.141592653589793;
            double x1 = vec1.r * Math.Cos(vec1.fi * Math.PI / 180);
            double y1 = vec1.r * Math.Sin(vec1.fi * Math.PI / 180);
            double x2 = vec2.r * Math.Cos(vec2.fi * Math.PI / 180);
            double y2 = vec2.r * Math.Sin(vec2.fi * Math.PI / 180);
            Vector tmp=new Vector();
            tmp.r = Math.Sqrt((x1 + x2)* (x1 + x2) + (y1 + y2)* (y1 + y2));
            tmp.fi = Math.Atan((y1 + y2) / (x1 + x2)) * 180 / Math.PI;
            return tmp;
        }
    }
}
