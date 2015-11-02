using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace AbsDalFactory
{
    public abstract class AbstractDalFactory
    {
        public static AbstractDalFactory GetDalFactory()
        {
            string dalType = ConfigurationManager.AppSettings["dalType"];
            AbstractDalFactory dalFactory = null;
            switch (dalType)
            {
                case "dala":
                    dalFactory = new DalFactoryA();
                    break;
                case "dalb":
                    dalFactory = new DalFactoryB();
                    break;
            }
            return dalFactory;
        }

        public abstract IDAL.IUsers GetDalUsers();
        public abstract IDAL.IMsg GetDalMsg();

    }
}
