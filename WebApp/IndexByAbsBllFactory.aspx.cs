using AbsBllFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class IndexByAbsBllFactory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
            //通过 抽象工厂的 静态方法，读取配置文件，并获取一个 实体工厂(具体的业务工厂)对象
            AbstractBllFactory bllFactory = AbstractBllFactory.GetBllFactory();
            //1.读取数据 通过业务层（业务接口层）--- 使用 抽象工厂 的方法获取一个 实体产品
            IBLL.IMsg bllMsg = bllFactory.GetMsg();//方法覆盖
            //2.调用 业务接口 读取数据  --- 通过 抽象产品 调用 业务方法
            List<MODEL.Msg> msgs = bllMsg.GetMsgList();
            Response.Write(msgs.Count);
        }
    }
}