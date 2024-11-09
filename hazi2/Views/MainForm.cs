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
            Gender = "Hím",
            Weight = 10
        });
    }

    private void listázásToolStripMenuItem_Click(object sender, EventArgs e)
    {
        PetListPage.Visible = true;
    }

    private void újFelvételeToolStripMenuItem_Click(object sender, EventArgs e)
    {

        var form = new EditPetForm(PetController.Instance);

        var result = form.ShowDialog();

        if (result == DialogResult.OK)
        {
            MessageBox.Show("Sikeres kisállat hozzáadás!");
        }
    }

    private void exportálásToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var pets = PetController.Instance.Pets.Select(_ => _.ExportString);

        var result = saveFileDialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            File.WriteAllLines(saveFileDialog.FileName, pets);

            MessageBox.Show("Sikeres exportálás!");
        }
    }

    private void újKategóriaFelvételeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var categoryPopup = new PromptPopup("Kategória hozzáadása", "Kategória neve:", (category) =>
        {
            if (string.IsNullOrWhiteSpace(category))
            {
                return "Hiányzó adatok!";
            }

            if (PetController.Instance.Categories.Contains(category, StringComparer.CurrentCultureIgnoreCase))
            {
                return "Már létezik ilyen kategória!";
            }

            PetController.Instance.Categories.Add(category);

            return null;
        });

        categoryPopup.ShowDialog();
    }
}
