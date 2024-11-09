namespace hazi2.Views;

partial class EditPetForm
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
        tableLayoutPanel1 = new TableLayoutPanel();
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        NameTextbox = new TextBox();
        CategoryDropdown = new ComboBox();
        AgeNumeric = new NumericUpDown();
        WeightNumeric = new NumericUpDown();
        groupBox1 = new GroupBox();
        flowLayoutPanel2 = new FlowLayoutPanel();
        GenderMale = new RadioButton();
        GenderFemale = new RadioButton();
        ClearButton = new Button();
        DefaultValueButton = new Button();
        AddButton = new Button();
        TitleLabel = new Label();
        tableLayoutPanel2 = new TableLayoutPanel();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)AgeNumeric).BeginInit();
        ((System.ComponentModel.ISupportInitialize)WeightNumeric).BeginInit();
        groupBox1.SuspendLayout();
        flowLayoutPanel2.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
        tableLayoutPanel1.Controls.Add(label6, 0, 4);
        tableLayoutPanel1.Controls.Add(label5, 0, 3);
        tableLayoutPanel1.Controls.Add(label4, 0, 2);
        tableLayoutPanel1.Controls.Add(label3, 0, 1);
        tableLayoutPanel1.Controls.Add(label2, 0, 0);
        tableLayoutPanel1.Controls.Add(NameTextbox, 1, 0);
        tableLayoutPanel1.Controls.Add(CategoryDropdown, 1, 4);
        tableLayoutPanel1.Controls.Add(AgeNumeric, 1, 2);
        tableLayoutPanel1.Controls.Add(WeightNumeric, 1, 3);
        tableLayoutPanel1.Controls.Add(groupBox1, 1, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
        tableLayoutPanel1.Location = new Point(0, 36);
        tableLayoutPanel1.Margin = new Padding(10);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 5;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
        tableLayoutPanel1.Size = new Size(800, 345);
        tableLayoutPanel1.TabIndex = 3;
        // 
        // label6
        // 
        label6.Dock = DockStyle.Fill;
        label6.Location = new Point(3, 291);
        label6.Name = "label6";
        label6.Size = new Size(234, 54);
        label6.TabIndex = 8;
        label6.Text = "Kategória";
        label6.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label5
        // 
        label5.Dock = DockStyle.Fill;
        label5.Location = new Point(3, 240);
        label5.Name = "label5";
        label5.Size = new Size(234, 51);
        label5.TabIndex = 6;
        label5.Text = "Súly";
        label5.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label4
        // 
        label4.Dock = DockStyle.Fill;
        label4.Location = new Point(3, 189);
        label4.Name = "label4";
        label4.Size = new Size(234, 51);
        label4.TabIndex = 4;
        label4.Text = "Életkor";
        label4.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.Dock = DockStyle.Fill;
        label3.Location = new Point(3, 51);
        label3.Name = "label3";
        label3.Size = new Size(234, 138);
        label3.TabIndex = 2;
        label3.Text = "Nem";
        label3.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Dock = DockStyle.Fill;
        label2.Location = new Point(3, 0);
        label2.Name = "label2";
        label2.Size = new Size(234, 51);
        label2.TabIndex = 0;
        label2.Text = "Név";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // NameTextbox
        // 
        NameTextbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        NameTextbox.Location = new Point(243, 12);
        NameTextbox.Name = "NameTextbox";
        NameTextbox.Size = new Size(554, 27);
        NameTextbox.TabIndex = 1;
        // 
        // CategoryDropdown
        // 
        CategoryDropdown.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CategoryDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
        CategoryDropdown.FormattingEnabled = true;
        CategoryDropdown.Location = new Point(243, 304);
        CategoryDropdown.Name = "CategoryDropdown";
        CategoryDropdown.Size = new Size(554, 28);
        CategoryDropdown.TabIndex = 9;
        // 
        // AgeNumeric
        // 
        AgeNumeric.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        AgeNumeric.Location = new Point(243, 201);
        AgeNumeric.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
        AgeNumeric.Name = "AgeNumeric";
        AgeNumeric.Size = new Size(554, 27);
        AgeNumeric.TabIndex = 10;
        // 
        // WeightNumeric
        // 
        WeightNumeric.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        WeightNumeric.DecimalPlaces = 1;
        WeightNumeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
        WeightNumeric.Location = new Point(243, 252);
        WeightNumeric.Name = "WeightNumeric";
        WeightNumeric.Size = new Size(554, 27);
        WeightNumeric.TabIndex = 11;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(flowLayoutPanel2);
        groupBox1.Dock = DockStyle.Fill;
        groupBox1.Location = new Point(243, 54);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(554, 132);
        groupBox1.TabIndex = 12;
        groupBox1.TabStop = false;
        // 
        // flowLayoutPanel2
        // 
        flowLayoutPanel2.Controls.Add(GenderMale);
        flowLayoutPanel2.Controls.Add(GenderFemale);
        flowLayoutPanel2.Dock = DockStyle.Fill;
        flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
        flowLayoutPanel2.Location = new Point(3, 23);
        flowLayoutPanel2.Name = "flowLayoutPanel2";
        flowLayoutPanel2.Size = new Size(548, 106);
        flowLayoutPanel2.TabIndex = 2;
        // 
        // GenderMale
        // 
        GenderMale.AutoSize = true;
        GenderMale.Checked = true;
        GenderMale.Location = new Point(3, 3);
        GenderMale.Name = "GenderMale";
        GenderMale.Size = new Size(58, 24);
        GenderMale.TabIndex = 0;
        GenderMale.TabStop = true;
        GenderMale.Text = "Hím";
        GenderMale.UseVisualStyleBackColor = true;
        // 
        // GenderFemale
        // 
        GenderFemale.AutoSize = true;
        GenderFemale.Location = new Point(3, 33);
        GenderFemale.Name = "GenderFemale";
        GenderFemale.Size = new Size(84, 24);
        GenderFemale.TabIndex = 1;
        GenderFemale.Text = "Nőstény";
        GenderFemale.UseVisualStyleBackColor = true;
        // 
        // ClearButton
        // 
        ClearButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        ClearButton.AutoSize = true;
        ClearButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        ClearButton.Location = new Point(10, 10);
        ClearButton.Margin = new Padding(10);
        ClearButton.Name = "ClearButton";
        ClearButton.Size = new Size(246, 49);
        ClearButton.TabIndex = 0;
        ClearButton.Text = "Üres";
        ClearButton.UseVisualStyleBackColor = true;
        ClearButton.Click += ClearButton_Click;
        // 
        // DefaultValueButton
        // 
        DefaultValueButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        DefaultValueButton.AutoSize = true;
        DefaultValueButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        DefaultValueButton.Location = new Point(276, 10);
        DefaultValueButton.Margin = new Padding(10);
        DefaultValueButton.Name = "DefaultValueButton";
        DefaultValueButton.Size = new Size(246, 49);
        DefaultValueButton.TabIndex = 1;
        DefaultValueButton.Text = "Alapérték";
        DefaultValueButton.UseVisualStyleBackColor = true;
        DefaultValueButton.Click += DefaultValueButton_Click;
        // 
        // AddButton
        // 
        AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        AddButton.AutoSize = true;
        AddButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        AddButton.Location = new Point(542, 10);
        AddButton.Margin = new Padding(10);
        AddButton.Name = "AddButton";
        AddButton.Size = new Size(248, 49);
        AddButton.TabIndex = 2;
        AddButton.Text = "Hozzáadás";
        AddButton.UseVisualStyleBackColor = true;
        AddButton.Click += AddButton_Click;
        // 
        // TitleLabel
        // 
        TitleLabel.Dock = DockStyle.Top;
        TitleLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        TitleLabel.Location = new Point(0, 0);
        TitleLabel.Name = "TitleLabel";
        TitleLabel.Size = new Size(800, 36);
        TitleLabel.TabIndex = 4;
        TitleLabel.Text = "Új kisállat felvétele";
        TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        tableLayoutPanel2.ColumnCount = 3;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.Controls.Add(AddButton, 2, 0);
        tableLayoutPanel2.Controls.Add(DefaultValueButton, 1, 0);
        tableLayoutPanel2.Controls.Add(ClearButton, 0, 0);
        tableLayoutPanel2.Dock = DockStyle.Bottom;
        tableLayoutPanel2.Location = new Point(0, 381);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle());
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel2.Size = new Size(800, 69);
        tableLayoutPanel2.TabIndex = 5;
        // 
        // EditPetForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(tableLayoutPanel2);
        Controls.Add(TitleLabel);
        Name = "EditPetForm";
        Text = "Új kisállat";
        Load += AddPetForm_Load;
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)AgeNumeric).EndInit();
        ((System.ComponentModel.ISupportInitialize)WeightNumeric).EndInit();
        groupBox1.ResumeLayout(false);
        flowLayoutPanel2.ResumeLayout(false);
        flowLayoutPanel2.PerformLayout();
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private TextBox NameTextbox;
    private Label TitleLabel;
    private ComboBox CategoryDropdown;
    private NumericUpDown AgeNumeric;
    private NumericUpDown WeightNumeric;
    private GroupBox groupBox1;
    private FlowLayoutPanel flowLayoutPanel2;
    private RadioButton GenderMale;
    private RadioButton GenderFemale;
    private Button ClearButton;
    private Button DefaultValueButton;
    private Button AddButton;
    private TableLayoutPanel tableLayoutPanel2;
}
