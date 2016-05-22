using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using WList.Model;

namespace WList.Controller
{
    public class CsvController
    {
        private char[] Delimiters = new char[] { ',' };

        private String mCurLine;

        private String mFilePath;

        public CsvController( String aFilePath )
        {
            mFilePath = aFilePath;
        }

        public List<Guest> Read()
        {
            StreamReader mReader = new StreamReader( mFilePath );
            List<Guest> nGuestList = new List<Guest>();
            mCurLine = mReader.ReadLine();

            while ( mCurLine != null )
            {
                String[] nStrArray = mCurLine.Split( Delimiters );
                if ( nStrArray.Length < 4 )
                    continue;
                Guest nGuest = new Guest();
                nGuest.ID = int.Parse( nStrArray[0] );
                nGuest.Name = nStrArray[1];
                nGuest.Category = nStrArray[2];
                nGuest.Table = int.Parse( nStrArray[3] );
                if ( nStrArray.Length == 5 )
                    nGuest.CheckIn = nStrArray[4].Equals( "1" ) ? true : false;
                nGuestList.Add( nGuest );
                mCurLine = mReader.ReadLine();
            }
            mReader.Dispose();
            return nGuestList;
        }

        public void Write( List<Guest> aGuestList )
        {
            StreamWriter mWriter = new StreamWriter( mFilePath );
            foreach ( Guest nGuest in aGuestList )
            {
                mWriter.Write( nGuest.ID );
                mWriter.Write( Delimiters );
                mWriter.Write( nGuest.Name );
                mWriter.Write( Delimiters );
                mWriter.Write( nGuest.Category );
                mWriter.Write( Delimiters );
                mWriter.Write( nGuest.Table );
                mWriter.Write( Delimiters );
                if ( nGuest.CheckIn )
                    mWriter.Write( "1" );
                else
                    mWriter.Write( "0" );
                mWriter.WriteLine();
            }
            mWriter.Dispose();
        }
    }
}
