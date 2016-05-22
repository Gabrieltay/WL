using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using BrightIdeasSoftware;
using WList.Model;
using WList.View;
using WList.Controller;
using WList.Common;
using Gabriel.Base;

namespace WList
{
    public partial class Mainform : Form
    {
        private int mCheckIns = 0;

        public Mainform()
        {
            InitializeComponent();
            InitializeColumns();
            InitializeSorting();
            InitializeHotStyle();
            InitializeData();
            InitializePictureBox();
            InitializeAutosaveTimer();
            RefreshGuestsCount();
        }

        #region Initialize
        private void InitializeData()
        {
            try
            {
                List<Guest> nGuestList = DataManager.GetListFromFile<Guest>( Constants.DATA_FILE );
                if ( nGuestList != null )
                {
                    this.objectListView1.SetObjects( nGuestList );
                    this.objectListView1.Sort( this.CategoryColumn );
                    foreach ( Guest nGuest in nGuestList )
                    {
                        if ( nGuest.CheckIn )
                            this.mCheckIns++;
                    }
                }
            }
            catch ( IOException )
            {
            }
        }

        private void InitializeColumns()
        {
            TypedObjectListView<Guest> tlist = new TypedObjectListView<Guest>( this.objectListView1 );
            tlist.GenerateAspectGetters();

            this.CategoryColumn.GroupKeyGetter = delegate( object rowObject )
            {
                Guest nGuest = (Guest)rowObject;
                return nGuest.Category;
            };

            this.TableColumn.GroupKeyGetter = delegate( object rowObject )
            {
                Guest nGuest = (Guest)rowObject;
                return "ID " + nGuest.Table;
            };

            this.CheckinColumn.ImageGetter = delegate( object rowObject )
            {
                return ((Guest)rowObject).CheckIn ? "check" : "uncheck";
            };

        }

        private void InitializeSorting()
        {
            if ( this.objectListView1.ShowGroups )
            {
                this.objectListView1.PrimarySortColumn = this.CategoryColumn;
                this.objectListView1.SecondarySortColumn = this.TableColumn;
            }
            else
            {
                this.objectListView1.PrimarySortColumn = this.NameColumn;
                this.objectListView1.SecondarySortColumn = this.CategoryColumn;
            }
        }

        private void InitializeHotStyle()
        {
            HotItemStyle nHotItemStyle = new HotItemStyle();
            RowBorderDecoration rbd = new RowBorderDecoration();
            rbd.BorderPen = new Pen( Color.LightBlue, 2 );
            rbd.FillBrush = null;
            rbd.CornerRounding = 16.0f;
            nHotItemStyle.Decoration = rbd;
            this.objectListView1.HotItemStyle = nHotItemStyle;
        }

        private void InitializePictureBox()
        {
            if ( File.Exists( Constants.PIC_FILE ) )
            {
                Image nImage = Image.FromFile( Constants.PIC_FILE );
                this.mPicturebox.Image = nImage;
            }
        }

        private void InitializeAutosaveTimer()
        {
            Timer nAutoSaveTimer = new Timer();
            nAutoSaveTimer.Interval = Constants.AUTOSAVE_INTERVAL;
            nAutoSaveTimer.Tick += new EventHandler( Timer_AutoSave );
            nAutoSaveTimer.Start();
        }
        #endregion

        #region Refresh UI Controls
        private void RefreshColumns()
        {
            this.objectListView1.Width = this.Width / 2;

            this.mSearchBox.Bounds = new Rectangle( this.mSearchBox.Location,
                new Size( this.Width / 2 - this.mSearchBox.Location.X, this.mSearchBox.Height ) );

            this.mStatsButton.Location = new Point( this.Width / 2 + 10, this.mStatsButton.Location.Y );

            // IDColumn
            this.IDColumn.Width = this.objectListView1.Width * 1 / 12;

            // NameColumn
            this.NameColumn.Width = this.objectListView1.Width * 9 / 24;

            // CategoryColumn
            this.CategoryColumn.Width = this.objectListView1.Width * 4 / 12;

            // TableColumn
            this.TableColumn.Width = this.objectListView1.Width * 1 / 12;

            // CheckInColumn
            this.CheckinColumn.Width = this.objectListView1.Width * 1 / 12;
        }

