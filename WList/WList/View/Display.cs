using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WList.Model;

namespace WList.View
{
    public partial class Display : Form
    {
        private Boolean mNoClose = false;

        private const int OFFSET = 20;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute( "user32.dll" )]
        public static extern int SendMessage( IntPtr hWnd,
            int Msg, int wParam, int lParam );

        [DllImportAttribute( "user32.dll" )]
        public static extern bool ReleaseCapture();

        public Display( Guest aGuest )
        {
            InitializeComponent(); 
            InitializeTimer();

            this.UpdateGuest = aGuest;
            this.mNameLabel.Text = aGuest.Name;
            this.mCategoryLabel.Text = aGuest.Category;
            this.mTableLabel.Text = aGuest.Table.ToString();
            if ( aGuest.CheckIn )
                this.mCheckLabel.ImageKey = "check";
            else
                this.mCheckLabel.ImageKey = "uncheck";

            InitializeLabelsPos();
            InitializeLocation();
        }

        private void InitializeTimer()
        {
            Timer nTimer = new Timer();
            nTimer.Tick += new EventHandler( CloseTimer );
            nTimer.Interval = 3000;
            nTimer.Start();
        }

        private void InitializeLabelsPos()
        {
            if ( this.mNameLabel.Width > this.Width )
                this.Width = this.mNameLabel.Width + OFFSET;

            int nNameX = (this.Width / 2) - (this.mNameLabel.Width / 2);
            this.mNameLabel.Location = new Point( nNameX, this.mNameLabel.Location.Y );

            int nCatX = (this.Width / 2) - (this.mCategoryLabel.Width / 2);
            this.mCategoryLabel.Location = new Point( nCatX, this.mCategoryLabel.Location.Y );

            int nTableX = (this.Width / 2) - (this.mTableLabel.Width / 2);
            this.mTableLabel.Location = new Point( nTableX, this.mTableLabel.Location.Y );
        }

        private void InitializeLocation()
        {
            int posY;

            if ( Cursor.Position.Y + this.Height + OFFSET > Screen.PrimaryScreen.Bounds.Height )
            {
                posY = Cursor.Position.Y - this.Height - OFFSET;
            }
            else
            {
                posY = Cursor.Position.Y + OFFSET;
            }

            this.Location = new Point( Cursor.Position.X, posY );    
         }

        private void CloseTimer( object sender, EventArgs e )
        {
            if ( !mNoClose )
            {
                this.Close();
            }
            mNoClose = false;
        }

        private void CloseButton_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void Display_MouseDown( object sender, MouseEventArgs e )
        {
            mNoClose = true;
            if ( e.Button == MouseButtons.Left )
            {
                ReleaseCapture();
                SendMessage( Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0 );
            }
        }

        private void mCheckLabel_Click( object sender, EventArgs e )
        {
            mNoClose = true;
            if ( this.UpdateGuest.CheckIn )
            {
                this.mCheckLabel.ImageKey = "uncheck";
                this.UpdateGuest.CheckIn = false;
            }
            else
            {
                this.mCheckLabel.ImageKey = "check";
                this.UpdateGuest.CheckIn = true;
            }
        }

        public Guest UpdateGuest
        {
            get;
            set;
        }
    }
}
