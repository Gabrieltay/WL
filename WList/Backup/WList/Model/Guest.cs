using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WList.Model
{
    [Serializable]
    public class Guest
    {
        public Guest()
        {
            this.ID = 0;
            this.Name = "";
            this.Category = "";
            this.Table = 0;
            this.CheckIn = false;
        }

        public Guest( int aID, String aName, String aCategory, int aTable )
        {
            this.ID = aID;
            this.Name = aName;
            this.Category = aCategory;
            this.Table = aTable;
            this.CheckIn = false;
        }

        // Shallow Copy
        public void Copy( Guest aGuest )
        {
            this.ID = aGuest.ID;
            this.Name = aGuest.Name;
            this.Category = aGuest.Category;
            this.Table = aGuest.Table;
            this.CheckIn = aGuest.CheckIn;
        }

        // Deep Copy
        public Guest Clone()
        {
            Guest nGuest = null;
            using ( MemoryStream ms = new MemoryStream() )
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize( ms, this );
                ms.Position = 0;
                nGuest = (Guest)bf.Deserialize( ms );
            }
            return nGuest;
        }

        #region Properties
        public int ID
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public String Category
        {
            get;
            set;
        }

        public int Table
        {
            get;
            set;
        }

        public Boolean CheckIn
        {
            get;
            set;
        }
        #endregion
    }
}
