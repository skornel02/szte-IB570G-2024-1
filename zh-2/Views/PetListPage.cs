using hazi2.Controllers;
using hazi2.Models;

namespace hazi2.Views;

public partial class PetListPage : UserControl
{
    private readonly BindingSource _bindingSource;

    private PetController? _controller;
    public PetController Controller
    {
        set
        {
            if (_controller is not null)
            {
                _controller.OnPetsChange -= HandlePetUpdate;
            }

            _controller = value;
            _controller.OnPetsChange += HandlePetUpdate;
        }
    }

    public PetListPage()
    {
        InitializeComponent();
        _bindingSource = [];
    }

    private void PetListPage_Load(object sender, EventArgs e)
    {

    }

    private void HandlePetUpdate(List<PetEntity> pets)
    {
        _bindingSource.DataSource = pets;

        if (petGridView.DataSource != _bindingSource)
        {
            petGridView.DataSource = _bindingSource;
        }

        _bindingSource.ResetBindings(false);
    }

    protected override void OnHandleDestroyed(EventArgs e)
    {
        if (_controller is not null)
        {
            _controller.OnPetsChange -= HandlePetUpdate;
        }

        base.OnHandleDestroyed(e);
    }

    private void petGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (_controller is null)
        {
            return;
        }

        if (e.RowIndex == -1)
        {
            return;
        }

        var pet = (PetEntity)petGridView.Rows[e.RowIndex].DataBoundItem;

        if (e.ColumnIndex != 7)
        {

            var form = new EditPetForm(_controller, pet);
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Sikeres kisállat szerkesztés!");
            }
        }
        else
        {
            var result = MessageBox.Show($"Biztosan törölni szeretné {pet.Name}-et az életéből?", "Figyelem", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var success = _controller.RemovePet(pet);

                if (success)
                {
                    MessageBox.Show($"Sikeres megszabadultál {pet.Name}-től!");
                } 
                else
                {
                    MessageBox.Show("Hiba az adatbázisban!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
