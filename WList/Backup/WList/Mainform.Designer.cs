namespace WList
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Mainform ) );
            this.mSearchBox = new System.Windows.Forms.TextBox();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.IDColumn = new BrightIdeasSoftware.OLVColumn();
            this.NameColumn = new BrightIdeasSoftware.OLVColumn();
            this.CategoryColumn = new BrightIdeasSoftware.OLVColumn();
            this.TableColumn = new BrightIdeasSoftware.OLVColumn();
            this.CheckinColumn = new BrightIdeasSoftware.OLVColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList( this.components );
            this.mStatsLabel = new System.Windows.Forms.Label();
            this.mPercentLabel = new System.Windows.Forms.Label();
            this.saveBinFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openBinFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.mCloseButton = new System.Windows.Forms.Button();
            this.openCsvFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveCsvFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mStatsButton = new System.Windows.Forms.Button();
            this.mPicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // mSearchBox
            // 
            this.mSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mSearchBox.Font = new System.Drawing.Font( "Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.mSearchBox.Location = new System.Drawing.Point( 104, 632 );
            this.mSearchBox.Name = "mSearchBox";
            this.mSearchBox.Size = new System.Drawing.Size( 227, 31 );
            this.mSearchBox.TabIndex = 0;
            this.mSearchBox.TextChanged += new System.EventHandler( this.mSearchBox_TextChanged );
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add( this.IDColumn );
            this.objectListView1.AllColumns.Add( this.NameColumn );
            this.objectListView1.AllColumns.Add( this.CategoryColumn );
            this.objectListView1.AllColumns.Add( this.TableColumn );
            this.objectListView1.AllColumns.Add( this.CheckinColumn );
            this.objectListView1.AlternateRowBackColor = System.Drawing.Color.FromArgb( ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))) );
            this.objectListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView1.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.IDColumn,
            this.NameColumn,
            this.CategoryColumn,
            this.TableColumn,
            this.CheckinColumn} );
            this.objectListView1.ContextMenuStrip = this.contextMenuStrip1;
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.Font = new System.Drawing.Font( "Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.Location = new System.Drawing.Point( 12, 12 );
            this.objectListView1.MultiSelect = false;
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.OwnerDraw = true;
            this.objectListView1.ShowItemCountOnGroups = true;
            this.objectListView1.ShowItemToolTips = true;
            this.objectListView1.Size = new System.Drawing.Size( 319, 609 );
            this.objectListView1.SmallImageList = this.imageList1;
            this.objectListView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.objectListView1.TabIndex = 1;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.UseFiltering = true;
            this.objectListView1.UseHotItem = true;
            this.objectListView1.UseTranslucentSelection = true;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler( this.objectListView1_ColumnClick );
            this.objectListView1.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>( this.objectListView1_CellClick );
            // 
            // IDColumn
            // 
            this.IDColumn.AspectName = "ID";
            this.IDColumn.CellPadding = null;
            this.IDColumn.Groupable = false;
            this.IDColumn.Searchable = false;
            this.IDColumn.Text = "ID";
            // 
            // NameColumn
            // 
            this.NameColumn.AspectName = "Name";
            this.NameColumn.AspectToStringFormat = "";
            this.NameColumn.CellPadding = null;
            this.NameColumn.Groupable = false;
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 150;
            // 
            // CategoryColumn
            // 
            this.CategoryColumn.AspectName = "Category";
            this.CategoryColumn.AspectToStringFormat = "";
            this.CategoryColumn.CellPadding = null;
            this.CategoryColumn.GroupWithItemCountFormat = "{0} ---- ( {1} Objects )";
            this.CategoryColumn.GroupWithItemCountSingularFormat = "{0} ---- ( Only {1} Object )";
            this.CategoryColumn.Text = "Category";
            this.CategoryColumn.Width = 150;
            // 
            // TableColumn
            // 
            this.TableColumn.AspectName = "Table";
            this.TableColumn.AspectToStringFormat = "";
            this.TableColumn.CellPadding = null;
            this.TableColumn.GroupWithItemCountFormat = "{0} ---- ( {1} Objects )";
            this.TableColumn.GroupWithItemCountSingularFormat = "{0} ---- ( Only {1} Object )";
            this.TableColumn.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TableColumn.Text = "ID";
            this.TableColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckinColumn
            // 
            this.CheckinColumn.CellPadding = null;
            this.CheckinColumn.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CheckinColumn.Sortable = false;
            this.CheckinColumn.Text = "";
            this.CheckinColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exportXMLToolStripMenuItem,
            this.importXMLToolStripMenuItem} );
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size( 138, 164 );
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size( 137, 22 );
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler( this.addToolStripMenuItem_Click );
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size( 137, 22 );
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler( this.editToolStripMenuItem_Click );
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size( 137, 22 );
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler( this.deleteToolStripMenuItem_Click );
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 134, 6 );
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size( 137, 22 );
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler( this.openToolStripMenuItem_Click );
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size( 137, 22 );
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler( this.saveAsToolStripMenuItem_Click );
            // 
            // exportXMLToolStripMenuItem
            // 
            this.exportXMLToolStripMenuItem.Name = "exportXMLToolStripMenuItem";
            this.exportXMLToolStripMenuItem.Size = new System.Drawing.Size( 137, 22 );
            this.exportXMLToolStripMenuItem.Text = "Export XML";
            this.exportXMLToolStripMenuItem.Click += new System.EventHandler( this.exportXMLToolStripMenuItem_Click );
            // 
            // importXMLToolStripMenuItem
            // 
            this.importXMLToolStripMenuItem.Name = "importXMLToolStripMenuItem";
            this.importXMLToolStripMenuItem.Size = new System.Drawing.Size( 137, 22 );
            this.importXMLToolStripMenuItem.Text = "Import XML";
            this.importXMLToolStripMenuItem.Click += new System.EventHandler( this.importXMLToolStripMenuItem_Click );
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject( "imageList1.ImageStream" )));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName( 0, "check" );
            this.imageList1.Images.SetKeyName( 1, "uncheck" );
            this.imageList1.Images.SetKeyName( 2, "gnome_window_close.png" );
            this.imageList1.Images.SetKeyName( 3, "stats" );
            // 
            // mStatsLabel
            // 
            this.mStatsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mStatsLabel.AutoSize = true;
            this.mStatsLabel.Font = new System.Drawing.Font( "Wide Latin", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.mStatsLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.mStatsLabel.Location = new System.Drawing.Point( 438, 582 );
            this.mStatsLabel.Name = "mStatsLabel";
            this.mStatsLabel.Size = new System.Drawing.Size( 212, 43 );
            this.mStatsLabel.TabIndex = 2;
            this.mStatsLabel.Text = "NULL";
            // 
            // mPercentLabel
            // 
            this.mPercentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mPercentLabel.AutoSize = true;
            this.mPercentLabel.Font = new System.Drawing.Font( "Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.mPercentLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.mPercentLabel.Location = new System.Drawing.Point( 505, 634 );
            this.mPercentLabel.Name = "mPercentLabel";
            this.mPercentLabel.Size = new System.Drawing.Size( 90, 33 );
            this.mPercentLabel.TabIndex = 3;
            this.mPercentLabel.Text = "NULL";
            // 
            // saveBinFileDialog
            // 
            this.saveBinFileDialog.DefaultExt = "bin";
            this.saveBinFileDialog.Filter = "\"DB files|*.bin|All files|*.*\"";
            this.saveBinFileDialog.RestoreDirectory = true;
            // 
            // openBinFileDialog
            // 
            this.openBinFileDialog.DefaultExt = "bin";
            this.openBinFileDialog.FileName = "myData.bin";
            this.openBinFileDialog.Filter = "\"DB files|*.bin|All files|*.*\"";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.label1.Location = new System.Drawing.Point( 12, 635 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 86, 25 );
            this.label1.TabIndex = 4;
            this.label1.Text = "Search";
            // 
            // mCloseButton
            // 
            this.mCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mCloseButton.ImageIndex = 2;
            this.mCloseButton.ImageList = this.imageList1;
            this.mCloseButton.Location = new System.Drawing.Point( 791, 12 );
            this.mCloseButton.Name = "mCloseButton";
            this.mCloseButton.Size = new System.Drawing.Size( 32, 28 );
            this.mCloseButton.TabIndex = 5;
            this.mCloseButton.TabStop = false;
            this.mCloseButton.UseVisualStyleBackColor = true;
            this.mCloseButton.Click += new System.EventHandler( this.CloseButton_Click );
            // 
            // openCsvFileDialog
            // 
            this.openCsvFileDialog.DefaultExt = "csv";
            this.openCsvFileDialog.FileName = "list.csv";
            this.openCsvFileDialog.Filter = "\"csv Files|*.csv|All files|*.*\"";
            // 
            // saveCsvFileDialog
            // 
            this.saveCsvFileDialog.DefaultExt = "csv";
            this.saveCsvFileDialog.Filter = "\"csv Files|*.csv|All files|*.*\"";
            // 
            // mStatsButton
            // 
            this.mStatsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mStatsButton.ImageKey = "stats";
            this.mStatsButton.ImageList = this.imageList1;
            this.mStatsButton.Location = new System.Drawing.Point( 337, 635 );
            this.mStatsButton.Name = "mStatsButton";
            this.mStatsButton.Size = new System.Drawing.Size( 30, 29 );
            this.mStatsButton.TabIndex = 6;
            this.mStatsButton.TabStop = false;
            this.mStatsButton.UseVisualStyleBackColor = true;
            this.mStatsButton.Click += new System.EventHandler( this.StatsButton_Click );
            // 
            // mPicturebox
            // 
            this.mPicturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mPicturebox.ImageLocation = "";
            this.mPicturebox.Location = new System.Drawing.Point( 359, 224 );
            this.mPicturebox.Name = "mPicturebox";
            this.mPicturebox.Size = new System.Drawing.Size( 450, 310 );
            this.mPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mPicturebox.TabIndex = 7;
            this.mPicturebox.TabStop = false;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size( 835, 700 );
            this.Controls.Add( this.mCloseButton );
            this.Controls.Add( this.mPicturebox );
            this.Controls.Add( this.mStatsButton );
            this.Controls.Add( this.mPercentLabel );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.objectListView1 );
            this.Controls.Add( this.mStatsLabel );
            this.Controls.Add( this.mSearchBox );
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size( 835, 682 );
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "i";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler( this.Mainform_SizeChanged );
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.Mainform_FormClosing );
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout( false );
            ((System.ComponentModel.ISupportInitialize)(this.mPicturebox)).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mSearchBox;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn NameColumn;
        private BrightIdeasSoftware.OLVColumn CategoryColumn;
        private BrightIdeasSoftware.OLVColumn TableColumn;
        private BrightIdeasSoftware.OLVColumn CheckinColumn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label mStatsLabel;
        private System.Windows.Forms.Label mPercentLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveBinFileDialog;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openBinFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mCloseButton;
        private BrightIdeasSoftware.OLVColumn IDColumn;
        private System.Windows.Forms.ToolStripMenuItem exportXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importXMLToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openCsvFileDialog;
        private System.Windows.Forms.SaveFileDialog saveCsvFileDialog;
        private System.Windows.Forms.Button mStatsButton;
        private System.Windows.Forms.PictureBox mPicturebox;
    }
}

