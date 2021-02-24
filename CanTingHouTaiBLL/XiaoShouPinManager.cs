﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanTingHouTaiDAL;
using CanTingModes;

namespace CanTingHouTaiBLL
{
    public class XiaoShouPinManager//销售品业务层
    {
        XiaoShouPinSeriver xiaoShouPinSeriver = new XiaoShouPinSeriver();
        /// <summary>
        /// 返回销售品的数据
        /// </summary>
        /// <returns></returns>
        public List<CaiPin> SearchXiaoShouPin(int caiPinFenLeiId=-1,int count=1) {
            return xiaoShouPinSeriver.SearchXiaoShouPin(caiPinFenLeiId,count);
        }
        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="caiPinId"></param>
        /// <returns></returns>
        public int DeleteXiaoShouPin(int caiPinId) {
            return xiaoShouPinSeriver.DeleteXiaoShouPin(caiPinId);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="caiPin"></param>
        /// <returns></returns>
        public int ChangerXiaoShouPin(CaiPin caiPin)
        {
            return xiaoShouPinSeriver.ChangerXiaoShouPin(caiPin);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="caiPin"></param>
        /// <returns></returns>
        public int AddXiaoShouPin(CaiPin caiPin) {
            return xiaoShouPinSeriver.AddXiaoShouPin(caiPin);
        }

    }
}
