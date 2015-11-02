using FakeAbsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            //1.读取数据 通过业务层（业务接口层）
            IBLL.IUsers bllUsers = new BLLFactoryFake().GetBllUser();
            //2.调用 业务接口 读取数据
            List<MODEL.Users> users = bllUsers.GetUserList();
           
        }
    }
}