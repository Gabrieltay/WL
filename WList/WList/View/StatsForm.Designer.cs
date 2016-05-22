namespace WList.View
{
    partial class StatsForm
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
            this.listBox1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = new BrightIdeasSoftware.OLVColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllColumns.Add( this.olvColumn1 );
            this.listBox1.AlternateRowBackColor = System.Drawing.Color.FromArgb( ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))) );
            this.listBox1.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1} );
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font( "Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.listBox1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listBox1.Location = new System.Drawing.Point( 0, 0 );
            this.listBox1.Name = "listBox1";
            this.listBox1.ShowGroups = false;
            this.listBox1.ShowHeaderInAllViews = false;
            this.listBox1.Size = new System.Drawing.Size( 284, 262 );
            this.listBox1.TabIndex = 1;
            this.listBox1.UseAlternatingBackColors = true;
            this.listBox1.UseCompatibleStateImageBehavior = false;
            this.listBox1.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.Groupable = false;
            this.olvColumn1.IsVisible = false;
            this.olvColumn1.Searchable = false;
            this.olvColumn1.ShowTextInHeader = false;
            this.olvColumn1.Sortable = false;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 284, 262 );
            this.Controls.Add( this.listBox1 );
            this.Name = "StatsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistics";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.listBox1)).EndInit();
            this.ResumeLayout( false );

        }

        #endregion

        //private System.Windows.Forms.ListBox listBox1;
        private BrightIdeasSoftware.ObjectListView listBox1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;

    }
}