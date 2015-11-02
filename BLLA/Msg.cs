using AbsDalFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLLA
{
    public class Msg : IBLL.IMsg
    {
        /// <summary>
        /// 数据抽象工厂 - 由抽象工厂类的 静态方法创建   : 父类 obj = new 子类（）；
        /// </summary>
        AbsDalFactory.AbstractDalFactory dalFactory = AbstractDalFactory.GetDalFactory();
        public List<MODEL.Msg> GetMsgList()
        {
            //1.调用数据层 接口  查询数据 并放回   ： 父类 obj = new 子类();  ->   IDAL.IMsg dalMsg = new DAL.Msg();
            IDAL.IMsg dalMsg = dalFactory.GetDalMsg();
            //2.调用数据接口方法 查询数据 并返回
            return dalMsg.GetList();
        }
    }
}
