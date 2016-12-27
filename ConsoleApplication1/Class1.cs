using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {
    }
    class Calc
    {
        protected virtual double Plus(double a, double b)
        {
            return a + b;
        }
        protected virtual double Minus(double a, double b)
        {
            return a - b;
        }
    }
    class OpArgs : EventArgs
    {
        public double A, B;
    }

    class Calc2 : Calc
    {
        public EventHandler<OpArgs> Plused { get; set; }
        public EventHandler<OpArgs> Minused { get; set; }
        public new double Plus(double a, double b)
        {
            Plused?.Invoke(this, new OpArgs { A = a, B = b });
            return base.Plus(a, b);
        }
        public new double Minus(double a, double b)
        {
            if (Minused != null)
            {
                Minused(this, new OpArgs { A = a, B = b });
            }
            return base.Minus(a, b);
        }
    }
}
