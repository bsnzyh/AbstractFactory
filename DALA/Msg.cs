using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DALA
{
    public class Msg : IDAL.IMsg
    {
        public List<MODEL.Msg> GetList()
        {
            List<MODEL.Msg> list = new List<MODEL.Msg>() { 
             new MODEL.Msg(){ MsgID=1, MsgContent="小白", FromUserID=1},
             new MODEL.Msg(){ MsgID=2, MsgContent="小白1", FromUserID=1},
             new MODEL.Msg(){ MsgID=3, MsgContent="小白2", FromUserID=1},
             new MODEL.Msg(){ MsgID=4, MsgContent="小白3", FromUserID=1},
             new MODEL.Msg(){ MsgID=5, MsgContent="小白4", FromUserID=1},
             new MODEL.Msg(){ MsgID=6, MsgContent="小白5", FromUserID=1}
            };
            return list;
        }
    }
}
