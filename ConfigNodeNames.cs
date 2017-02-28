using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BJMT.CTC3.Presentation
{
    /// <summary>
    /// 配置页面名称定义
    /// </summary>
    public abstract class ConfigNodeNames
    {
        #region "环境配置"
        /// <summary>
        /// 环境
        /// </summary>
        public abstract class Environment
        {
            /// <summary>
            /// 常规
            /// </summary>
            public const string General = "环境/常规";
            /// <summary>
            /// 日志
            /// </summary>
            public const string Log = "环境/日志";
            /// <summary>
            /// 系统配置
            /// </summary>
            public const string SystemConfig = "环境/系统配置";
        }
        #endregion


        #region "通信协议配置"
        /// <summary>
        /// 通信协议配置
        /// </summary>
        public abstract class CommunicationProtocol
        {
            /// <summary>
            /// SRTP
            /// </summary>
            public const string SRTP = "通讯协议.SRTP";
            /// <summary>
            /// NxSafeComm
            /// </summary>
            public const string NxSafeComm = "通讯协议.NxSafeComm";

        }
        #endregion


        #region "插件管理"
        /// <summary>
        /// 插件管理
        /// </summary>
        public abstract class Plugins
        {
            /// <summary>
            /// 双机热备
            /// </summary>
            public abstract class HotStandby
            {
                /// <summary>
                /// General
                /// </summary>
                public const string General = "插件.双机热备.常规";
            }

            /// <summary>
            /// ATS内部通信
            /// </summary>
            public abstract class ATSCommunication
            {
                /// <summary>
                /// General
                /// </summary>
                public const string General = "插件.ATS通信.常规";
            }

            /// <summary>
            /// 报警
            /// </summary>
            public abstract class Alarm
            {
                /// <summary>
                /// General
                /// </summary>
                public const string General = "插件.报警.常规";
            }
        }
        #endregion

    }
}
