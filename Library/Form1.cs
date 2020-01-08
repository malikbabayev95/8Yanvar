using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcMain.Image = new Bitmap(@"C:\Users\Malik Babayev\source\repos\Library\Library\Resources\pngfuel.com.png");
            //pcMain.Location = new Point((this.ClientSize.Width - pcMain.Size.Width) / 2, (this.ClientSize.Height - pcMain.Size.Height) / 2);
        }

        private void pcMain_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void readersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReaders adr = new AddReaders();
            adr.ShowDialog();
        }

        private void istifadecilerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBooks vu = new ViewBooks();
            vu.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bkf = new BookForm();
            bkf.ShowDialog();

        }
    }
}
