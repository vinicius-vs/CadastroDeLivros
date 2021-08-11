using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroLibrary.Context
{
    class BaseContext: DbContext
    {

        public BaseContext(): base("DbConectionLibrary")
        {

        }
    }
}
