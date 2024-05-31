namespace OperacionesApp.Tabbed;

public partial class AreaCuadrado : ContentPage
{
	public AreaCuadrado()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
		try
		{
			double cuadrado= double.Parse(txtN1.Text) * double.Parse(txtN2.Text);
			txtResultado.Text= cuadrado.ToString();
		}
		catch (Exception ex) 
		{ 
			txtResultado.Text= ex.Message;
		}
    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
		txtN1.Text = "";
        txtN2.Text = "";
		txtResultado.Text = "";

    }
}