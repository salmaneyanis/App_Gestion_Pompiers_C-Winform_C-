﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SAE_POMPIER_A21
{
    public class MesDatas
    {
        private static DataSet dsGlobal = new DataSet();
     
        public static DataSet DsGlobal { get {  return MesDatas.dsGlobal; } }

    }
}
