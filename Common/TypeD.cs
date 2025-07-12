using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeD
    {
        private int H;
        private protected int _private_Protected;    // private //can't inheret in another project
        protected int _protected;            // private //can inheret in another projtect
        internal protected int _internal_protected;   // internal
    }
}
