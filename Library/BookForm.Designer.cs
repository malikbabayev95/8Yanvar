namespace Library
{
    partial class BookForm
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
            this.dtgBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtCounts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAuthors = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnBook = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgBooks
            // 
            this.dtgBooks.AllowUserToAddRows = false;
            this.dtgBooks.AllowUserToDeleteRows = false;
            this.dtgBooks.AllowUserToResizeColumns = false;
            this.dtgBooks.AllowUserToResizeRows = false;
            this.dtgBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgBooks.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dtgBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBooks.GridColor = System.Drawing.Color.IndianRed;
            this.dtgBooks.Location = new System.Drawing.Point(501, 144);
            this.dtgBooks.Margin = new System.Windows.Forms.Padding(6);
            this.dtgBooks.Name = "dtgBooks";
            this.dtgBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgBooks.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.IndianRed;
            this.dtgBooks.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dtgBooks.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.dtgBooks.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgBooks.RowTemplate.ReadOnly = true;
            this.dtgBooks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgBooks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgBooks.ShowCellToolTips = false;
            this.dtgBooks.ShowEditingIcon = false;
            this.dtgBooks.Size = new System.Drawing.Size(607, 343);
            this.dtgBooks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.Brown;
            this.txtBookName.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtBookName.Location = new System.Drawing.Point(156, 144);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(6);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(273, 30);
            this.txtBookName.TabIndex = 2;
            // 
            // txtCounts
            // 
            this.txtCounts.BackColor = System.Drawing.Color.Brown;
            this.txtCounts.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtCounts.Location = new System.Drawing.Point(156, 291);
            this.txtCounts.Margin = new System.Windows.Forms.Padding(6);
            this.txtCounts.Name = "txtCounts";
            this.txtCounts.Size = new System.Drawing.Size(273, 30);
            this.txtCounts.TabIndex = 4;
            this.txtCounts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCounts_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Create Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(16, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Counts:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(16, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Authors:";
            // 
            // cmbAuthors
            // 
            this.cmbAuthors.BackColor = System.Drawing.Color.Brown;
            this.cmbAuthors.ForeColor = System.Drawing.SystemColors.Menu;
            this.cmbAuthors.FormattingEnabled = true;
            this.cmbAuthors.Location = new System.Drawing.Point(156, 362);
            this.cmbAuthors.Margin = new System.Windows.Forms.Padding(6);
            this.cmbAuthors.Name = "cmbAuthors";
            this.cmbAuthors.Size = new System.Drawing.Size(273, 32);
            this.cmbAuthors.TabIndex = 8;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarForeColor = System.Drawing.Color.SeaShell;
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.Brown;
            this.dtpDate.CalendarTitleBackColor = System.Drawing.Color.Firebrick;
            this.dtpDate.CalendarTitleForeColor = System.Drawing.Color.MintCream;
            this.dtpDate.Location = new System.Drawing.Point(156, 215);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(273, 30);
            this.dtpDate.TabIndex = 9;
            // 
            // btnBook
            // 
            this.btnBook.FlatAppearance.BorderSize = 3;
            this.btnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBook.Location = new System.Drawing.Point(60, 438);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(348, 49);
            this.btnBook.TabIndex = 10;
            this.btnBook.Text = "Add Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 47);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(19, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Add New Book";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1116, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "x";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(286, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(542, 74);
            this.label7.TabIndex = 12;
            this.label7.Text = "Welcome to Library";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Tw Cen MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblError.Location = new System.Drawing.Point(286, 500);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(542, 74);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "Welcome to Library";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblError.Visible = false;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1148, 583);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbAuthors);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCounts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgBooks);
            this.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtCounts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAuthors;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblError;
    }
}