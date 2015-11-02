using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbsDalFactory
{
    public class DalFactoryB : AbstractDalFactory
    {

        public override IDAL.IUsers GetDalUsers()
        {
          return  new DALB.Users();
        }

        public override IDAL.IMsg GetDalMsg()
        {
            return new DALB.Msg();
        }
    }
}
