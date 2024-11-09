namespace hazi2.Views;

partial class PromptPopup
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
        label1 = new Label();
        textBox1 = new TextBox();
        CancelButton = new Button();
        OkButton = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Dock = DockStyle.Top;
        label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(0, 0);
        label1.Margin = new Padding(3, 10, 3, 10);
        label1.Name = "label1";
        label1.Size = new Size(549, 84);
        label1.TabIndex = 0;
        label1.Text = "label1";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // textBox1
        // 
        textBox1.Dock = DockStyle.Fill;
        textBox1.Location = new Point(0, 84);
        textBox1.Margin = new Padding(10);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(549, 27);
        textBox1.TabIndex = 1;
        // 
        // CancelButton
        // 
        CancelButton.Location = new Point(106, 134);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new Size(94, 29);
        CancelButton.TabIndex = 2;
        CancelButton.Text = "Mégse";
        CancelButton.UseVisualStyleBackColor = true;
        CancelButton.Click += CancelButton_Click;
        // 
        // OkButton
        // 
        OkButton.Location = new Point(353, 134);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(94, 29);
        OkButton.TabIndex = 3;
        OkButton.Text = "Ok";
        OkButton.UseVisualStyleBackColor = true;
        OkButton.Click += OkButton_Click;
        // 
        // PromptPopup
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(549, 190);
        Controls.Add(OkButton);
        Controls.Add(CancelButton);
        Controls.Add(textBox1);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Name = "PromptPopup";
        StartPosition = FormStartPosition.CenterParent;
        Text = "PromptPopup";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBox1;
    private Button CancelButton;
    private Button OkButton;
}