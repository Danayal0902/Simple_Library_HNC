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
    public partial class BorrowDialog : Form
    {
        Library lib;
        

        public BorrowDialog(Library lib)
        {
            InitializeComponent();
            this.lib = lib;
        }

        private void BorrowDialog_Load(object sender, EventArgs e)
        {
           
            foreach (Member m in lib.Members)
                cmbMembers.Items.Add(m.ID.ToString() + " " + m.Name);
            foreach (Stock s in lib.StockItems)
                cmbStock.Items.Add(s.ID.ToString() + " " + s.Title);
            cmbStock.SelectedIndex = 0;
            cmbMembers.SelectedIndex = 0;
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            try
            {
                lib.borrow(cmbMembers.SelectedIndex + 1, cmbStock.SelectedIndex + 1);
                MessageBox.Show("item borrowed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cancelled " + ex.Message);
            }
            this.Close();
         
        }

     

        
    }
}
