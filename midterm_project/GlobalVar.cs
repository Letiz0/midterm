using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_project
{
    class GlobalVar
    {
        public static Form1 form1;
        public static FormMain formMain;
        public static btn提交申請 formSearch;
        public static Publish formPublish;
        public static Member formMember;
        public enum orderStatus
        {
            等待接受 = 0,
            交易中 = 1,
            拒絕 = 2,
            完成 = 3,
            取消交易 = 4,
            取消申請 = 5
        }
    }
}
