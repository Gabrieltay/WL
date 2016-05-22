namespace WList.View
{
    partial class InputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mTableCombobox = new System.Windows.Forms.ComboBox();
            this.mCategoryCombobox = new System.Windows.Forms.ComboBox();
            this.mOkButton = new System.Windows.Forms.Button();
            this.mNameTxtbox = new System.Windows.Forms.TextBox();
            this.mWarningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.label1.Location = new System.Drawing.Point( 13, 24 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 40, 12 );
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font( "Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.label2.Location = new System.Drawing.Point( 13, 53 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 68, 12 );
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font( "Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.label3.Location = new System.Drawing.Point( 13, 82 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 26, 12 );
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // mTableCombobox
            // 
            this.mTableCombobox.Font = new System.Drawing.Font( "Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.mTableCombobox.FormattingEnabled = true;
            this.mTableCombobox.Location = new System.Drawing.Point( 86, 79 );
            this.mTableCombobox.Name = "mTableCombobox";
            this.mTableCombobox.Size = new System.Drawing.Size( 61, 20 );
            this.mTableCombobox.TabIndex = 3;
            this.mTableCombobox.KeyUp += new System.Windows.Forms.KeyEventHandler( this.mTableCombobox_KeyUp );
            // 
            // mCategoryCombobox
            // 
            this.mCategoryCombobox.Font = new System.Drawing.Font( "Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.mCategoryCombobox.FormattingEnabled = true;
            this.mCategoryCombobox.Location = new System.Drawing.Point( 86, 53 );
            this.mCategoryCombobox.Name = "mCategoryCombobox";
            this.mCategoryCombobox.Size = new System.Drawing.Size( 121, 20 );
            this.mCategoryCombobox.TabIndex = 2;
            this.mCategoryCombobox.KeyUp += new System.Windows.Forms.KeyEventHandler( this.mCategoryCombobox_KeyUp );
            // 
            // mOkButton
            // 
            this.mOkButton.Location = new System.Drawing.Point( 15, 145 );
            this.mOkButton.Name = "mOkButton";
            this.mOkButton.Size = new System.Drawing.Size( 233, 36 );
            this.mOkButton.TabIndex = 4;
            this.mOkButton.Text = "OK";
            this.mOkButton.UseVisualStyleBackColor = true;
            this.mOkButton.Click += new System.EventHandler( this.mOkButton_Click );
            // 
            // mNameTxtbox
            // 
            this.mNameTxtbox.Font = new System.Drawing.Font( "Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.mNameTxtbox.Location = new System.Drawing.Point( 86, 24 );
            this.mNameTxtbox.Name = "mNameTxtbox";
            this.mNameTxtbox.Size = new System.Drawing.Size( 162, 19 );
            this.mNameTxtbox.TabIndex = 1;
            this.mNameTxtbox.KeyUp += new System.Windows.Forms.KeyEventHandler( this.mNameTxtbox_KeyUp );
            // 
            // mWarningLabel
            // 
            this.mWarningLabel.AutoSize = true;
            this.mWarningLabel.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.mWarningLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.mWarningLabel.Location = new System.Drawing.Point( 12, 116 );
            this.mWarningLabel.Name = "mWarningLabel";
            this.mWarningLabel.Size = new System.Drawing.Size( 39, 13 );
            this.mWarningLabel.TabIndex = 5;
            this.mWarningLabel.Text = "NULL";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 260, 194 );
            this.Controls.Add( this.mWarningLabel );
            this.Controls.Add( this.mNameTxtbox );
            this.Controls.Add( this.mOkButton );
            this.Controls.Add( this.mCategoryCombobox );
            this.Controls.Add( this.mTableCombobox );
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.label1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InputForm";
            this.Text = "Input";
            this.TopMost = true;
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mTableCombobox;
        private System.Windows.Forms.ComboBox mCategoryCombobox;
        private System.Windows.Forms.Button mOkButton;
        private System.Windows.Forms.TextBox mNameTxtbox;
        private System.Windows.Forms.Label mWarningLabel;
    }
}