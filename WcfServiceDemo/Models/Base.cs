using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceDemo.Models
{
    [DataContract]
    public class Base
    {
        [DataMember]
        public int Success { get; set; }
        public string Message { get; set; }
    }
}