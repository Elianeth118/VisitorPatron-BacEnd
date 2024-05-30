using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Ejemplo1
{
    public class RepairService:IProductVisitor
    {
        public void Visit(TV tv)
        {
            Console.WriteLine("Reparando TV");
        }
        public void Visit(Phone phone) 
        {
            Console.WriteLine("Reparando Telefono");
        }
        public void Visit(Computer computer)
        {
            Console.WriteLine("Reparando computadora");
        }
    }
}
