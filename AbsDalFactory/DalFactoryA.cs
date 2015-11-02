using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbsDalFactory
{
    public class DalFactoryA : AbstractDalFactory
    {

        public override IDAL.IUsers GetDalUsers()
        {
            return new DALA.Users();
        }

        public override IDAL.IMsg GetDalMsg()
        {
            return new DALA.Msg();
        }
    }
}
