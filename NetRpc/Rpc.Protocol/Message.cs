using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpc.Protocol
{
    public class Message
    {
        /*
         * http://blog.csdn.net/mindfloating/article/details/39474123
         * -- 消息头 --  
                magic      : 协议魔数，为解码设计  
                header size: 协议头长度，为扩展设计  
                version    : 协议版本，为兼容设计  
                st         : 消息体序列化类型  
                hb         : 心跳消息标记，为长连接传输层心跳设计  
                ow         : 单向消息标记，  
                rp         : 响应消息标记，不置位默认是请求消息  
                status code: 响应消息状态码  
                reserved   : 为字节对齐保留  
                message id : 消息 id  
                body size  : 消息体长度  
  
                -- 消息体 --  
                采用序列化编码，常见有以下格式  
                xml   : 如 webservie soap  
                json  : 如 JSON-RPC  
                binary: 如 thrift; hession; kryo 等  
         * */
    }
}
