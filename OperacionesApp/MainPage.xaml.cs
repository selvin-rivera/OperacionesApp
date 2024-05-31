namespace OperacionesApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnTabbd_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Tabbed.Tab1());
        }
    }

}
