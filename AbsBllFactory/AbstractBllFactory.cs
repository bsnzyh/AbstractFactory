using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace AbsBllFactory
{
    /// <summary>
    /// 业务抽象工厂类
    /// </summary>
    public abstract class AbstractBllFactory
    {
        public abstract IBLL.IMsg GetMsg();
        public abstract IBLL.IUsers GetUsers();

        public static AbstractBllFactory GetBllFactory()
        {
            string bllType = ConfigurationManager.AppSettings["bllType"];
            AbstractBllFactory bllFactory = null;
            switch (bllType)
            {
                case "blla":
                    bllFactory = new BllFactoryA();
                    break;
                case "bllb":
                    bllFactory = new BllFactoryB();
                    break;
            }
            return bllFactory;
        }
    }
}
