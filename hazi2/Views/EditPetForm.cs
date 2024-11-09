using hazi2.Controllers;
using hazi2.Models;
using IdGen;

namespace hazi2.Views;

public partial class EditPetForm : Form
{
    private readonly PetController _controller;
    private readonly PetEntity? _edit;

    public EditPetForm(PetController controller, PetEntity? edit = null)
    {
        _controller = controller;
        _edit = edit;

        InitializeComponent();
    }

    private void AddPetForm_Load(object sender, EventArgs e)
    {
        CategoryDropdown.Items.Clear();
        CategoryDropdown.Items.AddRange([.. _controller.Categories]);

        if (_edit != null)
        {
            NameTextbox.Text = _edit.Name;
            CategoryDropdown.Text = _edit.Category;
            AgeNumeric.Value = _edit.Age;
            WeightNumeric.Value = _edit.Weight;
            GenderMale.Checked =_edit.Gender == "Hím";
            GenderFemale.Checked = _edit.Gender == "Nőstény";

            TitleLabel.Text = "Kisállat szerkesztése";
            AddButton.Text = "Mentés";
        }
    }

    private void DefaultValueButton_Click(object sender, EventArgs e)
    {
        NameTextbox.Text = "Bodri";
        CategoryDropdown.Text = "Kutya";
        AgeNumeric.Value = 5;
        WeightNumeric.Value = 10.1M;
        GenderMale.Checked = true;
        GenderFemale.Checked = false;
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NameTextbox.Text) || string.IsNullOrWhiteSpace(CategoryDropdown.Text))
        {
            MessageBox.Show("Hiányzó adatok!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (GenderMale.Checked == false && GenderFemale.Checked == false)
        {
            MessageBox.Show("Hiányzó adatok!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (AgeNumeric.Value <= 0 || WeightNumeric.Value <= 0)
        {
            MessageBox.Show("Hiányzó adatok!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!_controller.Categories.Contains(CategoryDropdown.Text))
        {
            MessageBox.Show("Hibás kategória!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (_edit is null)
        {
            var pet = new PetEntity
            {
                Id = new IdGenerator(0).CreateId(),
                Name = NameTextbox.Text,
                Category = CategoryDropdown.Text,
                Age = (int)AgeNumeric.Value,
                Weight = WeightNumeric.Value,
                Gender = GenderMale.Checked ? "Hím" : "Nőstény",
            };

            if (_controller.AddPet(pet))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Hiba az adatbázisban!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        else
        {
            _edit.Name = NameTextbox.Text;
            _edit.Category = CategoryDropdown.Text;
            _edit.Age = (int)AgeNumeric.Value;
            _edit.Weight = WeightNumeric.Value;
            _edit.Gender = GenderMale.Checked ? "Hím" : "Nőstény";

            if (_controller.UpdatePet(_edit))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Hiba az adatbázisban!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
        NameTextbox.Text = "";
        CategoryDropdown.Text = "";
        AgeNumeric.Value = 0;
        WeightNumeric.Value = 0;
        GenderMale.Checked = false;
        GenderFemale.Checked = false;
    }
}
