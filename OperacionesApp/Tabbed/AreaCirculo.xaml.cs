namespace OperacionesApp.Tabbed;

public partial class AreaCirculo : ContentPage
{
	public AreaCirculo()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        try
        {
            double circulo = double.Parse(txtN1.Text) * double.Parse(txtN2.Text) * 3.14159;
            txtResultado.Text = circulo.ToString();
        }
        catch (Exception ex)
        {
            txtResultado.Text = ex.Message;
        }
    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
        txtN1.Text = "";
        txtN2.Text = "";
        txtResultado.Text = "";
    }
}