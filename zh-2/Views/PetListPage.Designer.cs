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
        petEntityBindingSource = new BindingSource(components);
        idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        OwnerName = new DataGridViewTextBoxColumn();
        Gender = new DataGridViewTextBoxColumn();
        ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        weightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        Id = new DataGridViewButtonColumn();
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
        label1.Size = new Size(711, 27);
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
        petGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, OwnerName, Gender, ageDataGridViewTextBoxColumn, weightDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, Id });
        petGridView.DataSource = petEntityBindingSource;
        petGridView.Dock = DockStyle.Fill;
        petGridView.Location = new Point(0, 27);
        petGridView.Margin = new Padding(3, 2, 3, 2);
        petGridView.MultiSelect = false;
        petGridView.Name = "petGridView";
        petGridView.ReadOnly = true;
        petGridView.RowHeadersVisible = false;
        petGridView.RowHeadersWidth = 51;
        petGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        petGridView.Size = new Size(711, 393);
        petGridView.TabIndex = 1;
        petGridView.CellClick += petGridView_CellClick;
        // 
        // petEntityBindingSource
        // 
        petEntityBindingSource.DataSource = typeof(Models.PetEntity);
        // 
        // idDataGridViewTextBoxColumn
        // 
        idDataGridViewTextBoxColumn.DataPropertyName = "Id";
        idDataGridViewTextBoxColumn.FillWeight = 20F;
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
        // OwnerName
        // 
        OwnerName.DataPropertyName = "OwnerName";
        OwnerName.HeaderText = "Tulajdonos";
        OwnerName.Name = "OwnerName";
        OwnerName.ReadOnly = true;
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
        // Id
        // 
        Id.HeaderText = "Akció";
        Id.Name = "Id";
        Id.ReadOnly = true;
        Id.Text = "Törlés";
        Id.UseColumnTextForButtonValue = true;
        // 
        // PetListPage
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(petGridView);
        Controls.Add(label1);
        Margin = new Padding(3, 2, 3, 2);
        Name = "PetListPage";
        Size = new Size(711, 420);
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
    private DataGridViewTextBoxColumn OwnerName;
    private DataGridViewTextBoxColumn Gender;
    private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    private DataGridViewButtonColumn Id;
}
