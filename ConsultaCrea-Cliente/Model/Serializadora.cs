﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsultaCrea_Cliente.Model
{
    public class Serializadora
    {

        public string WsAdIvnd { get; set; } // web service
        public string SvrIvnd { get; set; } // server DB
        public string DBIvnd { get; set; } // DB name
        public string UsrIvnd { get; set; } // user DB
        public string PassIvnd { get; set; } // pass DB

        public Serializadora()
        {
            WsAdIvnd = "";
            SvrIvnd = "";
            DBIvnd = "";
            UsrIvnd = "";
            PassIvnd = "";
        }

        public void EscribirObjeto(string NombreArchivo) 
        {
            using(var stream  = new FileStream(NombreArchivo, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(Serializadora));
                XML.Serialize(stream, this);
            }
        }

        public static Serializadora LeerObjeto(string NombreArchivo) 
        {
            using (var stream = new FileStream(NombreArchivo, FileMode.Open))
            {
                var XML = new XmlSerializer(typeof(Serializadora));
                return (Serializadora)XML.Deserialize(stream);
            }
        }
    }
}
