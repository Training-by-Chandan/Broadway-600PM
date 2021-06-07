using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway600PM
{
    public class Deleg
    {
        public delegate double Operation(double x, double y);
        public event Operation OperationHandler;


        public void Run(double a, double b)
        {
            OperationHandler?.Invoke(a, b);
        }
    }
}
