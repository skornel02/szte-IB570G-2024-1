using hazi2.Controllers;
using hazi2.Persistance;
using hazi2.Views;
using IdGen;

namespace hazi2;

public partial class MainForm : Form
{
    private readonly PetController? _controller;

    public MainForm()
    {
        InitializeComponent();

        _controller = new PetController(new PetMemoryStore());
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _controller?.AddPet(new()
        {
            Id = new IdGenerator(0).CreateId(),
            Name = "Bodri",
            Category = "Kutya",
            Age = 5,
            Gender = "Hím",
            Weight = 10
        });
    }

    private void listazasToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (_controller is null)
        {
            MessageBox.Show("Nincs inicializálva a vezérlő!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        PetListPage.Controller = _controller;
        PetListPage.Visible = true;
    }

    private void ujFelveteleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (_controller is null)
        {
            MessageBox.Show("Nincs inicializálva a vezérlő!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var form = new EditPetForm(_controller);

        var result = form.ShowDialog();

        if (result == DialogResult.OK)
        {
            MessageBox.Show("Sikeres kisállat hozzáadás!");
        }
    }

    private void exportalasToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (_controller is null)
        {
            MessageBox.Show("Nincs inicializálva a vezérlő!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var pets = _controller.Pets.Select(_ => _.ExportString);

        var result = saveFileDialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            File.WriteAllLines(saveFileDialog.FileName, pets);

            MessageBox.Show("Sikeres exportálás!");
        }
    }

    private void újKategóriaFelvételeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (_controller is null)
        {
            MessageBox.Show("Nincs inicializálva a vezérlő!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var categoryPopup = new PromptPopup("Kategória hozzáadása", "Kategória neve:", "Cica", (category) =>
        {
            if (string.IsNullOrWhiteSpace(category))
            {
                return "Hiányzó adatok!";
            }

            if (_controller.Categories.Contains(category, StringComparer.CurrentCultureIgnoreCase))
            {
                return "Már létezik ilyen kategória!";
            }

            _controller.Categories.Add(category);
            MessageBox.Show("Sikeres kategória hozzáadás!");

            return null;
        });

        categoryPopup.ShowDialog();
    }
}
