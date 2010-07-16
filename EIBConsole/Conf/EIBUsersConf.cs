﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace EIBConsole.Conf
{
    [XmlRoot("Root")]
    public class EIBUsersConf
    {
        public const int USER_POLICY_READ_ACCESS = 0x1;
        public const int USER_POLICY_WRITE_ACCESS = 0x2;
        public const int USER_POLICY_CONSOLE_ACCESS = 0x4;
        
        public EIBUsersConf() : base()
        {
            this.List = new List<EIBUserConf>();
        }

        [XmlArray(ConsoleDefinitions.EIBServerUsersConf.EIB_SERVER_USERS_LIST_XML)]
        [XmlArrayItem(ConsoleDefinitions.EIBServerUsersConf.EIB_SERVER_USER_XML)]
        public List<EIBUserConf> List { get; set; }
    }


    [XmlRoot(ConsoleDefinitions.EIBServerUsersConf.EIB_SERVER_USER_XML)]
    public class EIBUserConf
    {
        string _ip_address;
        [XmlElement(ConsoleDefinitions.EIBServerUsersConf.EIB_SERVER_USER_IP_ADDRESS_XML)]
        public string Ip_address
        {
            get 
            {
                if (_ip_address == string.Empty)
                {
                    return "0.0.0.0";
                }
                return _ip_address; 
            }
            set { _ip_address = value; }
        }

        [XmlElement(ConsoleDefinitions.EIBServerUsersConf.EIB_SERVER_USER_NAME_XML)]
        public string Name { get; set; }
        [XmlElement(ConsoleDefinitions.EIBServerUsersConf.EIB_SERVER_USER_PASSWORD_XML)]
        public string Password { get; set; }
        [XmlElement(ConsoleDefinitions.EIBServerUsersConf.EIB_SERVER_USER_IS_CONNECTED_XML)]
        public bool Connected { get; set; }
        [XmlElement(ConsoleDefinitions.EIBServerUsersConf.EIB_SERVER_USER_SESSION_ID_XML)]
        public int SessionId { get; set; }
        [XmlElement(ConsoleDefinitions.EIBServerUsersConf.EIB_SERVER_USER_PRIVILIGES_XML)]
        public int Priviliges { get; set; }
        [XmlElement(ConsoleDefinitions.EIBServerUsersConf.EIB_SERVER_USER_SOURCE_ADDR_MASK_XML)]
        public ushort SrcMask { get ; set; }
        [XmlElement(ConsoleDefinitions.EIBServerUsersConf.EIB_SERVER_USER_DST_ADDR_MASK_XML)]
        public ushort DstMask { get; set;}
        
    }
}
