using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public int ID{ get; set;}

        [DataMember]
        public int growth { get; set; }

        [DataMember]
        public int weight { get; set; }

        [DataMember]
        public int age { get; set; }

        [DataMember]
        public bool gender { get; set; }
    }
}
