namespace hazi2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            listázásToolStripMenuItem = new ToolStripMenuItem();
            újFelvételeToolStripMenuItem = new ToolStripMenuItem();
            újKategóriaFelvételeToolStripMenuItem = new ToolStripMenuItem();
            exportálásToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog = new SaveFileDialog();
            PetListPage = new Views.PetListPage();
            LoadDatabaseMenuItem = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(192, 64, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { LoadDatabaseMenuItem, listázásToolStripMenuItem, újFelvételeToolStripMenuItem, újKategóriaFelvételeToolStripMenuItem, exportálásToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // listázásToolStripMenuItem
            // 
            listázásToolStripMenuItem.ForeColor = Color.White;
            listázásToolStripMenuItem.Name = "listázásToolStripMenuItem";
            listázásToolStripMenuItem.Size = new Size(59, 20);
            listázásToolStripMenuItem.Text = "Listázás";
            listázásToolStripMenuItem.Click += listazasToolStripMenuItem_Click;
            // 
            // újFelvételeToolStripMenuItem
            // 
            újFelvételeToolStripMenuItem.ForeColor = Color.White;
            újFelvételeToolStripMenuItem.Name = "újFelvételeToolStripMenuItem";
            újFelvételeToolStripMenuItem.Size = new Size(116, 20);
            újFelvételeToolStripMenuItem.Text = "Új kisállat felvétele";
            újFelvételeToolStripMenuItem.Click += ujFelveteleToolStripMenuItem_Click;
            // 
            // újKategóriaFelvételeToolStripMenuItem
            // 
            újKategóriaFelvételeToolStripMenuItem.ForeColor = Color.White;
            újKategóriaFelvételeToolStripMenuItem.Name = "újKategóriaFelvételeToolStripMenuItem";
            újKategóriaFelvételeToolStripMenuItem.Size = new Size(129, 20);
            újKategóriaFelvételeToolStripMenuItem.Text = "Új kategória felvétele";
            újKategóriaFelvételeToolStripMenuItem.Click += újKategóriaFelvételeToolStripMenuItem_Click;
            // 
            // exportálásToolStripMenuItem
            // 
            exportálásToolStripMenuItem.ForeColor = Color.White;
            exportálásToolStripMenuItem.Name = "exportálásToolStripMenuItem";
            exportálásToolStripMenuItem.Size = new Size(73, 20);
            exportálásToolStripMenuItem.Text = "Exportálás";
            exportálásToolStripMenuItem.Click += exportalasToolStripMenuItem_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Text files|*.txt";
            // 
            // PetListPage
            // 
            PetListPage.Dock = DockStyle.Fill;
            PetListPage.Location = new Point(0, 24);
            PetListPage.Margin = new Padding(3, 2, 3, 2);
            PetListPage.Name = "PetListPage";
            PetListPage.Size = new Size(700, 314);
            PetListPage.TabIndex = 2;
            PetListPage.Visible = false;
            // 
            // LoadDatabaseMenuItem
            // 
            LoadDatabaseMenuItem.ForeColor = Color.White;
            LoadDatabaseMenuItem.Name = "LoadDatabaseMenuItem";
            LoadDatabaseMenuItem.Size = new Size(115, 20);
            LoadDatabaseMenuItem.Text = "Adatbázis betöltés";
            LoadDatabaseMenuItem.Click += LoadDatabaseMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog.FileName = "openFileDialog";
            openFileDialog.Filter = "Sqlite db|*.db";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(PetListPage);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Kisállatok";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem listázásToolStripMenuItem;
        private ToolStripMenuItem újFelvételeToolStripMenuItem;
        private ToolStripMenuItem újKategóriaFelvételeToolStripMenuItem;
        private ToolStripMenuItem exportálásToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
        private Views.PetListPage PetListPage;
        private ToolStripMenuItem LoadDatabaseMenuItem;
        private OpenFileDialog openFileDialog;
    }
}
