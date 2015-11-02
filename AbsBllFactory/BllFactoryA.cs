using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbsBllFactory
{
   public class BllFactoryA:AbstractBllFactory
    {
        public override IBLL.IMsg GetMsg()
        {
            return new BLLA.Msg();
        }

        public override IBLL.IUsers GetUsers()
        {
            return new BLLA.Users();
        }
    }
}
