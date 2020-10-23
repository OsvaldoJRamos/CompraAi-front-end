using System;


namespace CompraAi.Views

{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        private async void btnLogar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
    }
}
