namespace Library
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.pcMain = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Firebrick;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.viewToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readersToolStripMenuItem,
            this.authorsToolStripMenuItem,
            this.booksToolStripMenuItem});
            resources.ApplyResources(this.addToolStripMenuItem1, "addToolStripMenuItem1");
            this.addToolStripMenuItem1.ForeColor = System.Drawing.Color.AliceBlue;
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            // 
            // readersToolStripMenuItem
            // 
            this.readersToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.readersToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.readersToolStripMenuItem.Name = "readersToolStripMenuItem";
            resources.ApplyResources(this.readersToolStripMenuItem, "readersToolStripMenuItem");
            this.readersToolStripMenuItem.Click += new System.EventHandler(this.readersToolStripMenuItem_Click);
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.authorsToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            resources.ApplyResources(this.authorsToolStripMenuItem, "authorsToolStripMenuItem");
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.booksToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            resources.ApplyResources(this.booksToolStripMenuItem, "booksToolStripMenuItem");
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.usersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            resources.ApplyResources(this.usersToolStripMenuItem, "usersToolStripMenuItem");
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcMain
            // 
            this.pcMain.Image = global::Library.Properties.Resources.pngfuel_com;
            resources.ApplyResources(this.pcMain, "pcMain");
            this.pcMain.Name = "pcMain";
            this.pcMain.TabStop = false;
            this.pcMain.Click += new System.EventHandler(this.pcMain_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pcMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
    }
}

