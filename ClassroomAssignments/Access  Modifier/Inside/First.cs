using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outside;//mention namespace of added reference

namespace Inside
{
    //class creation
    public class First : Third //inheritance
    {
        //public  element
        public int PublicNumber=10;
        //private element
        private int PrivateNumber=20;
        public int PrivateOut{get{return PrivateNumber;}}
        //internal element
        internal int InternalNumber=30;
        //protected element
        protected int ProtectedNumber=40;
        public int ProtectedFirst { get{return ProtectedNumber;}}

        //protected internal element
        public int ProtectedInternalOut{get{return ProtectedInternalNumber;}}
    }
}