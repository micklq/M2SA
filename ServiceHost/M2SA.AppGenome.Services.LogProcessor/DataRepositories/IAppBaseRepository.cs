﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using M2SA.AppGenome.Data;

namespace M2SA.AppGenome.Services.LogProcessor.DataRepositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAppBaseRepository : IRepository<AppBase, int>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="appName"></param>
        /// <returns></returns>
        AppBase FindByName(string appName);
    }
}
