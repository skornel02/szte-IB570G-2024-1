namespace hazi2.Views;

partial class PetListPage
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        label1 = new Label();
        petGridView = new DataGridView();
        idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        Gender = new DataGridViewTextBoxColumn();
        ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        weightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        petEntityBindingSource = new BindingSource(components);
        ((System.ComponentModel.ISupportInitialize)petGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)petEntityBindingSource).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Dock = DockStyle.Top;
        label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(0, 0);
        label1.Name = "label1";
        label1.Size = new Size(813, 36);
        label1.TabIndex = 0;
        label1.Text = "Kisállatok";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // petGridView
        // 
        petGridView.AllowUserToAddRows = false;
        petGridView.AllowUserToDeleteRows = false;
        petGridView.AutoGenerateColumns = false;
        petGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        petGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, Gender, ageDataGridViewTextBoxColumn, weightDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn });
        petGridView.DataSource = petEntityBindingSource;
        petGridView.Dock = DockStyle.Fill;
        petGridView.Location = new Point(0, 36);
        petGridView.MultiSelect = false;
        petGridView.Name = "petGridView";
        petGridView.ReadOnly = true;
        petGridView.RowHeadersVisible = false;
        petGridView.RowHeadersWidth = 51;
        petGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        petGridView.Size = new Size(813, 524);
        petGridView.TabIndex = 1;
        petGridView.CellClick += petGridView_CellClick;
        // 
        // idDataGridViewTextBoxColumn
        // 
        idDataGridViewTextBoxColumn.DataPropertyName = "Id";
        idDataGridViewTextBoxColumn.HeaderText = "#";
        idDataGridViewTextBoxColumn.MinimumWidth = 6;
        idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
        idDataGridViewTextBoxColumn.ReadOnly = true;
        idDataGridViewTextBoxColumn.Width = 125;
        // 
        // nameDataGridViewTextBoxColumn
        // 
        nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
        nameDataGridViewTextBoxColumn.HeaderText = "Név";
        nameDataGridViewTextBoxColumn.MinimumWidth = 6;
        nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
        nameDataGridViewTextBoxColumn.ReadOnly = true;
        nameDataGridViewTextBoxColumn.Width = 125;
        // 
        // Gender
        // 
        Gender.DataPropertyName = "Gender";
        Gender.HeaderText = "Nem";
        Gender.MinimumWidth = 6;
        Gender.Name = "Gender";
        Gender.ReadOnly = true;
        Gender.Width = 125;
        // 
        // ageDataGridViewTextBoxColumn
        // 
        ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
        ageDataGridViewTextBoxColumn.HeaderText = "Kor";
        ageDataGridViewTextBoxColumn.MinimumWidth = 6;
        ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
        ageDataGridViewTextBoxColumn.ReadOnly = true;
        ageDataGridViewTextBoxColumn.Width = 125;
        // 
        // weightDataGridViewTextBoxColumn
        // 
        weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
        weightDataGridViewTextBoxColumn.HeaderText = "Súly";
        weightDataGridViewTextBoxColumn.MinimumWidth = 6;
        weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
        weightDataGridViewTextBoxColumn.ReadOnly = true;
        weightDataGridViewTextBoxColumn.Width = 125;
        // 
        // categoryDataGridViewTextBoxColumn
        // 
        categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
        categoryDataGridViewTextBoxColumn.HeaderText = "Kategória";
        categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
        categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
        categoryDataGridViewTextBoxColumn.ReadOnly = true;
        categoryDataGridViewTextBoxColumn.Width = 125;
        // 
        // petEntityBindingSource
        // 
        petEntityBindingSource.DataSource = typeof(Models.PetEntity);
        // 
        // PetListPage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(petGridView);
        Controls.Add(label1);
        Name = "PetListPage";
        Size = new Size(813, 560);
        Load += PetListPage_Load;
        ((System.ComponentModel.ISupportInitialize)petGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)petEntityBindingSource).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label label1;
    private DataGridView petGridView;
    private BindingSource petEntityBindingSource;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn Gender;
    private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
}
