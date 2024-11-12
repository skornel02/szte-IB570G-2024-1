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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(192, 64, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { listázásToolStripMenuItem, újFelvételeToolStripMenuItem, újKategóriaFelvételeToolStripMenuItem, exportálásToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // listázásToolStripMenuItem
            // 
            listázásToolStripMenuItem.ForeColor = Color.White;
            listázásToolStripMenuItem.Name = "listázásToolStripMenuItem";
            listázásToolStripMenuItem.Size = new Size(74, 24);
            listázásToolStripMenuItem.Text = "Listázás";
            listázásToolStripMenuItem.Click += listazasToolStripMenuItem_Click;
            // 
            // újFelvételeToolStripMenuItem
            // 
            újFelvételeToolStripMenuItem.ForeColor = Color.White;
            újFelvételeToolStripMenuItem.Name = "újFelvételeToolStripMenuItem";
            újFelvételeToolStripMenuItem.Size = new Size(148, 24);
            újFelvételeToolStripMenuItem.Text = "Új kisállat felvétele";
            újFelvételeToolStripMenuItem.Click += ujFelveteleToolStripMenuItem_Click;
            // 
            // újKategóriaFelvételeToolStripMenuItem
            // 
            újKategóriaFelvételeToolStripMenuItem.ForeColor = Color.White;
            újKategóriaFelvételeToolStripMenuItem.Name = "újKategóriaFelvételeToolStripMenuItem";
            újKategóriaFelvételeToolStripMenuItem.Size = new Size(165, 24);
            újKategóriaFelvételeToolStripMenuItem.Text = "Új kategória felvétele";
            újKategóriaFelvételeToolStripMenuItem.Click += újKategóriaFelvételeToolStripMenuItem_Click;
            // 
            // exportálásToolStripMenuItem
            // 
            exportálásToolStripMenuItem.ForeColor = Color.White;
            exportálásToolStripMenuItem.Name = "exportálásToolStripMenuItem";
            exportálásToolStripMenuItem.Size = new Size(92, 24);
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
            PetListPage.Location = new Point(0, 28);
            PetListPage.Name = "PetListPage";
            PetListPage.Size = new Size(800, 422);
            PetListPage.TabIndex = 2;
            PetListPage.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PetListPage);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
    }
}
