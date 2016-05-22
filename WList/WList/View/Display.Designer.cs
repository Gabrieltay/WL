namespace WList.View
{
    partial class Display
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Display ) );
            this.mNameLabel = new System.Windows.Forms.Label();
            this.mCloseButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList( this.components );
            this.mCategoryLabel = new System.Windows.Forms.Label();
            this.mTableLabel = new System.Windows.Forms.Label();
            this.mCheckLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mNameLabel
            // 
            this.mNameLabel.AutoSize = true;
            this.mNameLabel.Font = new System.Drawing.Font( "Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.mNameLabel.Location = new System.Drawing.Point( 12, 28 );
            this.mNameLabel.Name = "mNameLabel";
            this.mNameLabel.Size = new System.Drawing.Size( 73, 29 );
            this.mNameLabel.TabIndex = 0;
            this.mNameLabel.Text = "Name";
            // 
            // mCloseButton
            // 
            this.mCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mCloseButton.ImageIndex = 0;
            this.mCloseButton.ImageList = this.imageList1;
            this.mCloseButton.Location = new System.Drawing.Point( 204, 12 );
            this.mCloseButton.Name = "mCloseButton";
            this.mCloseButton.Size = new System.Drawing.Size( 16, 15 );
            this.mCloseButton.TabIndex = 1;
            this.mCloseButton.UseVisualStyleBackColor = true;
            this.mCloseButton.Click += new System.EventHandler( this.CloseButton_Click );
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject( "imageList1.ImageStream" )));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName( 0, "close" );
            this.imageList1.Images.SetKeyName( 1, "check" );
            this.imageList1.Images.SetKeyName( 2, "uncheck" );
            // 
            // mCategoryLabel
            // 
            this.mCategoryLabel.AutoSize = true;
            this.mCategoryLabel.Font = new System.Drawing.Font( "Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.mCategoryLabel.Location = new System.Drawing.Point( 12, 62 );
            this.mCategoryLabel.Name = "mCategoryLabel";
            this.mCategoryLabel.Size = new System.Drawing.Size( 106, 29 );
            this.mCategoryLabel.TabIndex = 2;
            this.mCategoryLabel.Text = "Category";
            // 
            // mTableLabel
            // 
            this.mTableLabel.AutoSize = true;
            this.mTableLabel.Font = new System.Drawing.Font( "Times New Roman", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.mTableLabel.Location = new System.Drawing.Point( 64, 106 );
            this.mTableLabel.Name = "mTableLabel";
            this.mTableLabel.Size = new System.Drawing.Size( 107, 76 );
            this.mTableLabel.TabIndex = 3;
            this.mTableLabel.Text = "ID";
            // 
            // mCheckLabel
            // 
            this.mCheckLabel.AutoSize = true;
            this.mCheckLabel.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.mCheckLabel.ImageKey = "uncheck";
            this.mCheckLabel.ImageList = this.imageList1;
            this.mCheckLabel.Location = new System.Drawing.Point( 101, 192 );
            this.mCheckLabel.Name = "mCheckLabel";
            this.mCheckLabel.Size = new System.Drawing.Size( 17, 20 );
            this.mCheckLabel.TabIndex = 4;
            this.mCheckLabel.Text = "  ";
            this.mCheckLabel.Visible = false;
            this.mCheckLabel.Click += new System.EventHandler( this.mCheckLabel_Click );
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size( 232, 239 );
            this.Controls.Add( this.mCheckLabel );
            this.Controls.Add( this.mTableLabel );
            this.Controls.Add( this.mCategoryLabel );
            this.Controls.Add( this.mCloseButton );
            this.Controls.Add( this.mNameLabel );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Display";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Display";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler( this.Display_MouseDown );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mNameLabel;
        private System.Windows.Forms.Button mCloseButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label mCategoryLabel;
        private System.Windows.Forms.Label mTableLabel;
        private System.Windows.Forms.Label mCheckLabel;
    }
}