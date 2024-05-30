using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Ejemplo1
{
    public interface IProduct
    {
        void Accept(IProductVisitor visitor);
    }
}