        private void RefreshGuestsCount()
        {
            int nTotalGuests = this.objectListView1.Objects.Cast<Guest>().Count();
            if ( nTotalGuests != 0 )
            {
                this.mStatsLabel.Text = String.Format( " {0} / {1} ", this.mCheckIns, nTotalGuests );
                this.mPercentLabel.Text = String.Format( " {0} %", this.mCheckIns * 100 / nTotalGuests );
            }
        }

        #endregion

        #region Event Handlers
        private void objectListView1_CellClick( object sender, CellClickEventArgs e )
        {
            if ( e.RowIndex == -1 )
                return;

            if ( e.ColumnIndex == 4 )
            {
                Guest nGuest = (Guest)this.objectListView1.GetModelObject( e.RowIndex );
                if ( nGuest.CheckIn )
                {
                    nGuest.CheckIn = false;
                    this.mCheckIns--;
                }
                else
                {
                    nGuest.CheckIn = true;
                    this.mCheckIns++;
                }
                this.objectListView1.RefreshObject( nGuest );
                RefreshGuestsCount();
            }
            else
            {
                Guest nGuest = (Guest)this.objectListView1.GetModelObject( e.RowIndex );
                Display nDisplay = new Display( nGuest );
                nDisplay.Show();
            }
        }

        private void objectListView1_ColumnClick( object sender, ColumnClickEventArgs e )
        {
            if ( e.Column == 0 ) // ID Column
            {
                this.objectListView1.ShowGroups = false;
                this.objectListView1.PrimarySortColumn = this.IDColumn;
                this.objectListView1.SecondarySortColumn = this.NameColumn;
                this.objectListView1.UseAlternatingBackColors = true;
            }
            else if ( e.Column == 1 ) // Name Column
            {
                this.objectListView1.ShowGroups = false;
                this.objectListView1.PrimarySortColumn = this.NameColumn;
                this.objectListView1.SecondarySortColumn = this.CategoryColumn;
                this.objectListView1.UseAlternatingBackColors = true;
            }
            else if ( e.Column == 2 ) // Category Column
            {
                this.objectListView1.ShowGroups = true;
                this.objectListView1.PrimarySortColumn = this.CategoryColumn;
                this.objectListView1.SecondarySortColumn = this.TableColumn;
                this.objectListView1.UseAlternatingBackColors = false;
            }
            else if ( e.Column == 3 ) // Table Column
            {
                this.objectListView1.ShowGroups = true;
                this.objectListView1.PrimarySortColumn = this.TableColumn;
                this.objectListView1.SecondarySortColumn = this.NameColumn;
                this.objectListView1.UseAlternatingBackColors = false;
            }

            this.objectListView1.Sort();
        }

        private void mSearchBox_TextChanged( object sender, EventArgs e )
        {
            TextMatchFilter nFilter = null;
            nFilter = TextMatchFilter.Contains( this.objectListView1, this.mSearchBox.Text );
            nFilter.RegexOptions = System.Text.RegularExpressions.RegexOptions.IgnoreCase;
            this.objectListView1.ModelFilter = nFilter;
        }

        private void Mainform_FormClosing( object sender, FormClosingEventArgs e )
        {
            List<Guest> nGuestList = this.objectListView1.Objects.Cast<Guest>().ToList();
            DataManager.SaveListToFile<Guest>( nGuestList, Constants.DATA_FILE );
            CsvController csv = new CsvController( Constants.CSV_FILE );
            csv.Write( nGuestList );
        }

        private void Mainform_SizeChanged( object sender, EventArgs e )
        {
            RefreshColumns();
        }

        private void CloseButton_Click( object sender, EventArgs e )
        {
            Application.Exit();
        }

