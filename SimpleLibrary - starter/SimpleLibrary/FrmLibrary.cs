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
    public partial class FrmLibrary : Form
    {
        Library theLibrary;
        Member aMember;
        public FrmLibrary()
        {
            InitializeComponent();
        }

       

        private void FrmLibrary_Load(object sender, EventArgs e)
        {
            theLibrary = new Library();
            theLibrary.populate();
            aMember = null;
            setSearch();
        }

        private void setSearch()
        {
            txtID.Text = "";
            txtID.Enabled = true;
            txtName.Text = "";
            txtYear.Text = "";
            txtStreet.Text = "";
            txtTown.Text = "";
            txtPostcode.Text = "";
            btnUpdate.Visible = false;
            btnFindByID.Visible = true;
            btnFindName.Visible = true;
            btnSearch.Text = "New Member";
            lblInstructions.Text = "Enter ID or name and then click on appropriate search button";
        }

        private void setNewmember()
        {
            txtID.Text = "";
            txtID.Enabled = false;
            txtName.Text = "";
            txtYear.Text = "";
            txtTown.Text = "";
            txtStreet.Text = "";
            txtPostcode.Text = "";
            btnUpdate.Visible = true;
            btnFindByID.Visible = false;
            btnFindName.Visible = false;
            btnSearch.Text = "Search";
            lblInstructions.Text = "Enter details and then click on update button";
        }

            
        private void btnListMembers_Click(object sender, EventArgs e)
        {
            Console.Clear();
            theLibrary.listMembers();
        }

        private void btnListStock_Click(object sender, EventArgs e)
        {
            Console.Clear();
            theLibrary.listStock();
        }

        private void btnListBooks_Click(object sender, EventArgs e)
        {
            Console.Clear();
            theLibrary.listBooks();
        }

        private void btnJournals_Click(object sender, EventArgs e)
        {
            Console.Clear();
            theLibrary.listJournals();
        }

        private void btnPrintStock_Click(object sender, EventArgs e)
        {
            try
            {
                theLibrary.printStock("dummyprinter");
                MessageBox.Show("Sent to printer file");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem printing \n" + ex.Message);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Simple Library", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnFindName_Click(object sender, EventArgs e)
        {
          
            try
            {
                aMember = theLibrary.findMemberByName(txtName.Text);
                txtID.Text = aMember.ID.ToString();
                txtName.Text = aMember.Name;
                txtYear.Text = aMember.Year.ToString();
                txtPostcode.Text = aMember.getPostcode();
                txtStreet.Text = aMember.getStreet();
                txtTown.Text = aMember.getTown();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to find \n" + ex.Message, "Simple Library");
                txtName.Focus();
                txtName.SelectAll();
            }
             
        }

        private void btnFindByID_Click(object sender, EventArgs e)
        {
         
            try
            {
                aMember = theLibrary.findMemberByID(int.Parse(txtID.Text));
                txtID.Text = aMember.ID.ToString();
                txtName.Text = aMember.Name;
                txtPostcode.Text = aMember.getPostcode();
                txtStreet.Text = aMember.getStreet();
                txtTown.Text = aMember.getTown();
                txtYear.Text = aMember.Year.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to find \n" + ex.Message, "Simple Library");
                txtID.Focus();
                txtID.SelectAll();
            }
             
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (btnSearch.Text == "Search")
                setSearch();
            else
                setNewmember();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //NOTE this method has some validation errors
            string nm ; //to store name
            string st; //to store street
            string twn; //to store town
            string pst ; //to store postcode
            int yr; //to store year of birth
            try
            {
                txtYear.Focus();
                txtYear.SelectAll();
                if (this.txtName.Text == "")
                {
                    txtName.Focus();
                    throw new Exception("Must Have Name");
                }
                if (this.txtYear.Text == "")
                {
                    txtYear.Focus();
                    throw new Exception("Must Have year of birth");
                }
                if (this.txtStreet.Text == "")
                {
                    txtStreet.Focus();
                    throw new Exception("Must have street name");
                }
                if (this.txtTown.Text == "")
                {
                    txtTown.Focus();
                    throw new Exception("Must have town name");
                }
                if (this.txtPostcode.Text == "")
                {
                    txtPostcode.Focus();
                    throw new Exception("Must Have Postcode");
                }
                ///postcode must be between 6 and 8
                if (this.txtPostcode.TextLength < 6 || txtPostcode.TextLength > 8)
                {
                    txtPostcode.Focus();
                    txtPostcode.SelectAll();
                    throw new Exception("Postcode must be between 6 and 8 characters");
                }
                //the year must be between 1920 and the current date 
                yr = int.Parse(txtYear.Text);
                if (yr < 1920 || yr > DateTime.Today.Year)
                {
                    txtYear.Focus();
                    txtYear.SelectAll();
                    throw new Exception("Year of birth impossible!");
                }
                nm = txtName.Text;
                st = txtStreet.Text;
                twn = txtTown.Text;
                pst = txtPostcode.Text;

                theLibrary.addMember(nm, yr, st, twn, pst);
                MessageBox.Show("Member added");
                setSearch();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            BorrowDialog subform = new BorrowDialog(theLibrary);
            subform.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnDialog subform = new ReturnDialog(theLibrary);
            subform.ShowDialog();
        }
        

       
        
        
    }
}
