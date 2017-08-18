﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using M2SA.AppGenome.AppHub;
using M2SA.AppGenome.Threading;
using M2SA.AppGenome.Reflection;

namespace M2SA.AppGenome
{
    /// <summary>
    /// Application扩展接口
    /// </summary>
    public interface IExtensionApplication
    {
        /// <summary>
        /// 
        /// </summary>
        bool AsyncStart { get; }

        /// <summary>
        /// 当应用程序初始化时触发
        /// </summary>
        /// <param name="onwer"></param>
        /// <param name="args"></param>
        void OnInit(ApplicationHost onwer, CommandArguments args);

        /// <summary>
        /// 当应用程序启用时触发
        /// </summary>
        /// <param name="onwer"></param>
        /// <param name="args"></param>
        void OnStart(ApplicationHost onwer, CommandArguments args);

        /// <summary>
        /// 当应用程序退出时触发
        /// </summary>
        /// <param name="onwer"></param>
        /// <param name="args"></param>
        void OnStop(ApplicationHost onwer, CommandArguments args);
    }
}
