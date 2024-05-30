using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Ejemplo1
{
    public class TV : IProduct
    {
        public void Accept(IProductVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
