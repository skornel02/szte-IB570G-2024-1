using hazi2.Controllers;
using hazi2.Views;
using IdGen;

namespace hazi2;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        PetController.Instance.AddPet(new()
        {
            Id = new IdGenerator(0).CreateId(),
            Name = "Bodri",
            Category = "Kutya",
            Age = 5,
            Gender = "H�m",
            Weight = 10
        });
    }

    private void list�z�sToolStripMenuItem_Click(object sender, EventArgs e)
    {
        PetListPage.Visible = true;
    }

    private void �jFelv�teleToolStripMenuItem_Click(object sender, EventArgs e)
    {

        var form = new EditPetForm(PetController.Instance);

        var result = form.ShowDialog();

        if (result == DialogResult.OK)
        {
            MessageBox.Show("Sikeres kis�llat hozz�ad�s!");
        }
    }

    private void export�l�sToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var pets = PetController.Instance.Pets.Select(_ => _.ExportString);

        var result = saveFileDialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            File.WriteAllLines(saveFileDialog.FileName, pets);

            MessageBox.Show("Sikeres export�l�s!");
        }
    }

    private void �jKateg�riaFelv�teleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var categoryPopup = new PromptPopup("Kateg�ria hozz�ad�sa", "Kateg�ria neve:", (category) =>
        {
            if (string.IsNullOrWhiteSpace(category))
            {
                return "Hi�nyz� adatok!";
            }

            if (PetController.Instance.Categories.Contains(category, StringComparer.CurrentCultureIgnoreCase))
            {
                return "M�r l�tezik ilyen kateg�ria!";
            }

            PetController.Instance.Categories.Add(category);

            return null;
        });

        categoryPopup.ShowDialog();
    }
}
