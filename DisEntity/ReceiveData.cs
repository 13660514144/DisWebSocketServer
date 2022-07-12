using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisEntity
{
    /// <summary>
    /// 接收到的数据
    /// </summary>
    [Serializable]
    public class ReceiveData
    {
        /// <summary>
        /// 接受到的数据类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 接收到的信息
        /// </summary>
        public string Msg { get; set; }
    }
}
