using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WList.Model
{
    public class Table
    {
        private int mAttended = 0;

        public Table( int aTableID )
        {
            this.TableID = aTableID;
            this.TableGuest = new List<Guest>();
        }

        public void AddGuest( Guest aGuest )
        {
            this.TableGuest.Add( aGuest );
            if ( aGuest.CheckIn )
            {
                this.Attended++;
            }

        }

        #region Properties
        public int TableID
        {
            get;
            set;
        }

        public List<Guest> TableGuest
        {
            get;
            set;
        }

        public int Total
        {
            get
            {
                return this.TableGuest.Count;
            }

        }

        public int Attended
        {
            get
            {
                return this.mAttended;
            }
            set
            {
                this.mAttended = value;
            }
        }
        #endregion
    }
}
