namespace SimpleLibrary
{
    partial class FrmLibrary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListMembers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.btnPrintStock = new System.Windows.Forms.Button();
            this.btnJournals = new System.Windows.Forms.Button();
            this.btnListBooks = new System.Windows.Forms.Button();
            this.btnListStock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindName = new System.Windows.Forms.Button();
            this.btnFindByID = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListMembers
            // 
            this.btnListMembers.Location = new System.Drawing.Point(6, 53);
            this.btnListMembers.Name = "btnListMembers";
            this.btnListMembers.Size = new System.Drawing.Size(147, 36);
            this.btnListMembers.TabIndex = 0;
            this.btnListMembers.Text = "List Members";
            this.btnListMembers.UseVisualStyleBackColor = true;
            this.btnListMembers.Click += new System.EventHandler(this.btnListMembers_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.btnBorrow);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.btnPrintStock);
            this.panel1.Controls.Add(this.btnJournals);
            this.panel1.Controls.Add(this.btnListBooks);
            this.panel1.Controls.Add(this.btnListStock);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnListMembers);
            this.panel1.Location = new System.Drawing.Point(512, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 471);
            this.panel1.TabIndex = 2;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(5, 416);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(147, 36);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnPrintStock
            // 
            this.btnPrintStock.Location = new System.Drawing.Point(6, 258);
            this.btnPrintStock.Name = "btnPrintStock";
            this.btnPrintStock.Size = new System.Drawing.Size(147, 36);
            this.btnPrintStock.TabIndex = 5;
            this.btnPrintStock.Text = "Print Stock";
            this.btnPrintStock.UseVisualStyleBackColor = true;
            this.btnPrintStock.Click += new System.EventHandler(this.btnPrintStock_Click);
            // 
            // btnJournals
            // 
            this.btnJournals.Location = new System.Drawing.Point(6, 207);
            this.btnJournals.Name = "btnJournals";
            this.btnJournals.Size = new System.Drawing.Size(147, 36);
            this.btnJournals.TabIndex = 4;
            this.btnJournals.Text = "List Jornals";
            this.btnJournals.UseVisualStyleBackColor = true;
            this.btnJournals.Click += new System.EventHandler(this.btnJournals_Click);
            // 
            // btnListBooks
            // 
            this.btnListBooks.Location = new System.Drawing.Point(6, 155);
            this.btnListBooks.Name = "btnListBooks";
            this.btnListBooks.Size = new System.Drawing.Size(147, 36);
            this.btnListBooks.TabIndex = 3;
            this.btnListBooks.Text = "List Books";
            this.btnListBooks.UseVisualStyleBackColor = true;
            this.btnListBooks.Click += new System.EventHandler(this.btnListBooks_Click);
            // 
            // btnListStock
            // 
            this.btnListStock.Location = new System.Drawing.Point(5, 104);
            this.btnListStock.Name = "btnListStock";
            this.btnListStock.Size = new System.Drawing.Size(147, 36);
            this.btnListStock.TabIndex = 2;
            this.btnListStock.Text = "List Stock";
            this.btnListStock.UseVisualStyleBackColor = true;
            this.btnListStock.Click += new System.EventHandler(this.btnListStock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Library Functions";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtYear);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtPostcode);
            this.panel2.Controls.Add(this.txtTown);
            this.panel2.Controls.Add(this.txtStreet);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(14, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 350);
            this.panel2.TabIndex = 3;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(149, 150);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(199, 29);
            this.txtYear.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Year";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(149, 298);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(199, 29);
            this.txtPostcode.TabIndex = 11;
            // 
            // txtTown
            // 
            this.txtTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.Location = new System.Drawing.Point(149, 250);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(199, 29);
            this.txtTown.TabIndex = 10;
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(149, 195);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(199, 29);
            this.txtStreet.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(149, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 29);
            this.txtName.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(149, 58);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(199, 29);
            this.txtID.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Postcode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Town";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Street";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Member Details";
            // 
            // btnFindName
            // 
            this.btnFindName.Location = new System.Drawing.Point(127, 46);
            this.btnFindName.Name = "btnFindName";
            this.btnFindName.Size = new System.Drawing.Size(90, 36);
            this.btnFindName.TabIndex = 11;
            this.btnFindName.Text = "Find By Name";
            this.btnFindName.UseVisualStyleBackColor = true;
            this.btnFindName.Click += new System.EventHandler(this.btnFindName_Click);
            // 
            // btnFindByID
            // 
            this.btnFindByID.Location = new System.Drawing.Point(223, 46);
            this.btnFindByID.Name = "btnFindByID";
            this.btnFindByID.Size = new System.Drawing.Size(88, 36);
            this.btnFindByID.TabIndex = 12;
            this.btnFindByID.Text = "Find By ID";
            this.btnFindByID.UseVisualStyleBackColor = true;
            this.btnFindByID.Click += new System.EventHandler(this.btnFindByID_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(326, 46);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 36);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(18, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 36);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "New Member";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblInstructions);
            this.panel3.Controls.Add(this.btnFindByID);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.btnFindName);
            this.panel3.Location = new System.Drawing.Point(18, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 100);
            this.panel3.TabIndex = 15;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(21, 11);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(365, 16);
            this.lblInstructions.TabIndex = 15;
            this.lblInstructions.Text = "Enter ID or name and then clcik on appropriate search button";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(6, 314);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(147, 36);
            this.btnBorrow.TabIndex = 7;
            this.btnBorrow.Text = "Borrow Stock";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(6, 361);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(147, 36);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return Stock";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FrmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 532);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLibrary";
            this.Text = "Simple Library Librarian GUI";
            this.Load += new System.EventHandler(this.FrmLibrary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListMembers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListBooks;
        private System.Windows.Forms.Button btnListStock;
        private System.Windows.Forms.Button btnJournals;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btnPrintStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFindByID;
        private System.Windows.Forms.Button btnFindName;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnBorrow;
    }
}

