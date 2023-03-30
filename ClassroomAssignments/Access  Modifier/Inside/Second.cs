using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inside
{
    public class Second : First  //Inheritance
    {
        public int ProtectedSecond { get{return ProtectedNumber;}}
    }
}