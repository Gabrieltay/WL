using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WList.Model;
using WList.Common;

namespace WList.View
{
    public partial class StatsForm : Form
    {
        private const String NEWLINE = "\n";

        public StatsForm()
        {
            InitializeComponent();
        }

        public StatsForm( List<Guest> aGuestList )
        {
            InitializeComponent();
            this.olvColumn1.AspectGetter = delegate( object rowObject )
            {
                return (String)rowObject;
            };
            this.olvColumn1.Width = this.listBox1.Width - 30;
            GenerateStats( aGuestList );
        }

        private void GenerateStats( List<Guest> aGuestList )
        {
            Dictionary<int, Table> nTablesDict = new Dictionary<int, Table>();
            for ( int i = 1; i <= Constants.MaxTables; i++ )
            {
                nTablesDict.Add( i, new Table( i ) );
            }
            foreach ( Guest nGuest in aGuestList )
            {
                Table nTable;
                if ( nTablesDict.TryGetValue( nGuest.Table, out nTable ) )
                {
                    nTable.AddGuest( nGuest );
                }
            }

            for ( int i = 1; i <= Constants.MaxTables; i++ )
            {
                Table nTable;
                if ( nTablesDict.TryGetValue( i, out nTable ) )
                {
                    if ( nTable.Total != 0 )
                        this.listBox1.AddObject( "Table " + i + " : " + nTable.Attended + "/" + nTable.Total + "\n" );
                }
            }
        }
    }
}
