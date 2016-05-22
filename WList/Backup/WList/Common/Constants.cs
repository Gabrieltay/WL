using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using WList.Controller;

namespace WList.Common
{
    public class Constants
    {
        public const String DATA_FILE = "myData.bin";

        public const String CSV_FILE = "myList.csv";

        public const String PIC_FILE = "sample.jpg";

        public const int AUTOSAVE_INTERVAL = 1000 * 60 * 2; // 2 Minutes

        public static String User
        {
            get
            {
                return ConfigReader.Instance().User;
            }
        }

        public static List<String> CategoryList
        {
            get
            {
                return ConfigReader.Instance().Categories;

            }
        }

        public static int MaxTables
        {
            get
            {
                return ConfigReader.Instance().MaxTables;
            }
        }

        public static List<String> MaxTablesList
        {
            get
            {
                List<String> nMaxTablesList = new List<String>();
                for ( int i = 1; i <= ConfigReader.Instance().MaxTables; i++ )
                    nMaxTablesList.Add( i.ToString() );
                return nMaxTablesList;
            }
        }
    }
}
