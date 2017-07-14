using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpc.Protocol
{
    /// <summary>
    /// 编码
    /// </summary>
    public class Encoding
    {
        public MethodInfo InvokeMethodInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public MethodParameter MethodParams { get; set; }
    }

    public class MethodInfo {
        /// <summary>
        /// 
        /// </summary>
        public string InterfaceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MethodName { get; set; }
    }


    public class MethodParameter {
        public string ParameterType { get; set; }

        /// <summary>
        /// 参数名称
        /// </summary>
        public string ParameterName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParameterValue { get; set; }
    }

    public class InvokeProperty
    {
        /// <summary>
        /// 调用类型
        /// </summary>
        public string InvokeType { get; set; }
    }
}
