namespace OperacionesApp.Tabbed;

public partial class AreaTriangulo : ContentPage
{
	public AreaTriangulo()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        try
        {
            double triangulo = double.Parse(txtN1.Text) * double.Parse(txtN2.Text)/2;
            txtResultado.Text = triangulo.ToString();
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