using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleLibrary
{
    /// <summary>
    /// return form used for returning items
    /// note how cancel button is setup in design view
    /// 
    /// throws an exception if item is not on loan
    /// </summary>
    public partial class ReturnDialog : Form
    {

        /// <summary>
        /// instance variable pointing to the Library
        /// </summary>
        Library lib;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="thelib">reference to the library passed in</param>
        public ReturnDialog(Library thelib)
        {
            InitializeComponent();
            this.lib = thelib;
        }

        
        /// <summary>
        /// Dialog load method
        /// sets up listbox containing stock items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnDialog_Load(object sender, EventArgs e)
        {
            
            foreach (Stock s in lib.StockItems)
            {
                cmbStock.Items.Add(s.ID.ToString() + " " + s.Title);
            }
            cmbStock.SelectedIndex = 0;
             
        }

        /// <summary>
        /// OK button click event handler
        /// tries to return stock item
        /// If item not on loan throws an error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
      
            try
            {
                lib.returnStock(cmbStock.SelectedIndex + 1);
                MessageBox.Show("item returned");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cancelled " + ex.Message);
            }
            this.Close();//close form
             
        }
    }
}
