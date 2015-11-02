using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace FakeAbsFactory
{
    /// <summary>
    /// 简单工厂，提供众多 简单工厂方法，来创建 不同的 业务接口对象
    /// </summary>
    public class BLLFactoryFake
    {
        public IBLL.IUsers GetBllUser()
        {
            string bllType = ConfigurationManager.AppSettings["bllType"];
            if (bllType == "bll")
            {
                return new BLLA.Users();
            }
            else
            {
                return new BLLB.Users();
            }
        }

        public IBLL.IMsg GetBllMsg()
        {
            string bllType = ConfigurationManager.AppSettings["bllType"];
            if (bllType == "bll")
            {
                return new BLLA.Msg();
            }
            else
            {
                return new BLLB.Msg();
            }
        }
    }
}
