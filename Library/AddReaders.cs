using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Library.models;

namespace Library
{
    public partial class AddReaders : Form
    {
        Lib db = new Lib();
        public AddReaders()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            //Form1 frm = new Form1();
            
            this.Close();
        }
        

        

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;
            string phone = txtPhone.Text;
            string fac = cmbFakt.Text;
            
            long newPhone;
            if (firstname != "" && lastname != "" && phone != "" && fac != "" )
            {
                if(long.TryParse(phone, out newPhone))
                {
                    Reader rd = new Reader();
                    rd.readName = firstname;
                    rd.readSur = lastname;
                    rd.readPhone = phone;
                    
                    db.Readers.Add(rd);
                    db.SaveChanges();






                    


                }
                else
                {
                    MessageBox.Show("Nomrenizi duzgun daxil edin.", "Zehmet olmasa...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Butun xanalari doldurun.", "Zehmet olmasa...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void AddReaders_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlCon))
            {
                string selectFak = "Select fakName from Facl";

                SqlCommand fakcmd = new SqlCommand(selectFak, con);

                con.Open();
                var rd = fakcmd.ExecuteReader();
                while (rd.Read())
                {
                    cmbFakt.Items.Add(rd.GetValue(0).ToString());
                }
             
            }

        }
    }
}
