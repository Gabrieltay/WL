using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml;
using System.Text;

namespace WList.Controller
{
    public class ConfigReader
    {
        #region Constant Strings
        private const String CONFIG_FILENAME = "Config.xml";

        private const String CONFIG_ROOT = "CONFIG";

        private const String USER = "USER";

        private const String MAX_TABLES = "MAX_TABLES";

        private const String CATEGORIES = "CATEGORIES";

        #endregion

        private static ConfigReader mInstance = null;

        private XmlDocument mXmlDoc = null;

        private XmlElement mXmlRootNode = null;

        private ConfigReader()
        {
            this.mXmlDoc = new XmlDocument();
            this.mXmlDoc.Load( CONFIG_FILENAME );
            this.mXmlRootNode = (XmlElement)this.mXmlDoc.FirstChild;
        }

        public static ConfigReader Instance()
        {
            if ( mInstance == null )
            {
                mInstance = new ConfigReader();
            }
            return mInstance;
        }

        public String User
        {
            get
            {
                XmlElement nNode = GetChildElement( this.mXmlRootNode, USER );
                if ( nNode != null )
                {
                    return nNode.InnerText;
                }
                else
                    return "";
            }
        }

        public int MaxTables
        {
            get
            {
                XmlElement nNode = GetChildElement( this.mXmlRootNode, MAX_TABLES );
                if ( nNode != null )
                {
                    return int.Parse( nNode.InnerText );
                }
                else
                    return 0;
            }
        }

        public List<String> Categories
        {
            get
            {
                List<String> nList = new List<String>();
                XmlElement nNode = GetChildElement( this.mXmlRootNode, CATEGORIES );
                if ( nNode != null )
                {
                    String nValue = nNode.InnerText;
                    nList = nValue.Split( ',' ).ToList<String>();
                }
                return nList;
            }
        }

        private XmlElement GetChildElement( XmlNode aParentNode, String aNodeName )
        {
            XmlElement nNode = null;
            foreach ( XmlNode nChildNode in aParentNode.ChildNodes )
            {
                if ( nChildNode.Name.Equals( aNodeName ))
                {
                    nNode = (XmlElement)nChildNode;
                    break;
                }
            }
            return nNode;
        }

    }
}
