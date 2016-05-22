using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WList.Common;
using WList.Model;

namespace WList.View
{
    public partial class InputForm : Form
    {
        #region Constructors
        public InputForm()
        {
            InitializeComponent();
            InitializeCombobox();
            this.NewGuest = new Guest();
            this.mWarningLabel.Text = "";
        }

        public InputForm( Guest aGuest )
        {
            InitializeComponent();
            InitializeCombobox();
            this.NewGuest = aGuest;
            this.mWarningLabel.Text = "";
            this.mNameTxtbox.Text = aGuest.Name;
            this.mCategoryCombobox.SelectedItem = aGuest.Category;
            this.mTableCombobox.SelectedItem = aGuest.Table.ToString();
        }
        #endregion

        #region Initialize
        private void InitializeCombobox()
        {
            this.mCategoryCombobox.Items.AddRange( Constants.CategoryList.ToArray() );
            this.mTableCombobox.Items.AddRange( Constants.MaxTablesList.ToArray() );
        }
        #endregion

        #region Helper Methods
        private Boolean ValidateInputs()
        {
            if ( String.IsNullOrEmpty( this.mNameTxtbox.Text.Trim() ) )
            {
                this.mWarningLabel.Text = "Name Cannot Be Empty!";
                return false;
            }
            if ( this.mCategoryCombobox.SelectedItem == null )
            {
                this.mWarningLabel.Text = "Please Select Category!";
                return false;
            }

            int temp;
            if ( !int.TryParse( this.mTableCombobox.Text.Trim(), out temp ) )
            {
                this.mWarningLabel.Text = "Invalid Table Number!";
                return false;
            }

            if ( int.Parse( this.mTableCombobox.Text.Trim() ) > Constants.MaxTables )
            {
                this.mWarningLabel.Text = "Invalid Table Number!";
                return false;
            }

            return true;
        }

        private void SubmitInput()
        {
            if ( ValidateInputs() )
            {
                this.DialogResult = DialogResult.OK;
                this.NewGuest.Name = this.mNameTxtbox.Text.Trim();
                this.NewGuest.Category = this.mCategoryCombobox.SelectedItem.ToString().Trim();
                this.NewGuest.Table = int.Parse( this.mTableCombobox.Text.Trim() );
                this.Close();
            }
        }
        #endregion

        #region Event Handlers
        private void mOkButton_Click( object sender, EventArgs e )
        {
            SubmitInput();
        }

        private void mNameTxtbox_KeyUp( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
                SubmitInput();
        }

        private void mCategoryCombobox_KeyUp( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
                SubmitInput();
        }

        private void mTableCombobox_KeyUp( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
                SubmitInput();
        }
        #endregion

        public Guest NewGuest
        {
            get;
            set;
        }
    }
}
