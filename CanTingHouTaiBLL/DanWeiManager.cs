﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanTingHouTaiDAL;
using CanTingModes;

namespace CanTingHouTaiBLL
{
    public class DanWeiManager
    {
        DanWeiSeriver danWeiSeriver = new DanWeiSeriver();
        public List<DanWei> LoadDanWei() {
            return danWeiSeriver.LoadDanWei();
        }
    }
}
