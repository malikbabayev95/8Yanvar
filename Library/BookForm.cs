using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.models;

namespace Library
{
    public partial class BookForm : Form
    {
        Lib db = new Lib();
        public BookForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            BookLoad();
            cmbAuthors.Items.AddRange(db.Authors.Select(ath => ath.authName).ToArray());
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            string bkname = txtBookName.Text;
            string count = txtCounts.Text;
            string authors = cmbAuthors.Text;
            DateTime publish = dtpDate.Value;
            
            if (bkname != string.Empty && count != string.Empty && authors != string.Empty && publish <= DateTime.Now)
            {
                int authID = db.Authors.First(ath => ath.authName == authors).ID;
                int countNum = Convert.ToInt32(count);
                Book bk = new Book();
                bk.bookName = bkname;
                bk.bookCounts = countNum;
                bk.bookAuth = authID;
                bk.bookDate = publish;
                db.Books.Add(bk);
                db.SaveChanges();
                
                lblError.Text = bkname + " - succesfull added";
                
                lblError.Visible = true;
                BookLoad();
            }
            else
            {
                lblError.Text = "Please all the fill !!!";
                lblError.Visible = true;
            }
        }
        public void BookLoad()
        {
            dtgBooks.DataSource = db.Books.Select(bkk => new
            {
                bkk.bookName,
                bkk.bookCounts,
                bkk.Author.authName,
                bkk.bookDate

            })
                .ToList();
        }

        private void txtCounts_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if ((e.KeyChar < 47 || e.KeyChar > 58) && e.KeyChar!=8)
                {
                    e.Handled = true;
                }
            
        }
    }
}
