using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Ejemplo1
{
    public interface IProductVisitor
    {
        void Visit(TV tv);
        void Visit(Phone phone);
        void Visit(Computer computer);
    }
}
