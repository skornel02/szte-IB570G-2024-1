namespace hazi2.Views;

public partial class PromptPopup : Form
{
    private readonly Func<string, string?> _handler;

    public PromptPopup(string title, string question, Func<string, string?> handler)
    {
        InitializeComponent();

        Text = title;
        label1.Text = question;

        _handler = handler;
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void OkButton_Click(object sender, EventArgs e)
    {
        var result = _handler(textBox1.Text);

        if (result is null)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        else
        {
            MessageBox.Show(result, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
