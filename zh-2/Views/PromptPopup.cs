namespace hazi2.Views;

public partial class PromptPopup : Form
{
    private readonly string _defVal;
    private readonly Func<string, string?> _handler;

    public PromptPopup(string title, string question, string defVal, Func<string, string?> handler)
    {
        InitializeComponent();

        Text = title;
        _defVal = defVal;
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

    private void DefaultButton_Click(object sender, EventArgs e)
    {
        textBox1.Text = _defVal;
    }
}
