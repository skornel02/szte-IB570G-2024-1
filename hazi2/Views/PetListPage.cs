using hazi2.Controllers;
using hazi2.Models;

namespace hazi2.Views;

public partial class PetListPage : UserControl
{
    private readonly BindingSource _bindingSource;

    public PetListPage()
    {
        InitializeComponent();
        _bindingSource = [];
    }

    private void PetListPage_Load(object sender, EventArgs e)
    {
        PetController.Instance.OnPetsChange += HandlePetUpdate;
    }

    private void HandlePetUpdate(List<PetEntity> pets)
    {
        if (petGridView.DataSource != _bindingSource)
        {
            _bindingSource.DataSource = pets;
            petGridView.DataSource = _bindingSource;
        }

        _bindingSource.ResetBindings(false);
    }

    protected override void OnHandleDestroyed(EventArgs e)
    {
        PetController.Instance.OnPetsChange -= HandlePetUpdate;

        base.OnHandleDestroyed(e);
    }

    private void petGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1)
        {
            return;
        }

        var row = (PetEntity) petGridView.Rows[e.RowIndex].DataBoundItem;

        var form = new EditPetForm(PetController.Instance, row);
        var result = form.ShowDialog();

        if (result == DialogResult.OK)
        {
            MessageBox.Show("Sikeres kisállat szerkesztés!");
        }
    }
}
