using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanTingModes;
using CanTingHouTaiDAL;

namespace CanTingHouTaiBLL
{
    public class YuanGongMessageAddManager
    {
        private YuanGongMessageAddServer ygmas = new YuanGongMessageAddServer();

        /// <summary>
        /// 新员工信息的添加
        /// </summary>
        /// <param name="yg"></param>
        /// <returns></returns>
        public int AddYuanGongMessage(YuanGong yg)
        {
            return ygmas.YuanGongMessageAdd(yg);
        }

        /// <summary>
        /// 员工信息的修改
        /// </summary>
        /// <param name="yg"></param>
        /// <param name="ygId"></param>
        /// <returns></returns>
        public int UpdateYuanGong(YuanGong yg, int ygId)
        {
            return ygmas.UpdateYuanGongMessage(yg, ygId);
        }

        public List<YuanGong> PrintMessageTxt(int ygId)
        {
            return ygmas.PrintMessageText(ygId);
        }
        public int DelYuanGongMessage(int ygId)
        {
            return ygmas.DelYuanGongMessage(ygId);
        }

        public List<YuanGong> SelectDgvMessage(string ygName = "", bool nan = false, bool nv = false)
        {
            return ygmas.SelectPrintDgv(ygName, nan, nv);
        }

        /// <summary>
        /// 员工职位下拉框的显示
        /// </summary>
        /// <returns></returns>
        public List<ZhiWei> YgZhiWeiComboBox()
        {
            return ygmas.YuanGongZhiWeiComboBox();
        }
    }
}