        private void Timer_AutoSave( object sender, EventArgs e )
        {
            List<Guest> nGuestList = this.objectListView1.Objects.Cast<Guest>().ToList();
            DataManager.SaveListToFile<Guest>( nGuestList, Constants.DATA_FILE );
        }

        private void StatsButton_Click( object sender, EventArgs e )
        {
            List<Guest> nGuestList = this.objectListView1.Objects.Cast<Guest>().ToList();
            StatsForm nStats = new StatsForm( nGuestList );
            nStats.ShowDialog();
        }
        #endregion

        #region Context Menu
        private void addToolStripMenuItem_Click( object sender, EventArgs e )
        {
            InputForm nInput = new InputForm();
            nInput.ShowDialog();
            if ( nInput.DialogResult == DialogResult.OK )
            {
                this.objectListView1.AddObject( nInput.NewGuest );
                this.RefreshGuestsCount();
            }
        }

        private void deleteToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( this.objectListView1.SelectedObject != null )
            {
                Guest nGuest = (Guest)this.objectListView1.SelectedObject;
                this.objectListView1.RemoveObject( nGuest );
                this.RefreshGuestsCount();
            }
        }

        private void editToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( this.objectListView1.SelectedObject != null )
            {
                Guest nGuest = (Guest)this.objectListView1.SelectedObject;
                InputForm nInput = new InputForm( nGuest );
                nInput.ShowDialog();
                if ( nInput.DialogResult == DialogResult.OK )
                {
                    nGuest.Copy( nInput.NewGuest );
                    this.objectListView1.RefreshObject( nGuest );
                    this.RefreshGuestsCount();
                }
            }
        }

        private void saveAsToolStripMenuItem_Click( object sender, EventArgs e )
        {
            DialogResult nResult = this.saveBinFileDialog.ShowDialog();
            if ( nResult == DialogResult.OK )
            {
                List<Guest> nGuestList = this.objectListView1.Objects.Cast<Guest>().ToList();
                DataManager.SaveListToFile<Guest>( nGuestList, this.saveBinFileDialog.FileName );
            }
        }

        private void openToolStripMenuItem_Click( object sender, EventArgs e )
        {
            DialogResult nResult = this.openBinFileDialog.ShowDialog();
            if ( nResult == DialogResult.OK )
            {
                this.objectListView1.ClearObjects();
                this.mCheckIns = 0;
                List<Guest> nGuestList;
                nGuestList = DataManager.GetListFromFile<Guest>( this.openBinFileDialog.FileName );
                if ( nGuestList != null )
                {
                    this.objectListView1.SetObjects( nGuestList );
                    this.objectListView1.Sort( this.CategoryColumn );
                    foreach ( Guest nGuest in nGuestList )
                    {
                        if ( nGuest.CheckIn )
                            this.mCheckIns++;
                    }
                    this.RefreshGuestsCount();
                }
            }
        }

        private void exportXMLToolStripMenuItem_Click( object sender, EventArgs e )
        {
            DialogResult nResult = this.saveCsvFileDialog.ShowDialog();
            if ( nResult == DialogResult.OK )
            {
                List<Guest> nGuestList = this.objectListView1.Objects.Cast<Guest>().ToList();
                CsvController csv = new CsvController( this.saveCsvFileDialog.FileName );
                csv.Write( nGuestList );
            }
        }

        private void importXMLToolStripMenuItem_Click( object sender, EventArgs e )
        {
            DialogResult nResult = this.openCsvFileDialog.ShowDialog();
            if ( nResult == DialogResult.OK )
            {
                this.objectListView1.ClearObjects();
                this.mCheckIns = 0;
                CsvController csv = new CsvController( this.openCsvFileDialog.FileName );
                List<Guest> nGuestList = csv.Read();
                if ( nGuestList != null )
                {
                    this.objectListView1.SetObjects( nGuestList );
                    this.objectListView1.Sort( this.CategoryColumn );
                    foreach ( Guest nGuest in nGuestList )
                    {
                        if ( nGuest.CheckIn )
                            this.mCheckIns++;
                    }
                    this.RefreshGuestsCount();
                }
            }
        }
        #endregion


    }
}
