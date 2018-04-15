using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PruebaCristianHiguita.TOs
{
    [DataContract]
    public class AnimalesPacketTO
    {
        [DataMember]
        public List<AnimalesTO> AnimalesTO { get; set; }

        [DataMember]
        public string RespError { get; set; }
    }
}