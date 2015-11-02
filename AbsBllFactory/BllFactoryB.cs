using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbsBllFactory
{
    public class BllFactoryB : AbstractBllFactory
    {
        public override IBLL.IMsg GetMsg()
        {
            return new BLLB.Msg();
        }

        public override IBLL.IUsers GetUsers()
        {
            return new BLLB.Users();
        }
    }
}
