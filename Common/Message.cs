using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
    public class Message
    {
        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public DateTime TimeStamp { get; set; }

        [DataMember]
        public SeverityLevel Level { get; set; }

        [DataMember]
        public string Content { get; set; }
    }
}
