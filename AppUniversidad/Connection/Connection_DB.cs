using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUniversidad.Connection
{
    internal abstract class Connection_DB
    {
        private readonly string conecction;

        public Connection_DB()
        {
            conecction = @"";
        }
    }
}
