using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PruebaCristianHiguita.TOs
{
    [DataContract]
    public class AnimalesTO
    {
         [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Tipo { get; set; }
    }
}